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
using Zenix.WinUI.Show;
using Zenix.Model.DTO;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Enums;
using Zenix.Common.Function;
using Zenix.WinUI.MainForm;
using Zenix.WinUI.myUserControls.Controls;

namespace Zenix.WinUI.Forms.SiparişFormu
{
    public partial class SiparişEditForm : BaseEditForm
    {
        public SiparişEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new SiparişBll(myDataLayoutControl);
            this.KartTuru = KartTuru.Sipariş;
            cmbBirim.ToData<BirimTipi>();
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new SiparişS() : ((SiparişBll)Bll).Single(FilterFunctions.Filter<Sipariş>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SiparişBll)Bll).YeniKodVer();
            txtFirma.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SiparişS)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtFirma.Text = entity.FirmaAdı;
            txtFirma.Id = entity.FirmaId;
            txtÜrün.Text = entity.ÜrünAdı;
            txtÜrün.Id = entity.Id;
            txtMiktar.EditValue = entity.Miktar;
            cmbBirim.Text = entity.BirimTipi.ToName();
            txtAçıklama.Text = entity.Açıklama;
            dtTarih.DateTime = entity.Tarih;

        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new Sipariş
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                ÜrünId = txtÜrün.Id.ConvertTo<long>(),
                BirimTipi = cmbBirim.Text.GetEnum<BirimTipi>(),
                KullanıcıId = AnaForm.Kullanıcı.Id,
                Miktar = txtMiktar.EditValue.ConvertTo<int>(),
                Tarih = dtTarih.DateTime,
                Açıklama = txtAçıklama.Text,

            };
            ButtonEnableDurumu();
        }

        protected override void SeçimYap(object sender)
        {
            if (!(sender is myButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtFirma)
                    sec.Seç(txtFirma);
                if (sender == txtÜrün)
                    sec.Seç(txtÜrün, txtFirma);

            }
        }
        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender == txtFirma)
                txtFirma.KontrolEnabledChange(txtÜrün);
        }
    }
}