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
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;

namespace Zenix.WinUI.Forms.ReçeteFormu
{
    public partial class ReçeteEditForm : BaseEditForm
    {
        public ReçeteEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl2;
            this.Bll = new ReçeteBll(myDataLayoutControl2);
            this.KartTuru = Common.Enums.KartTuru.Reçete;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new ReçeteS() : ((ReçeteBll)Bll).Single(FilterFunctions.Filter<Reçete>(Id));
            NesneyiKontrollereBagla();
            TabloYükle();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ReçeteBll)Bll).YeniKodVer();
            txtÜrün.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (ReçeteS)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtÜrün.Id = entity.ÜrünId;
            txtRevizyon.Id = entity.RevizyonId;
            txtAFaz.Text = entity.AFazıHazırlanış;
            txtBFaz.Text = entity.BFazıHazırlanış;
            txtCFaz.Text = entity.CFazıHazırlanış;
            txtDFaz.Text = entity.DFazıHazırlanış;
            txtEFaz.Text = entity.EFazıHazırlanış;

            txtAçıklama.Text = entity.Açıklama;
            if (BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert) return;
            txtÜrün.Text = $"[{entity.MarkaAdı}-{entity.MamülAdı}-{entity.GTIN}]";
            txtRevizyon.Text = entity.RevKodu;
            txtÜrün.Tag = new ÜrünL
            {
                Id = entity.ÜrünId,
                GTIN = entity.GTIN,
                MamülAdı = entity.MamülAdı,
                MarkaAdı = entity.MarkaAdı,
                FirmaAdi = entity.FirmaAdi,

            };

        }
        protected override void GuncelNesneOluştur()
        {
            CurrentEntity = new Reçete
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                RevizyonId = txtRevizyon.GetId(),
                ÜrünId = txtÜrün.GetId(),
                AFazıHazırlanış = txtAFaz.Text,
                BFazıHazırlanış = txtBFaz.Text,
                CFazıHazırlanış = txtCFaz.Text,
                DFazıHazırlanış = txtDFaz.Text,
                EFazıHazırlanış = txtEFaz.Text,
                Açıklama = txtAçıklama.Text,

            };
            ButtonEnableDurumu();
        }
        protected override void SeçimYap(object sender)
        {
            if (!(sender is myButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtÜrün)
                {
                    sec.Seç(txtÜrün);
                    using (var revbll = new RevizyonBll())
                    {
                        var entity = revbll.GetMaxRevizyon(txtÜrün.GetId());
                        if (entity == null) return;
                        txtRevizyon.Id = entity.Id;
                        txtRevizyon.Text = entity.RevKodu;
                    }
                }
                if (sender == txtRevizyon)
                    sec.Seç(txtRevizyon, txtÜrün);

            }
        }
        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender == txtÜrün)
                txtÜrün.KontrolEnabledChange(txtRevizyon);
            EditValueChanged(sender, e);
        }
        protected override void EditValueChanged(object sender, EventArgs e)
        {
            //if (sender is myButtonEdit btn && btn == txtRevizyon && ((ReçeteS)OldEntity).RevizyonId != btn.Id)
            //    txtKod.Text = ((ReçeteBll)Bll).YeniKodVer(x => x.RevizyonId == btn.Id);
            base.EditValueChanged(sender, e);
        }
        protected override void TabloYükle()
        {
            reçeteMalzemeleriTable.ownerform = this;

            reçeteMalzemeleriTable.Yukle();
        }
        protected internal override void ButtonEnableDurumu()
        {
            if (!isLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, reçeteMalzemeleriTable.tablevaluechanged);
        }

        protected override bool EntityInsert()
        {

            if (reçeteMalzemeleriTable.HatalıGiriş()) return false;
            return base.EntityInsert() && reçeteMalzemeleriTable.Kaydet();
        }
        protected override bool EntityUpdate()
        {

            if (reçeteMalzemeleriTable.HatalıGiriş()) return false;
            return base.EntityUpdate() && reçeteMalzemeleriTable.Kaydet();
        }
    }
}