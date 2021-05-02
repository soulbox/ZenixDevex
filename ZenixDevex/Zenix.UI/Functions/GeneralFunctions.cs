using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenix.Common.Enums;
using Zenix.Common.Messages;
using Zenix.Model.Entities.Base;
using Zenix.WinUI.myUserControls.Controls;
using Zenix.Model.Entities.Base.Interfaces;
using System.ComponentModel;
using System.Collections;
using System.Security;
using System.Runtime.InteropServices;
using DevExpress.Utils.Extensions;
using System.Security.Cryptography;
using Zenix.Model.Entities;
using Zenix.BLL.General;
using Zenix.Common.Function;
using Zenix.WinUI.myUserControls.Grid;
using DevExpress.XtraGrid.Columns;
using System.Linq.Expressions;
using Zenix.WinUI.MainForm;
using DevExpress.XtraEditors;

namespace Zenix.WinUI.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle > -1) return (long)tablo.GetFocusedRowCellValue("Id");
            Msg.KayıtSecmemeUyariMesajı();

            return -1;
        }

        public static void ToData<T>(this ComboBoxEdit combo ) where T:Enum
        {
            combo.Properties.Items.AddRange(EnumFunction.GetEnumDescriptionList<T>());
        }
        public static T GetRow<T>(this GridView tablo, bool mesajver = false)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);
            if (mesajver)
                Msg.KayıtSecmemeUyariMesajı();
            return default(T);
        }
        public static T GetRow<T>(this GridView tablo, int rowhandle)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(rowhandle);
            //Msg.KayıtSecmemeUyariMesajı();
            return default(T);
        }
        private static VeriDegisimYeri VeriDegisimYeriGetir<TEntity>(TEntity oldEntity, TEntity currentEntity)
        {
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
                var oldvalue = prop.GetValue(oldEntity) ?? string.Empty;
                var curvalue = prop.GetValue(currentEntity) ?? string.Empty;
                //byte tipindeyse [Resim Olabili]
                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldvalue.ToString()))
                        oldvalue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(curvalue.ToString()))
                        curvalue = new byte[] { 0 };
                    if (((byte[])oldvalue).Length != ((byte[])oldvalue).Length)
                        return VeriDegisimYeri.Alan;

                }
                else if (!curvalue.Equals(oldvalue)) // normal ise
                    return VeriDegisimYeri.Alan;
            }

            return VeriDegisimYeri.VeriDeğişimiyok;
        }
        public static string GetNumbers(this string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }
        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T OldEntity, T CurrentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(OldEntity, CurrentEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;
            btnKaydet.Enabled = buttonEnabledDurumu;
            btnYeni.Enabled = !buttonEnabledDurumu;
            btnGeriAl.Enabled = buttonEnabledDurumu;
            btnSil.Enabled = !buttonEnabledDurumu;
        }
        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGeriAl, BarButtonItem btnSil, T OldEntity, T CurrentEntity, bool tablevaluechanged)
        {
            var veriDegisimYeri = tablevaluechanged ? VeriDegisimYeri.Tablo : VeriDegisimYeriGetir(OldEntity, CurrentEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan || veriDegisimYeri == VeriDegisimYeri.Tablo;
            btnKaydet.Enabled = buttonEnabledDurumu;
            btnYeni.Enabled = !buttonEnabledDurumu;
            btnGeriAl.Enabled = buttonEnabledDurumu;
            btnSil.Enabled = !buttonEnabledDurumu;
        }
        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet, BarButtonItem btnFarkliKaydet, BarButtonItem btnsil, IslemTuru islemturu, T OldEntity, T CurrentEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(OldEntity, CurrentEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;
            btnKaydet.Enabled = buttonEnabledDurumu;
            btnFarkliKaydet.Enabled = islemturu != IslemTuru.EntityInsert;
            btnsil.Enabled = !buttonEnabledDurumu;
        }

        public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEntity)
        {
            //19 karakter
            //server 0
            var mkno = "00";
            var id = long.Parse($"{DateTime.Now:yyyyMMddHHmmssfff}{mkno}");
            return islemTuru == IslemTuru.EntityInsert ? id : selectedEntity == null ? 0 : selectedEntity.Id;
        }
        public static void KontrolEnabledChange(this myButtonEdit baseedit, Control prmedit)
        {
            switch (prmedit)
            {
                case myButtonEdit edt:
                    edt.Enabled = baseedit.Id.HasValue && baseedit.Id > 0;
                    edt.Id = null;
                    edt.EditValue = null;

                    break;
            }
        }
        public static void RowFocus(this GridView tablo, string aranacakkolon, object aranacakdeger)
        {
            int rowhandle = 0;
            for (int i = 0; i < tablo.RowCount; i++)
            {
                var bulunandeger = tablo.GetRowCellValue(i, aranacakkolon);
                if (aranacakdeger.Equals(bulunandeger))
                {
                    rowhandle = i;
                    tablo.FocusedRowHandle = rowhandle;
                    break;
                }

            }

        }
        public static void RowFocus(this GridView tablo, int rowhandle)
        {
            if (rowhandle <= 0) return;

            if (rowhandle == tablo.RowCount - 1)

                tablo.FocusedRowHandle = rowhandle;
            else
                tablo.FocusedRowHandle = rowhandle - 1;


        }
        public static void SagMenuGoster(this MouseEventArgs e, PopupMenu sagmenu)
        {
            if (e.Button != MouseButtons.Right) return;
            sagmenu.ShowPopup(Control.MousePosition);


        }

        public static void RefreshDataSource(this GridView tablo)
        {
            var source = tablo.DataController.ListSource.Cast<IBaseHaraketEntity>().ToList();
            if (!source.Any(x => x.Delete)) return;
            var rowhandle = tablo.FocusedRowHandle;
            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;
            tablo.RowFocus(rowhandle);

            void Tablo_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
            {
                var ent = source[e.ListSourceRow];
                if (ent == null) return;
                if (!ent.Delete) return;
                e.Visible = false;
                e.Handled = true;

            }


        }


        public static List<string> YazicilariListele() =>
            PrinterSettings.InstalledPrinters.Cast<string>().ToList();

        public static string DefaultYazici()
        {
            var set = new PrinterSettings();
            return set.PrinterName;
        }
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static BindingList<T> ToBindingList<T>(this IEnumerable<BaseEntityHaraket> list)
        {
            return new BindingList<T>((IList<T>)list);

        }

        public static (SecureString secureŞifre, string şifre) ŞifreÜret()
        {
            const string chartable = "0123456789ABCEFGHIJKLMNOPQRSTUVXWYZabcdefghijklmnopqrstuxwyz";

            string RandomDegerÜret(int minValue, int Count, int maxValue = 0)
            {
                var random = new Random();
                string sonuc = null;
                int maxval = maxValue > 0 & maxValue < chartable.Length - 1 ? maxValue : chartable.Length - 1;
                for (int i = 0; i < Count; i++)
                    sonuc += chartable[random.Next(minValue, maxval)].ToString();
                return sonuc;
            }
            var secureŞifre = RandomDegerÜret(0, 6).ConvertToSecureString();
            var şifre = secureŞifre.ConvertToUnsecureString().Md5Şifrele();
            return (secureŞifre, şifre);
        }
        public static SecureString ConvertToSecureString(this string value)
        {
            var result = new SecureString();
            if (value.Length > 0)
                value.ToCharArray().ForEach(x => result.AppendChar(x));
            result.MakeReadOnly();
            return result;
        }
        public static string ConvertToUnsecureString(this SecureString value)
        {
            var result = Marshal.SecureStringToBSTR(value);
            return Marshal.PtrToStringAuto(result);
        }
        public static T ConvertTo<T>(this object source)
        {
            if (source == null || source == DBNull.Value) return default(T);
            return (T)Convert.ChangeType(source, typeof(T));
        }
        public static void CustomVisibility(this GridColumn column, bool visible, int showindex)
        {
            column.Visible = visible;
            column.VisibleIndex = visible ? showindex : -1;
            column.OptionsColumn.ShowInCustomizationForm = visible;
        }
        public static Kullanici GetKullanici(this Kullanici kullanıcı, Expression<Func<Kullanici, bool>> filter = null)
        {
            if (kullanıcı == null)
            {
                var bll = new KullanıcıBll();
                kullanıcı = (Kullanici)bll.Single(filter);
                kullanıcı = kullanıcı.GetKullanici(filter);
            }
            else
            {
                var rol = new RolBll();
                var rolyetki = new RolYetkileriBll();
                kullanıcı.Rol = (Rol)rol.Single(x => x.Id == kullanıcı.RolId);
                kullanıcı.Rol.RolYetkileri = rolyetki.List(x => x.RolId == kullanıcı.Rol.Id).Cast<RolYetkileri>().ToList();
            }

            return kullanıcı;
        }
        public static Kullanici Change(this Kullanici kullanıcı, Expression<Func<Kullanici, bool>> filter)
        {
            if (kullanıcı == null) return kullanıcı;
            var bll = new KullanıcıBll();
            kullanıcı = (Kullanici)bll.Single(filter);
            kullanıcı = kullanıcı.GetKullanici();
            return kullanıcı;
        }

        //var KullanıcıGörebilir = Kullanıcı.Rol.RolYetkileri.FirstOrDefault(a => a.KartTuru == KartTuru.Kullanıcı).Görebilir == 1;
        static RolYetkileri GetRolYetki(this Kullanici kullanici, Func<RolYetkileri, bool> predicate)
        {
            return kullanici?.Rol?.RolYetkileri?.FirstOrDefault(predicate);
        }
        public static bool isGörebilir(this Kullanici kullanici, Func<RolYetkileri, bool> predicate) =>
            kullanici.GetRolYetki(predicate).Görebilir == 1;
        public static bool isEkleyebilir(this Kullanici kullanici, Func<RolYetkileri, bool> predicate) =>
            kullanici.GetRolYetki(predicate).Ekleyebilir == 1;
        public static bool isDeğiştirebilir(this Kullanici kullanici, Func<RolYetkileri, bool> predicate) =>
            kullanici.GetRolYetki(predicate).Değiştirebilir == 1;
        public static bool isSilebilir(this Kullanici kullanici, Func<RolYetkileri, bool> predicate) =>
            kullanici.GetRolYetki(predicate).Silebilir == 1;

        public static bool YetkiKontrolu(this KartTuru kartTuru, YetkiTuru yetkiTuru, bool mesajgöster = true)
        {
            if (AnaForm.Kullanıcı?.Id == 0) return true;
            //anlık yetki kontrolü
            var anlıkyetkikontrolü = true;
            if (anlıkyetkikontrolü)
            {
                var rolyetki = new RolYetkileriBll();
                AnaForm.Kullanıcı.Rol.RolYetkileri = rolyetki.List(x => x.RolId == AnaForm.Kullanıcı.Rol.Id).Cast<RolYetkileri>().ToList();


            }

            var result = false;
            switch (yetkiTuru)
            {
                case YetkiTuru.Gorebilir:
                    result = AnaForm.Kullanıcı.isGörebilir(x => x.KartTuru == kartTuru);
                    break;
                case YetkiTuru.Ekleyebilir:
                    result = AnaForm.Kullanıcı.isEkleyebilir(x => x.KartTuru == kartTuru);
                    break;

                case YetkiTuru.Değiştirebilir:
                    result = AnaForm.Kullanıcı.isDeğiştirebilir(x => x.KartTuru == kartTuru);
                    break;
                case YetkiTuru.Silebilir:
                    result = AnaForm.Kullanıcı.isSilebilir(x => x.KartTuru == kartTuru);
                    break;


            }
            if (!result & mesajgöster)
                Msg.UyariMesajı("Bu işlem İçin Yetkiniz Bulunmamaktadır");
            return result;
        }
        public static bool EditFormYetkiKontrolu(long id, KartTuru kartTuru)
        {
            var işlemtürü = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
            switch (işlemtürü)
            {
                case IslemTuru.EntityInsert when !kartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir):
                    return false;
                case IslemTuru.EntityUpdate when !kartTuru.YetkiKontrolu(YetkiTuru.Değiştirebilir):
                    return false;
            }
            return true;
        }
    }

}
