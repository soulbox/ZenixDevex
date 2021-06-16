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
using Zenix.WinUI.Forms.ReçeteFormu;
using Zenix.WinUI.Forms.ÜrünlerFormu;
using DevExpress.XtraGrid.Views.Base;
using Zenix.WinUI.Forms.YarıMamülGrupFormu;

namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    public partial class YarıMamülGrupTable : BaseTablo
    {
        public YarıMamülGrupTable()
        {
            InitializeComponent();
            Bll = new YarıMamülBll();
            baseTablo = tablo;
            EventsLoad();

        }
        protected internal override void Listele()
        {
            var lists = ((YarıMamülBll)Bll).List(x => x.ÜrünId == ownerform.Id).ToBindingList<YarıMamülL>();
            tablo.GridControl.DataSource = lists;
        }
        protected override void HareketEkle()
        {

            var source = tablo.DataController.ListSource;
            ListeDışıtutulacakkayıtlar = source.Cast<YarıMamülL>().Where(x => !x.Delete).Select(x => x.YarıMamülGrupId).ToList();
            var entities = ShowListForms<YarıMamülGrupListForm>.ShowDialogListForm(ListeDışıtutulacakkayıtlar, true).EntityListConvert<YarıMamülGrup>();
            //var entities = ShowListForms<ReçeteMalzemeleriListForm>.ShowDialogListForm(ListeDışıtutulacakkayıtlar, true).EntityListConvert<MamülL>();

            if (entities == null) return;
            entities.ForEach(x =>
            {
                source.Add(new YarıMamülL
                {
                    ÜrünId = ownerform != null ? ownerform.Id : 0,
                    YarıMamülGrupId = x.Id,
                    YarıMamülAdı=x.YarıMamülAdı,                    
                    Insert = true
                });
            });
            tablo.Focus();
            tablo.RefreshDataSource();

            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            ButtonEnableDurum(true);

        }
    }
}
