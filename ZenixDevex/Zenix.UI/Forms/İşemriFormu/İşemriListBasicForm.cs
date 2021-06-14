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
using DevExpress.Data;
using Zenix.Model.DTO;
using Zenix.Common.Enums;
using Zenix.Common.Messages;
using Zenix.Model.Entities.Base;
using DevExpress.XtraGrid.Views.Base;
namespace Zenix.WinUI.Forms.İşemriFormu
{
    public partial class İşemriListBasicForm : BaseListForm

    {
        public İşemriListBasicForm()
        {
            InitializeComponent();
            Bll = new İşemriBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.İşemri;
            this.FormShow = new ShowEditForms<İşemriEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "İşemri Kartları ";
            Tablo.ViewCaption = Text;
            //ShowHideButtons(IsMdiChild, btnBağlıKayıtları);
            //btnBağlıKayıtları.Caption = "Ürünleri";


        }
        protected override void Listele()
        {
            var list = ((İşemriBll)Bll).List(FilterFunctions.Filter<İşemri>(AktifKayitlariGoster));

            Tablo.GridControl.DataSource = list;
        }
        protected override void SagMenuGoster(object sender, MouseEventArgs e)
        {
            var isRight = (e.Button == MouseButtons.Right);
            var entity = Tablo.GetRow<İşemriL>();
            ShowHideButtons(entity != null, btnYeniİşemri);
            base.SagMenuGoster(sender, e);
        }

        protected override void YeniİşemriKullan()
        {
            var entity = Tablo.GetRow<İşemriL>();
            var yeniId = IslemTuru.EntityInsert.IdOlustur(null);
            var revkod = ((İşemriBll)Bll).YeniKodVer();
            var şarjno = ((İşemriBll)Bll).MaxŞarj(entity.ÜrünId) + 1;
            var msgres = Msg.HayirSeciliEvetHayir($"{entity.MamülAdı}\nŞarj No:'{şarjno }'\nOlarak Eklenicek Onaylıyormusunuz?", "Onay");
            if (msgres != DialogResult.Yes) return;
            var yeniişemri = new İşemri
            {
                Id = yeniId,
                Kod = revkod,
                Durum = true,
                işemriTarih = DateTime.Now,
                KullaniciId = AnaForm.Kullanıcı.Id,
                ReçeteId = entity.ReçeteId,
                ŞarjMiktarı = entity.ŞarjMiktarı,
                ŞarjNo = ((İşemriBll)Bll).MaxŞarj(entity.ÜrünId) + 1,
            };
            var res1 = ((İşemriBll)Bll).Insert(yeniişemri);
            if (!res1)
                Msg.HataMesajı("Yeni İşemri Eklenemedi");
            else
            {

                Listele();
                tablo.RowFocus("Id", yeniId);
                ShowEditForm(yeniId);
            }

        }
        protected override void Tablo_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var entity = Tablo.GetRow<İşemriL>();

            if (entity.isNull())
            {
                ReçeteTablo.GridControl.DataSource = null;
                return;
            }
            using (var reçetebll = new ReçeteMalzemelerBll())
            {

                var list = reçetebll.List(x => x.ReçeteId == entity.ReçeteId).Cast<ReçeteMalzemeleriL>().Order();
                list.ForEach(x => x.ŞarjMiktarı = entity.ŞarjMiktarı);
                ReçeteTablo.GridControl.DataSource = list;
                var hacimlimalzeme = list.FirstOrDefault();
                ReçeteTablo.ViewCaption = hacimlimalzeme == null ? "Reçetesi" : $"Reçete-{hacimlimalzeme.HacimliMalzemeAdı}-Hacim:{hacimlimalzeme.Hacim}";

            }

        }
    }
}