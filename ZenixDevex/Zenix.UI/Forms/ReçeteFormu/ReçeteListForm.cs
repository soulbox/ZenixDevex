using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using Zenix.WinUI.MainForm;
using Zenix.WinUI.Show;
using Zenix.Model.DTO;
using Zenix.Common.Enums;
using Zenix.Common.Messages;
using Zenix.Model.Entities.Base;

namespace Zenix.WinUI.Forms.ReçeteFormu
{
    public partial class ReçeteListForm : BaseListForm
    {
        public ReçeteListForm()
        {
            InitializeComponent();
            Bll = new ReçeteBll();
        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Reçete;
            this.FormShow = new ShowEditForms<ReçeteEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Reçeteler";
            Tablo.ViewCaption = Text;

        }
        protected override void Listele()
        {
            var liste = ((ReçeteBll)Bll).List(x => x.Durum == AktifKayitlariGoster);

            Tablo.GridControl.DataSource = liste;
        }
        protected override void SagMenuGoster(object sender, MouseEventArgs e)
        {
            var isRight = (e.Button == MouseButtons.Right);
            var entity = Tablo.GetRow<ReçeteL>();
            ShowHideButtons(entity != null, btnYeniRevizyon);
            base.SagMenuGoster(sender, e);
        }
        protected override void YeniRevizyon()
        {
            var entity = Tablo.GetRow<ReçeteL>();
            //eskilogic
            //var clone = entity.Clone;
            //var result = new ShowEditForms<ReçeteEditForm>().ShowDialogEditForm(Common.Enums.KartTuru.Reçete, clone.Id, clone);
            //Listele();
            //ShowEditFormDefault(result);
            using (var revbll = new RevizyonBll())
            using (var reçetemalbll = new ReçeteMalzemelerBll())
            {
                var yeniId = IslemTuru.EntityInsert.IdOlustur(null);
                var revkod = revbll.YeniKodVer(x => x.ÜrünId == entity.ÜrünId);
                var yenirev = new Revizyon
                {
                    Id = yeniId,
                    Durum = true,
                    Kod = revkod,
                    BaseRevKod = revkod,
                    RevizyonTarihi = DateTime.Now,
                    ÜrünId = entity.ÜrünId
                };
                var yenireçete = new Reçete
                {
                    Id = yeniId,
                    Kod = ((ReçeteBll)Bll).YeniKodVer(),
                    Durum = true,
                    AFazıHazırlanış = entity.AFazıHazırlanış,
                    BFazıHazırlanış = entity.BFazıHazırlanış,
                    CFazıHazırlanış = entity.CFazıHazırlanış,
                    DFazıHazırlanış = entity.DFazıHazırlanış,
                    EFazıHazırlanış = entity.EFazıHazırlanış,
                    Açıklama = entity.Açıklama,
                    RevizyonId = yeniId,
                    ÜrünId = entity.ÜrünId,
                };
                var msgres = Msg.HayirSeciliEvetHayir($"{entity.MamülAdı}\nYeni Revizyon Kodu:'{yenirev.RevKodu}'\nOlarak Eklenicek Onaylıyormusunuz?", "Onay");
                if (msgres != DialogResult.Yes) return;
                var list = reçetemalbll.List(x => x.ReçeteId == entity.Id).Cast<ReçeteMalzemeleriL>().ToList();
                list.ForEach(x =>
                {
                    x.ReçeteId = yeniId;
                    x.Insert = true;
                });

                var res1 = revbll.Insert(yenirev);
                var res2 = ((ReçeteBll)Bll).Insert(yenireçete);
                var res3 = reçetemalbll.Insert(list.Cast<BaseEntityHaraket>().ToList());
                if (!res1 && !res1 && !res3)
                    Msg.HataMesajı("Yeni Revizyon Eklenemedi");
                else
                {

                    Listele();
                    tablo.RowFocus("Id", yeniId);
                    ShowEditForm(yeniId);
                }


            }

        }
    }
}