using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenix.Common.Enums;
using Zenix.Common.Function;
using Zenix.Common.Messages;
using Zenix.Model.Entities.Base;
using Zenix.Model.Entities.Base.Interfaces;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.WinUI.Functions;
using Zenix.WinUI.MainForm;

namespace Zenix.WinUI.Show
{
    public class ShowListForms<TForm> where TForm : BaseListForm
    {
        public static void ShowListForm(KartTuru kartTuru)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;
            var KullanıcıGörebilir = kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir);
            if (!KullanıcıGörebilir)
            {
                Msg.YetkisiYok(kartTuru.ToName());
                return;
            }
            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.Show();
        }
        public static void ShowListForm(KartTuru kartTuru, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;
            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.Show();
        }
        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? SeciliGelecekId, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                //frm.MdiParent = Form.ActiveForm;
                frm.SeciliGelecekId = SeciliGelecekId;
                frm.Yukle();
                frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }



        }
        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, IList<long> listedışıtutulacakkayıtlar, bool multiselect, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
              
                frm.ListeDışıBırakılıcakKayıtlar = listedışıtutulacakkayıtlar;
                frm.isMultiSelect = multiselect;
                frm.Yukle();
                frm.rowselect = new Functions.SelectRowFunctions(frm.tablo);
                if (frm.EkelenebilecekEntityVar)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;


            }
        }
        public static IEnumerable<IBaseEntity> ShowDialogListForm( IList<long> listedışıtutulacakkayıtlar, bool multiselect, params object[] prm)
        {        

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDışıBırakılıcakKayıtlar = listedışıtutulacakkayıtlar;
                frm.isMultiSelect = multiselect;
                frm.Yukle();

                frm.rowselect = new Functions.SelectRowFunctions(frm.tablo);
                if (frm.EkelenebilecekEntityVar)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;


            }
        }
    }
}
