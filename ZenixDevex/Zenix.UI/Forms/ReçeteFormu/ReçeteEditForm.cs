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
            txtKod.Text = ((ReçeteBll)Bll).YeniKodVer(x => x.RevizyonId == ((ReçeteS)OldEntity).RevizyonId);
            txtÜrün.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (ReçeteS)OldEntity;
            txtKod.Text = entity.Kod;
            txtFirma.Text = entity.FirmaAdı;
            txtFirma.Id = entity.FirmaId;
            txtÜrün.Text = entity.ÜrünAdı;
            txtÜrün.Id = entity.ÜrünId;
            txtRevizyon.Text = entity.RevKodu;
            txtRevizyon.Id = entity.RevizyonId;

            txtAFaz.Text = entity.AFazıHazırlanış;
            txtBFaz.Text = entity.BFazıHazırlanış;
            txtCFaz.Text = entity.CFazıHazırlanış;
            if (BaseIslemTuru == Common.Enums.IslemTuru.EntityUpdate)
            {
                //txtÜrün.Tag =
            }

        }
        protected override void GuncelNesneOluştur()
        {
            CurrentEntity = new Reçete
            {
                Id = Id,
                Kod = txtKod.Text,
                RevizyonId = txtRevizyon.Id.ConvertTo<long>(),
                AFazıHazırlanış = txtAFaz.Text,
                BFazıHazırlanış = txtBFaz.Text,
                CFazıHazırlanış = txtCFaz.Text,


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
                if (sender == txtRevizyon)
                    sec.Seç(txtRevizyon, txtÜrün);

            }
        }
        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender == txtFirma)
                txtFirma.KontrolEnabledChange(txtÜrün);
            if (sender == txtÜrün)
                txtÜrün.KontrolEnabledChange(txtRevizyon);
            if (sender == txtRevizyon)
                EditValueChanged(sender, e);
        }
        protected override void EditValueChanged(object sender, EventArgs e)
        {
            if (sender is myButtonEdit btn && btn == txtRevizyon && ((ReçeteS)OldEntity).RevizyonId != btn.Id)
                txtKod.Text = ((ReçeteBll)Bll).YeniKodVer(x => x.RevizyonId == btn.Id);
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
            return ((ReçeteBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.RevizyonId == txtRevizyon.Id) && reçeteMalzemeleriTable.Kaydet();
        }
        protected override bool EntityUpdate()
        {

            if (reçeteMalzemeleriTable.HatalıGiriş()) return false;
            return ((ReçeteBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.RevizyonId == txtRevizyon.Id) && reçeteMalzemeleriTable.Kaydet();
        }
    }
}