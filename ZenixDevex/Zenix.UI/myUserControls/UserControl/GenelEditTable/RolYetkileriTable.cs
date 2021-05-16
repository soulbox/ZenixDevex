using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.myUserControls.UserControl.Base;
using Zenix.BLL.General;
using Zenix.Model.DTO;
using Zenix.WinUI.Show;
using Zenix.WinUI.Forms.KullanıcıForms;
using Zenix.BLL.Functions;
using DevExpress.Utils.Extensions;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Enums;
using DevExpress.XtraBars;

namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    public partial class RolYetkileriTable : BaseTablo
    {
        public RolYetkileriTable()
        {
            InitializeComponent();

            Bll = new RolYetkileriBll();
            baseTablo = tablo;
            ShowItems = new BarItem[] { btnTümSeçimleriKaldır, btnTümünüSeç };
            EventsLoad();


        }
        protected internal override void Listele()
        {
            var lists = ((RolYetkileriBll)Bll).List(x => x.RolId == ownerform.Id).ToBindingList<RolYetkileriL>();
            tablo.GridControl.DataSource = lists;
        }
        protected override void HareketEkle()
        {
            byte CheckBoxValue(KartTuru kartTuru)
            {
                //if (kartTuru == KartTuru.TümKrediKartları)
                //    return 2;
                //else
                    return 0;

            }
            var source = tablo.DataController.ListSource;
            ListeDışıtutulacakkayıtlar = source.Cast<RolYetkileriL>().Where(x => !x.Delete).Select(x => (long)x.KartTuru).ToList();
            var entities = ShowListForms<RolYetkiKartlariListForm>.ShowDialogListForm(ListeDışıtutulacakkayıtlar, true).EntityListConvert<RolYetki>();
            if (entities == null) return;
            entities.ForEach(x =>
            {
                source.Add(new RolYetkileriL
                {
                    RolId = ownerform != null ? ownerform.Id : 0,
                    KartTuru = x.KartTuru,
                    Ekleyebilir = CheckBoxValue(x.KartTuru),
                    Görebilir = 0,
                    Silebilir = CheckBoxValue(x.KartTuru),
                    Değiştirebilir = CheckBoxValue(x.KartTuru),
                    Insert = true
                });
            });
            tablo.Focus();
            tablo.RefreshDataSource();

            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            ButtonEnableDurum(true);

        }
        protected override void ButtonEnableDurum(bool durum)
        {
            base.ButtonEnableDurum(durum);
        }
        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var buton = insUpdNavigator.Navigator.Buttons;
            buton.DoClick(buton.EndEdit);
            base.CheckEdit_CheckedChanged(sender, e);
        }
        protected internal override bool HatalıGiriş()
        {

            return base.HatalıGiriş();
        }
        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var enti = tablo.GetRow<RolYetkileriL>();
            if (!enti.HasValue()) return;
            colEkleyebilir.OptionsColumn.AllowEdit = enti.Ekleyebilir != 2;
            colDeğiştirebilir.OptionsColumn.AllowEdit = enti.Değiştirebilir != 2;
            colSilebilir.OptionsColumn.AllowEdit = enti.Silebilir != 2;




        }
        protected override void TümünüSeç()
        {
            var source = tablo.DataController.ListSource.Cast<RolYetkileriL>().ToList();

            source.ForEach(x =>
            {
                int index = source.IndexOf(x);
                x.Görebilir = 1;
                x.Değiştirebilir = (byte)(x.Değiştirebilir == 2 ? 2 : 1);
                x.Silebilir = (byte)(x.Silebilir == 2 ? 2 : 1);
                x.Ekleyebilir = (byte)(x.Ekleyebilir == 2 ? 2 : 1);
                x.Değiştirebilir = (byte)(x.Değiştirebilir == 2 ? 2 : 1);
           
                if (!x.Insert)
                    x.Update = true;
                tablo.RefreshRow(index);

            });

            ButtonEnableDurum(true);
        }
        protected override void TümSeçimleriKaldır()
        {
            var source = tablo.DataController.ListSource.Cast<RolYetkileriL>().ToList();

            source.ForEach(x =>
            {
                int index = source.IndexOf(x);
                x.Görebilir = 0;
                x.Değiştirebilir = (byte)(x.Değiştirebilir == 2 ? 2 : 0);
                x.Silebilir = (byte)(x.Silebilir == 2 ? 2 : 0);
                x.Ekleyebilir = (byte)(x.Ekleyebilir == 2 ? 2 : 0);
                x.Değiştirebilir = (byte)(x.Değiştirebilir == 2 ? 2 : 0);
  
                if (!x.Insert)
                    x.Update = true;
                tablo.RefreshRow(index);

            });
            ButtonEnableDurum(true);
        }

    }
}
