using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;

namespace Zenix.WinUI.Forms.FirmaFormu
{
    public partial class FirmaEditFormu : BaseEditForm
    {

        public FirmaEditFormu()

        {

            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new FirmaBll(myDataLayoutControl);
            this.KartTuru = KartTuru.Firma;
            cmbFirmatipi.ToData<FirmaTipi>();
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new FirmalarL() : ((FirmaBll)Bll).Single(FilterFunctions.Filter<Firma>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((FirmaBll)Bll).YeniKodVer();
            txtFirmaAdi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (FirmalarL)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtFirmaAdi.Text = entity.FirmaAdi;
            cmbFirmatipi.Text = entity.FirmaTipi.ToName();
            txtAdress.Text = entity.Adres;
            txtVergiNo.Text = entity.VergiNo;
            txtVergiDairesi.Text = entity.VergiDairesi;
            txtÜlke.Text = entity.ÜlkeAdı;
            txtÜlke.Id = entity.ÜlkeId;
        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new Firma
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                FirmaAdi = txtFirmaAdi.Text,
                Adres = txtAdress.Text,
                VergiDairesi = txtVergiDairesi.Text,
                FirmaTipi = cmbFirmatipi.Text.GetEnum<FirmaTipi>(),
                VergiNo = txtVergiNo.Text.GetNumbers(),
                Tarih = ((Firma)OldEntity).Tarih,
                ÜlkeId = txtÜlke.Id.ConvertTo<long>(),

            };
            ButtonEnableDurumu();
        }
        protected override void SeçimYap(object sender)
        {
            if (!(sender is myButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtÜlke)
                    sec.Seç(txtÜlke);

            }
        }
    }
}