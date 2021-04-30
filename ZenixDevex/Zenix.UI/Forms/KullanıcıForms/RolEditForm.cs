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

namespace Zenix.WinUI.Forms.KullanıcıForms
{
    public partial class RolEditForm : BaseEditForm
    {
        public RolEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new RolBll (myDataLayoutControl);
            this.KartTuru = Common.Enums.KartTuru.Rol;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new Rol() : ((RolBll)Bll).Single(FilterFunctions.Filter<Rol >(Id));
            NesneyiKontrollereBagla();
            TabloYükle();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RolBll)Bll).YeniKodVer();
            txtRolAdi .Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Rol)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtAçıklama.Text = entity.Açıklama;
            txtRolAdi.Text = entity.RolAdi;
           
        }
        protected override void GuncelNesneOluştur()
        {
            CurrentEntity = new Rol
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                Açıklama = txtAçıklama.Text,
                RolAdi=txtRolAdi.Text,
            };
            ButtonEnableDurumu();
        }
        protected override void TabloYükle()
        {
            rolYetkileriTable.ownerform = this;
           
            rolYetkileriTable.Yukle();
        }

        protected internal override void ButtonEnableDurumu()
        {
            if (!isLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity,rolYetkileriTable.tablevaluechanged);
        }

        protected override bool EntityInsert()
        {

            if (rolYetkileriTable.HatalıGiriş()) return false;
            return base.EntityInsert() && rolYetkileriTable.Kaydet();
        }
        protected override bool EntityUpdate()
        {

            if (rolYetkileriTable.HatalıGiriş()) return false;
            return base.EntityUpdate() && rolYetkileriTable.Kaydet();
        }
        
    }
}