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
    public partial class ÜrünDepoListForm : BaseListForm
    {
        public ÜrünDepoListForm()
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
            Text = "Ürün Depo";
            Tablo.ViewCaption = Text;
            //ShowHideButtons(IsMdiChild, btnBağlıKayıtları);
            //btnBağlıKayıtları.Caption = "Ürünleri";
            TabloSipariş.MouseUp += TabloSipariş_MouseUp;
            btnSevkOnayla.ItemClick += btnSevkOnayla_ItemClick;
            btnTümüSevk.ItemClick += btnTümüSevk_ItemClick;
            btnSevk.ItemClick += btnSevk_ItemClick;

        }
        private void btnSevk_ItemClick(object sender, ItemClickEventArgs e)
        {
            var entity = TabloSipariş.GetRow<SiparişÜrünleriL>();
            if (entity == null && entity.EksikFazla > 0) return;
            if (entity.Stok < Math.Abs(entity.EksikFazla))
            {
                Msg.HataMesajı("Stok Yetersiz");
                return;
            }
            var yeni = new Depo
            {
                Id = IslemTuru.EntityInsert.IdOlustur(null),
                DepoMiktar = -1 * Math.Abs(entity.EksikFazla),
                DepoTipi = DepoTipi.Sevkiyat,
                Kod = ((DepoBll)Bll).YeniKodVer(),
                MamülId = entity.MamülId,
                SiparişId = entity.SiparişId,
                ÜrünId = entity.ÜrünId,

            };

            if (!((DepoBll)Bll).Insert(yeni))
                Msg.HataMesajı("Depoya Eklenemedi");
            else
            {
                using (var siparişÜrünleriBll = new SiparişÜrünleriBll())
                {
                    entity.Teslimat = true;
                    var update = new List<BaseEntityHaraket>() { entity.EntityConvert<SiparişÜrünleri>() };
                    siparişÜrünleriBll.Update(update);
                }
                Listele();
            }

        }

        private void btnTümüSevk_ItemClick(object sender, ItemClickEventArgs e)
        {
            var entity = TabloSipariş.GetRow<SiparişÜrünleriL>();
            if (entity == null) return;
            var source = TabloSipariş.DataController.ListSource.Cast<SiparişÜrünleriL>()
                .Where(x => x.FirmaId == entity.FirmaId && x.EksikFazla < 0).ToList();
            var eksikstok = source.Any(x => x.Stok < Math.Abs(x.EksikFazla));
            if (eksikstok)
            {
                Msg.HataMesajı("Stok Yetersiz");
                return;
            }
            var eklenicekler = source.Select(x => new Depo
            {
                Id = IslemTuru.EntityInsert.IdOlustur(null),
                DepoMiktar = -1 * Math.Abs(x.EksikFazla),
                DepoTipi = DepoTipi.Sevkiyat,
                Kod = ((DepoBll)Bll).YeniKodVer(),
                MamülId = x.MamülId,
                SiparişId = x.SiparişId,
                ÜrünId = x.ÜrünId,
            }).Cast<BaseEntity>().ToList();
            if (!((DepoBll)Bll).Insert(eklenicekler))
                Msg.HataMesajı("Depoya Eklenemedi");
            else
            {
                using (var siparişÜrünleriBll = new SiparişÜrünleriBll())
                {
                    var update = source.EntityListConvert<SiparişÜrünleri>();
                    update.ToList().ForEach(x => x.Teslimat = true);
                    siparişÜrünleriBll.Update(update.Cast<BaseEntityHaraket>().ToList());
                }
                Listele();
            }


        }

        private void btnSevkOnayla_ItemClick(object sender, ItemClickEventArgs e)
        {
            var entity = TabloSipariş.GetRow<SiparişÜrünleriL>();
            if (entity == null) return;
            var value = barbirkısmıSevk.EditValue.ConvertTo<float>();
            if (value > entity.Stok)
            {
                Msg.HataMesajı($"Stok Yetersiz\nMaksimum {value:n0} kadar gönderebilirsiniz");
                return;
            }
            var yeni = new Depo
            {
                Id = IslemTuru.EntityInsert.IdOlustur(null),
                DepoMiktar = -1 * barbirkısmıSevk.EditValue.ConvertTo<float>(),
                DepoTipi = DepoTipi.Sevkiyat,
                Kod = ((DepoBll)Bll).YeniKodVer(),
                MamülId = entity.MamülId,
                SiparişId = entity.SiparişId,
                ÜrünId = entity.ÜrünId,

            };
            if (!((DepoBll)Bll).Insert(yeni))
                Msg.HataMesajı("Depoya Eklenemedi");
            else
            {
                //eksik varsa ve girilen miktar eksik sayısına eşit veya büyükse teslim alındı.
                if (entity.EksikFazla < 0 && barbirkısmıSevk.EditValue.ConvertTo<float>() >= Math.Abs(entity.EksikFazla))
                    using (var siparişÜrünleriBll = new SiparişÜrünleriBll())
                    {
                        entity.Teslimat = true;
                        var update = new List<BaseEntityHaraket>() { entity.EntityConvert<SiparişÜrünleri>() };
                        siparişÜrünleriBll.Update(update);
                    }
                Listele();
            }

        }

        private void TabloSipariş_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var entity = TabloSipariş.GetRow<SiparişÜrünleriL>();
            if (entity == null) return;
            var eksikvarmı = entity.EksikFazla < 0 & Math.Abs(entity.EksikFazla) <= entity.Stok;
            ShowHideButtons(eksikvarmı, btnSevk, btnSubSevkItem);
            //txtBirKısımSevk.MaxValue = eksikvarmı ? (decimal)(-1 * entity.EksikFazla) : 0;
            txtBirKısımSevk.MaxValue = eksikvarmı ? (decimal)(entity.Stok) : 0;

            txtBirKısımSevk.MinValue = eksikvarmı ? 1 : 0;
            barbirkısmıSevk.EditValue = Math.Abs(entity.EksikFazla);
            var ListeEksikvarmı = TabloSipariş.DataController.ListSource.Cast<SiparişÜrünleriL>()
                .Any(x => x.FirmaId == entity.FirmaId && x.EksikFazla < 0);
            ShowHideButtons(ListeEksikvarmı, btnTümüSevk);
            bool Visiblecheck(params BarItem[] bars) =>
                bars.Any(x => x.Visibility == BarItemVisibility.Always);
            if (Visiblecheck(btnSevk, btnTümüSevk, btnSubSevkItem))
                popupMenuSatınalma.ShowPopup(MousePosition);


        }
        protected override void ShowEditForm(long id)
        {
            //base.ShowEditForm(id);
        }
        protected override void Listele()
        {
            var depolist = ((DepoBll)Bll).MalzemeDepoList(x => x.ÜrünId != null);
            Tablo.GridControl.DataSource = depolist;
            using (var siparişbll = new SiparişÜrünleriBll())
            {

                var liste = siparişbll.SiparişListesi(x => x.Sipariş.Durum && !x.Teslimat);

                liste.ForEach(x =>
                {
                    var sevktoplam = depolist.Where(a => a.ÜrünId == x.ÜrünId & a.SiparişId == x.SiparişId).Sum(a => a.DepoMiktar);
                    x.Gelen = Math.Abs(sevktoplam);
                    x.Stok = depolist.Where(a => a.ÜrünId == x.ÜrünId).Sum(a => a.DepoMiktar);

                });

                TabloSipariş.GridControl.DataSource = liste;
            }
        }
    }
}