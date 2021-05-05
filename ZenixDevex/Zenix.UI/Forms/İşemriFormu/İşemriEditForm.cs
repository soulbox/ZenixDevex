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
        public İşemriEditForm()
        {
            InitializeComponent();
            System.Windows.Forms.MessageBox.Show("Yapımda");
            return;
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
            txtReçete.Text = entity.ReçeteAdı;
            txtReçete.Id = entity.ReçeteId;
            txtŞarj.Text = entity.ŞarjNo.ToString();
            //txtŞarj.Id = entity.ŞarjId;
            txtKazan.Text = entity.KazanNo.ToString();
            txtKazan.Id = entity.KazanId;
            txtŞarjMiktarı.EditValue = entity.ŞarzMiktarı;
            dtTarih.DateTime = entity.Tarih;

        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new İşemri
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                Tarih = dtTarih.DateTime,
                KullanıcıId = AnaForm.Kullanıcı.Id,
                KazanId = txtKazan.Id.ConvertTo<long>(),
                ReçeteId = txtReçete.Id.ConvertTo<long>(),
                //ŞarjId = txtŞarj.Id.ConvertTo<long>(),
                ŞarzMiktarı = txtŞarjMiktarı.EditValue.ConvertTo<int>(),


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
                else if (sender == txtŞarj)
                    sec.Seç(txtŞarj, txtReçete);
                else if (sender == txtKazan)
                    sec.Seç(txtKazan);
            }
        }
    }

}