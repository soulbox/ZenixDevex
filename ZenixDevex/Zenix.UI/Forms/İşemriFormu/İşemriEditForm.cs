using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;
using Zenix.WinUI.MainForm;

namespace Zenix.WinUI.Forms.İşemriFormu
{
    public partial class İşemriEditForm : BaseEditForm
    {
        int şarjno = 1;

        public İşemriEditForm()
        {
            InitializeComponent();

            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new İşemriBll(myDataLayoutControl);
            this.KartTuru = KartTuru.İşemri;
            EventsLoad();


        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new İşemriS() : ((İşemriBll)Bll).Single(FilterFunctions.Filter<İşemri>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((İşemriBll)Bll).YeniKodVer(x => x.ReçeteId == ((İşemriS)OldEntity).ReçeteId);
            txtReçete.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (İşemriS)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtReçete.Id = entity.ReçeteId;
            txtŞarjMiktarı.EditValue = entity.ŞarjMiktarı;
            dtTarih.DateTime = entity.işemriTarih;
            if (BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert) return;
            txtReçete.Text = entity.ReçeteAdı;


        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new İşemri
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                işemriTarih = dtTarih.DateTime,
                KullanıcıId = AnaForm.Kullanıcı.Id,
                ReçeteId = txtReçete.Id.ConvertTo<long>(),
                ŞarjMiktarı = txtŞarjMiktarı.EditValue.ConvertTo<int>(),
                ŞarjNo = şarjno,    

            };
            ButtonEnableDurumu();
        }
        protected override void SeçimYap(object sender)
        {
            if (!(sender is myButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtReçete)
                    sec.Seç(txtReçete);
            }
        }
    }

}