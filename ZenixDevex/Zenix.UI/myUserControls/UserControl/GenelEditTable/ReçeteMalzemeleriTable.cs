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

namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    public partial class ReçeteMalzemeleriTable : BaseTablo
    {
        public ReçeteMalzemeleriTable()
        {
            InitializeComponent();
            //repoCombo.ToData<FazTipi>();
            repoimagecombo.Items.AddEnum<FazTipi>();
            Bll = new ReçeteMalzemelerBll();
            baseTablo = tablo;
            //ShowItems = new BarItem[] { btnTümSeçimleriKaldır, btnTümünüSeç };
            EventsLoad();
        }
        protected internal override void Listele()
        {
            var lists = ((ReçeteMalzemelerBll)Bll).List(x => x.ReçeteId == ownerform.Id).ToBindingList<ReçeteMalzemeleriL>();
            tablo.GridControl.DataSource = lists;
        }
        protected override void HareketEkle()
        {

            //var source = tablo.DataController.ListSource;
            //ListeDışıtutulacakkayıtlar = source.Cast<ReçeteMalzemeleriL>().Where(x => !x.Delete).Select(x => (long)x.MalzemeId).ToList();
            //var entities = ShowListForms<ReçeteMalzemeleriListForm>.ShowDialogListForm(ListeDışıtutulacakkayıtlar, true).EntityListConvert<ReçeteMalzemeleriS>();
            //if (entities == null) return;
            //entities.ForEach(x =>
            //{
            //    source.Add(new ReçeteMalzemeleriL
            //    {
            //        ReçeteId = ownerform != null ? ownerform.Id : 0,
            //        MalzemeAdı = x.Adı,
            //        MalzemeId = x.Id,
            //        Insert = true
            //    });
            //});
            //tablo.Focus();
            //tablo.RefreshDataSource();

            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            ButtonEnableDurum(true);

        }
        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var enti = tablo.GetRow<ReçeteMalzemeleriL>();
            if (!enti.HasValue()) return;
            //colEkleyebilir.OptionsColumn.AllowEdit = enti.Ekleyebilir != 2;
            //colDeğiştirebilir.OptionsColumn.AllowEdit = enti.Değiştirebilir != 2;
            //colSilebilir.OptionsColumn.AllowEdit = enti.Silebilir != 2;

        }
    }
}
