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
using DevExpress.XtraBars;
using DevExpress.Utils.Extensions;
using Zenix.Model.Entities;
using Zenix.Common.Messages;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Model.DTO;

namespace Zenix.WinUI.Forms.KullanıcıForms
{
    public partial class ŞifremiUnuttumEditForm : BaseEditForm
    {
        readonly string kullanıcıadı;
        public ŞifremiUnuttumEditForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new KullanıcıBll(myDataLayoutControl);
            HideItems = new BarItem[] { btnYeni, btnSil, btnKaydet, btnGeriAl, };
            ShowItems = new BarItem[] { btnŞifreSıfırla };
            EventsLoad();
            kullanıcıadı = prm[0].ToString();

        }
        protected override void ŞifreSıfırla()
        {
            if (Msg.EmailGönderimOnayı != DialogResult.Yes) return; 
            var kullanıcı = (Kullanici)((KullanıcıBll)Bll).Single(x => x.Kod == txtKullanıcıAdı.Text);


            if (kullanıcı == null)
            {
                Msg.HataliVeriMesajı("Veri Tabanında Kayıtlı Böyle Bir Kullanıcı  Bulunamamaktadır");
                return;
            }
            if (txtAdı.Text == kullanıcı.Adı && txtEposta.Text == kullanıcı.Email && txtSoyadı.Text == kullanıcı.Soyadı)
            {
                var result = GeneralFunctions.ŞifreÜret();
                var currentEntity = new Kullanici
                {
                    Id = kullanıcı.Id,
                    Kod = kullanıcı.Kod,

                    Adı = kullanıcı.Adı,
                    Soyadı = kullanıcı.Soyadı,
                    Açıklama = kullanıcı.Açıklama,
                    Email = kullanıcı.Email,
                    RolId = kullanıcı.RolId,
                    Durum = kullanıcı.Durum,
                    Şifre = result.şifre,

                };
                if (!((KullanıcıBll)Bll).Update(kullanıcı, currentEntity)) return;
                var sonuc = txtKullanıcıAdı.Text.SendPaswordMail(((KullanıcıS)kullanıcı).RolAdı, kullanıcı.Email, result.secureŞifre);
                if (sonuc)
                {
                    Msg.BilgilendirmeMesajı("Şifre Sıfırlama işlemi Başarılı Bir Şekilde Gerçekleşti");
                    Close();
                }
                else
                    Msg.HataMesajı("Şifre sıfırlama İşlemi Başarılı Bir Şekildi Gerçekleşti. Ancak E-Posta Gönderilemedi.\nLütfen Tekrar Deneyiniz");
            }
            else
                Msg.HataMesajı("Girilen Bilgiler Mevcut Bilgilerle Uyuşmuyor.\nLütfen Kontrol Edip Tekrar Deneyiniz");
        }
    }
}