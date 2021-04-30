using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenix.Common.Enums;
using Zenix.Model.Entities.Base.Interfaces;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.WinUI.Functions;
using Zenix.WinUI.Show.Interfaces;

namespace Zenix.WinUI.Show
{
    public class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm
    {

        public static bool ShowDialogEditForm(IslemTuru ıslemTuru, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = ıslemTuru;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak;
            }
        }
        public long ShowDialogEditForm(KartTuru KartTuru, long id)
        {
            if (!GeneralFunctions.EditFormYetkiKontrolu(id, KartTuru)) return 0;
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))//,prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }

        public static void ShowEditForm(KartTuru KartTuru, long id)
        {
            if (!GeneralFunctions.EditFormYetkiKontrolu(id, KartTuru)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.Yukle();
            frm.Show();
        }
        public long ShowDialogEditForm(KartTuru KartTuru, long id, params object[] prm)
        {
            if (!GeneralFunctions.EditFormYetkiKontrolu(id, KartTuru)) return 0;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }
        public long ShowDialogEditFormSms(KartTuru KartTuru, long id, params object[] prm)
        {
            if (!KartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return 0;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }
        public static  bool ShowDialogEditForm(KartTuru KartTuru,  params object[] prm)
        {

            if (!KartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return false;
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return true ;
            }
        }

        public static T ShowDialogEditForm<T>(params object[] prm) where T : IBaseEntity
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return (T)frm.ReturnEntity();
            }
        }

    }
}
