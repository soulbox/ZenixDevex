using Zenix.Common.Enums;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Zenix.Common.Messages
{
    public class Msg
    {
        public static void BilgilendirmeMesajı(string bilgilendirme) 
        {
            XtraMessageBox.Show(bilgilendirme, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
        public static void HataMesajı(string hata)
        {
            XtraMessageBox.Show(hata, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void YetkisiYok(string kartturu)
        {
            HataMesajı($"Yetkisiz {kartturu} erişimi");
        }
        public static void UyariMesajı(string uyari)
        {
            XtraMessageBox.Show(uyari, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void OkMesajı(string uyari)
        {
            XtraMessageBox.Show(uyari, "işlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult EvetSeciliEvetHayir(string mesaj, string başlık)
        {
            return XtraMessageBox.Show(mesaj, başlık, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        public static DialogResult HayirSeciliEvetHayir(string mesaj, string başlık)
        {
            return XtraMessageBox.Show(mesaj, başlık, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
        public static DialogResult SilMesajı(string EntityAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {EntityAdi} Silinecektir. Onaylıyormusunuz?", "Silme Onayı");
        }
        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string başlık) =>
            XtraMessageBox.Show(mesaj, başlık, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        public static DialogResult KapanisMesajVer()
            => EvetSeciliEvetHayirIptal("Yapılan Değişiklikler Kayıt Edilsin mi?", "Çıkış Onayı");
        public static DialogResult KayıtMesaj()
            => EvetSeciliEvetHayir("Yapılan Değişiklikler Kayıt Edilsin mi?", "Kayıt Onayı");
        public static void KayıtSecmemeUyariMesajı()
            => UyariMesajı("Lürfen Bir Kayıt Seçiniz");
        public static void MukerrerKayitHataMesajı(string AlanAdi)
            => HataMesajı($"Girmiş Olduğunuz {AlanAdi} daha önce Kullanılmıştır");
        public static void HataliVeriMesajı(string AlanAdi)
            => HataMesajı($"{AlanAdi } Alanına Geçerli Bir Değer Giriniz.");
        public static DialogResult TabloExpoerMesaj(string dosyaFormatı)
    => EvetSeciliEvetHayir($"İlgili Tablo,{dosyaFormatı} Olarak Dışarı Aktarılacaktır, Onaylıyor musunuz?", "Aktarım Onayı");
        public static DialogResult EmailGönderimOnayı => EvetSeciliEvetHayir("Kullanıcı Şifresi Sıfırlanarak,Kullanıcı Bilgilerini İçeren Yeni Bir Email Gönderilicektir. Onaylıyor musunuz?", "Onay");

    }
}
