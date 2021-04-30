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
using Zenix.Model.DTO;
using Zenix.BLL.General;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using DevExpress.XtraBars;
using System.Security;
using Zenix.Common.Function;
using Zenix.Common.Messages;


namespace Zenix.WinUI.Forms.KullanıcıForms
{
    public partial class KullanıcıEditForm : BaseEditForm
    {
        string şifre;
        SecureString SecureŞifre;
        bool tekrargönder;
        public KullanıcıEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new KullanıcıBll(myDataLayoutControl);

            this.KartTuru = Common.Enums.KartTuru.Kullanıcı;
            ShowItems = new BarItem[] { btnŞifreSıfırla };
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new KullanıcıS() : ((KullanıcıBll)Bll).Single(FilterFunctions.Filter<Kullanici>(Id));
            NesneyiKontrollereBagla();
            TabloYükle();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKullanıcıAdı.Text = "Yeni Kullanıcı";
            btnŞifreSıfırla.Enabled = false;

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullanıcıS)OldEntity;
            txtKullanıcıAdı.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtAçıklama.Text = entity.Açıklama;
            txtRol.Text = entity.RolAdı;
            txtRol.Id = entity.RolId;
            şifre = entity.Şifre;
            txtAdı.Text = entity.Adı;
            txtSoyadı.Text = entity.Soyadı;
            txtEmail.Text = entity.Email;



        }
        protected override void GuncelNesneOluştur()
        {
            CurrentEntity = new KullanıcıS
            {
                Id = Id,
                Kod = txtKullanıcıAdı.Text,
                Durum = tglDurum.IsOn,
                Açıklama = txtAçıklama.Text,
                RolId = Convert.ToInt64(txtRol.Id),
                Adı = txtAdı.Text,
                Email = txtEmail.Text,
                Soyadı = txtSoyadı.Text,
                Şifre = şifre,
                RolAdı = txtRol.Text,

            };
            ButtonEnableDurumu();
        }
        void ŞifreÜret()
        {
            var result = GeneralFunctions.ŞifreÜret();
            şifre = result.şifre;
            SecureŞifre = result.secureŞifre;
            GuncelNesneOluştur();
        }
        protected override bool EntityInsert()
        {
            ŞifreÜret();
            var result = base.EntityInsert();
            if (result)
                txtKullanıcıAdı.Text.SendPaswordMail(txtRol.Text, txtEmail.Text, SecureŞifre);

            return result;
        }
        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();
            if (tekrargönder)
                txtKullanıcıAdı.Text.SendPaswordMail(txtRol.Text, txtEmail.Text, SecureŞifre);

            return result;
        }
        protected override void SeçimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtRol)
                    sec.Seç(txtRol);
            }
        }
        protected override void ŞifreSıfırla()
        {
            if (Msg.EmailGönderimOnayı != DialogResult.Yes) return;
            var kullanıcı = (KullanıcıS)CurrentEntity;

            //if (((KullanıcıBll)Bll).Single(x => x.Kod != "admin" && x.Kod == kullanıcı.Kod) != null)
            //{
            //    Msg.HataMesajı("Bu Kullanıcı Adı Zaten Var!");
            //    txtKullanıcıAdı.Focus();
            //    return;
            //};
            tekrargönder = true;
            ŞifreÜret();
            if (EntityUpdate())
            {
                Msg.BilgilendirmeMesajı("Sıfırlama Maili Gönderilmiştir");
                Close();

            }

        }
        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!tekrargönder)
                base.BaseEditForm_FormClosing(sender, e);

        }


    }
}