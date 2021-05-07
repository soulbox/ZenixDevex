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

namespace Zenix.WinUI.Forms.SatınAlmaFormu
{
    public partial class SatınAlmaEditForm : BaseEditForm
    {
        public SatınAlmaEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new SatınAlmaBll(myDataLayoutControl);
            this.KartTuru = Common.Enums.KartTuru.SatınAlma;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new SatınalmaS() : ((SatınAlmaBll)Bll).Single(FilterFunctions.Filter<Satınalma>(Id));
            NesneyiKontrollereBagla();
            TabloYükle();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SatınAlmaBll)Bll).YeniKodVer();
            txtFirma.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SatınalmaS)OldEntity;
            txtKod.Text      = entity.Kod;
            tglDurum.IsOn    = entity.Durum;
            txtFirma.Text    = entity.FirmaAdi;
            txtFirma.Id      = entity.FirmaId;
            dtTarih.DateTime = entity.Tarih;


        }
        protected override void GuncelNesneOluştur()
        {
            CurrentEntity = new Satınalma
            {
                Id          = Id,
                Kod         = txtKod.Text,
                Durum       = tglDurum.IsOn,
                FirmaId     = txtFirma.GetId(),
                KullanıcıId = AnaForm.Kullanıcı.Id,
                Tarih = dtTarih.DateTime,


            };
            ButtonEnableDurumu();
        }
        protected override void SeçimYap(object sender)
        {
            if (!(sender is myButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtFirma)
                {
                    sec.Seç(txtFirma);                   
                }

            }
        }
        protected override void EditValueChanged(object sender, EventArgs e)
        {
            //if (sender is myButtonEdit btn && btn == txtRevizyon && ((ReçeteS)OldEntity).RevizyonId != btn.Id)
            //    txtKod.Text = ((ReçeteBll)Bll).YeniKodVer(x => x.RevizyonId == btn.Id);
            base.EditValueChanged(sender, e);
        }
        protected override void TabloYükle()
        {
            satınAlmaMalzemeleriTable.ownerform = this;

            satınAlmaMalzemeleriTable.Yukle();
        }
        protected internal override void ButtonEnableDurumu()
        {
            if (!isLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity, satınAlmaMalzemeleriTable.tablevaluechanged);
        }

        protected override bool EntityInsert()
        {

            if (satınAlmaMalzemeleriTable.HatalıGiriş()) return false;
            return base.EntityInsert() && satınAlmaMalzemeleriTable.Kaydet();
        }
        protected override bool EntityUpdate()
        {

            if (satınAlmaMalzemeleriTable.HatalıGiriş()) return false;
            return base.EntityUpdate() && satınAlmaMalzemeleriTable.Kaydet();
        }
    }
}