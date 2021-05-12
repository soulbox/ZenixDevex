using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.WinUI.Show;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using DevExpress.XtraBars;
using Zenix.WinUI.myUserControls.Grid;
using System.Linq;
using Zenix.Common.Function;
using DevExpress.XtraGrid.Views.Grid;
using Zenix.WinUI.MainForm;
using Zenix.Model.DTO;
using System.Drawing;
using Zenix.Common.Enums;
using Zenix.Common.Messages;
using Zenix.Model.Entities.Base;
using Zenix.BLL.Functions;

namespace Zenix.WinUI.Forms.DepoFormu
{
    public partial class MalzemeDepoListform : BaseListForm
    {
        public MalzemeDepoListform()
        {
            InitializeComponent();
            Bll = new DepoBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Depo;
            //this.FormShow = new ShowEditForms<FirmaEditFormu>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Malzeme Kartları ";
            Tablo.ViewCaption = Text;
            //ShowHideButtons(IsMdiChild, btnBağlıKayıtları);
            //btnBağlıKayıtları.Caption = "Ürünleri";
            TabloSatınAlma.MouseUp += TabloSatınAlma_MouseUp;
            btnMiktarOnayla.ItemClick += BtnMiktarOnayla_ItemClick;
            btnHepsiniAL.ItemClick += BtnHepsiniAL_ItemClick;
            btnAL.ItemClick += BtnAL_ItemClick;

        }

        private void BtnAL_ItemClick(object sender, ItemClickEventArgs e)
        {
            var entity = TabloSatınAlma.GetRow<SatınAlmaMalzemeleriDepo>();
            if (entity == null && entity.EksikFazla > 0) return;
            var yeni = new Depo
            {
                Id = IslemTuru.EntityInsert.IdOlustur(null),
                DepoMiktar = Math.Abs(entity.EksikFazla),
                DepoTipi = DepoTipi.Satınalma,
                Kod = ((DepoBll)Bll).YeniKodVer(),
                MamülId = entity.MamülId,
                SatınalmaId = entity.SatınalmaId,
            };

            if (!((DepoBll)Bll).Insert(yeni))
                Msg.HataMesajı("Depoya Eklenemedi");
            else
            {
                using (var satınalmabll = new SatınAlmaMalzemelerBll())
                {
                    entity.Teslimat = true;
                    var update = new List<BaseEntityHaraket>() { entity.EntityConvert<SatınAlmaMalzemeler>() };
                    satınalmabll.Update(update);
                }
                Listele();
            }

        }

        private void BtnHepsiniAL_ItemClick(object sender, ItemClickEventArgs e)
        {
            var entity = TabloSatınAlma.GetRow<SatınAlmaMalzemeleriDepo>();
            if (entity == null) return;
            var source = TabloSatınAlma.DataController.ListSource.Cast<SatınAlmaMalzemeleriDepo>()
                .Where(x => x.SatınalmaId == entity.SatınalmaId && x.EksikFazla < 0).ToList();
            var eklenicekler = source.Select(x => new Depo
            {
                Id = IslemTuru.EntityInsert.IdOlustur(null),
                DepoMiktar = Math.Abs(x.EksikFazla),
                DepoTipi = DepoTipi.Satınalma,
                Kod = ((DepoBll)Bll).YeniKodVer(),
                MamülId = x.MamülId,
                SatınalmaId = x.SatınalmaId,
            }).Cast<BaseEntity>().ToList();
            if (!((DepoBll)Bll).Insert(eklenicekler))
                Msg.HataMesajı("Depoya Eklenemedi");
            else
            {
                using (var satınalmabll = new SatınAlmaMalzemelerBll())
                {
                    var update = source.EntityListConvert<SatınAlmaMalzemeler>();
                    update.ToList().ForEach(x => x.Teslimat = true);
                    satınalmabll.Update(update.Cast<BaseEntityHaraket>().ToList());
                }
                Listele();
            }


        }

        private void BtnMiktarOnayla_ItemClick(object sender, ItemClickEventArgs e)
        {
            var entity = TabloSatınAlma.GetRow<SatınAlmaMalzemeleriDepo>();
            if (entity == null) return;
            var yeni = new Depo
            {
                Id = IslemTuru.EntityInsert.IdOlustur(null),
                DepoMiktar = barBirMiktar.EditValue.ConvertTo<float>(),
                DepoTipi = DepoTipi.Satınalma,
                Kod = ((DepoBll)Bll).YeniKodVer(),
                MamülId = entity.MamülId,
                SatınalmaId = entity.SatınalmaId,
            };
            if (!((DepoBll)Bll).Insert(yeni))
                Msg.HataMesajı("Depoya Eklenemedi");
            else
            {
                //eksik varsa ve girilen miktar eksik sayısına eşit veya büyükse teslim alındı.
                if (entity.EksikFazla < 0 && barBirMiktar.EditValue.ConvertTo<float>() >= Math.Abs(entity.EksikFazla))
                    using (var satınalmabll = new SatınAlmaMalzemelerBll())
                    {
                        entity.Teslimat = true;
                        var update = new List<BaseEntityHaraket>() { entity.EntityConvert<SatınAlmaMalzemeler>() };
                        satınalmabll.Update(update);
                    }
                Listele();
            }

        }

        private void TabloSatınAlma_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var entity = TabloSatınAlma.GetRow<SatınAlmaMalzemeleriDepo>();
            if (entity == null) return;
            var eksikvarmı = entity.EksikFazla < 0;
            ShowHideButtons(eksikvarmı, btnAL, barSubItemMiktar);
            repositoryItemSpinEditMiktar.MaxValue = eksikvarmı ? (decimal)(-1 * entity.EksikFazla) : 0;
            repositoryItemSpinEditMiktar.MinValue = eksikvarmı ? 1 : 0;
            var ListeEksikvarmı = TabloSatınAlma.DataController.ListSource.Cast<SatınAlmaMalzemeleriDepo>()
                .Any(x => x.SatınalmaId == entity.SatınalmaId && x.EksikFazla < 0);
            ShowHideButtons(ListeEksikvarmı, btnHepsiniAL);
            bool Visiblecheck(params BarItem[] bars) =>
                bars.Any(x => x.Visibility == BarItemVisibility.Always);
            if (Visiblecheck(btnAL, btnHepsiniAL, barSubItemMiktar))
                popupMenuSatınalma.ShowPopup(MousePosition);


        }

        protected override void Listele()
        {
            var depolist = ((DepoBll)Bll).MalzemeDepoList(x => x.Mamül.MalzemeTipi != Common.Enums.MalzemeTipi.Ürün);
            Tablo.GridControl.DataSource = depolist;
            using (var satınalmabll = new SatınAlmaMalzemelerBll())
            {

                var liste = satınalmabll.Deposatınalma(x => x.Satınalma.Durum && !x.Teslimat);

                liste.ForEach(x =>
                {
                    x.Gelen = depolist.Where(a => a.MamülId == x.MamülId & a.SatınalmaId == x.SatınalmaId).Sum(a => a.DepoMiktar);
                    x.Stok = depolist.Where(a => a.MamülId == x.MamülId).Sum(a => a.DepoMiktar);

                });

                TabloSatınAlma.GridControl.DataSource = liste;
            }
        }
    }
}