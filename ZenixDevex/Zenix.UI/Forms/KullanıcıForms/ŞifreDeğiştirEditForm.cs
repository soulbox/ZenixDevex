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
using Zenix.WinUI.MainForm;

namespace Zenix.WinUI.Forms.KullanıcıForms
{
    public partial class ŞifreDeğiştirEditForm : BaseEditForm
    {
        public ŞifreDeğiştirEditForm()
        {
            InitializeComponent();
            Bll = new KullanıcıBll(myDataLayoutControl);
            HideItems = new BarItem[] { btnYeni, btnSil, btnGeriAl, };
            EventsLoad();
        }

        protected override bool Kaydet(bool kapanis)
        {
            //return base.Kaydet(kapanis);
            ŞifreDeğiştir();
            return true;
        }
        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }
        private void ŞifreDeğiştir()
        {
            if (Msg.KayıtMesaj() != DialogResult.Yes) return;
            var entity = (Kullanici)((KullanıcıBll)Bll).Single(x => x.Id == AnaForm.Kullanıcı.Id);
            if (!entity.HasValue()) return;
            if (HatalıGiriş()) return;
            if (entity.Şifre == txtEskiŞifre.Text.Md5Şifrele())
            {
                var currentEntity = new Kullanici
                {
                    Id = entity.Id,
                    Kod = entity.Kod,
                    Adı = entity.Adı,
                    Açıklama = entity.Açıklama,
                    Durum = entity.Durum,
                    Email = entity.Email,
                    RolId = entity.RolId,
                    Soyadı = entity.Soyadı,
                    Şifre = txtYeniŞifre.Text.Md5Şifrele()
                };
                if (!((KullanıcıBll)Bll).Update(entity, currentEntity)) return;
                Msg.BilgilendirmeMesajı("Şifreniz Başarılı Bir Şekilde Değiştirilmiştir");
              
                Close();
            }
            else
            {
                Msg.HataMesajı("Girilen Eski Şifre Bilgisi Hatalıdır.Lütfen Kontrol Edip Tekrar Deneyiniz.");
                txtEskiŞifre.Focus();
            }

        }

        bool HatalıGiriş()
        {
            if (txtYeniŞifre.Text != txtYeniŞifreTekrar.Text)
            {
                Msg.HataMesajı("Girilen Yeni şifre ,Yeni Şifre Tekrarıyla Uyuşmuyor");
                txtYeniŞifre.Focus();
                return true;
            }
            if (txtYeniŞifre.Text.Length < 8)
            {
                Msg.HataMesajı("Girilen Yeni Şifrenin Uzunluğu En Az 8 Karakter Olmalıdr.");
                txtYeniŞifre.Focus();
                return true;
            }
            return false;
        }


    }
}