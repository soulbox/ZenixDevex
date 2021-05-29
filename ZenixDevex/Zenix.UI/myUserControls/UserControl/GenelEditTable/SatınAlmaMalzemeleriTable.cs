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
using Zenix.WinUI.Forms.MamülFormu;
using Zenix.Common.Messages;

namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    public partial class SatınAlmaMalzemeleriTable : BaseTablo
    {
        public SatınAlmaMalzemeleriTable()
        {
            InitializeComponent();
            Bll = new SatınAlmaMalzemelerBll();
            baseTablo = tablo;
            //ShowItems = new BarItem[] { btnTümSeçimleriKaldır, btnTümünüSeç };
            EventsLoad();
            repoimgaecomboBirim.AddEnum<ParaBirimi>();
        }
        protected internal override void Listele()
        {
            var lists = ((SatınAlmaMalzemelerBll)Bll).List(x => x.SatınalmaId == ownerform.Id).ToBindingList<SatınAlmaMalzemeleriL>();
            tablo.GridControl.DataSource = lists;
        }
        protected override void HareketEkle()
        {

            var source = tablo.DataController.ListSource;
            ListeDışıtutulacakkayıtlar = source.Cast<SatınAlmaMalzemeleriL>().Where(x => !x.Delete).Select(x => x.MamülId).ToList();
            var entities = ShowListForms<MamülListForm>.ShowDialogListForm(ListeDışıtutulacakkayıtlar, true, false);
            var result = entities.EntityListConvert<MamülL>();
            //var entities = ShowListForms<ReçeteMalzemeleriListForm>.ShowDialogListForm(ListeDışıtutulacakkayıtlar, true).EntityListConvert<MamülL>();
            if (result == null) return;
            if (result.Count(x => x != null) == 0)
            {
                Msg.HataMesajı("Herhangi bir Kayıt Seçilmedi");
                return;
            }
            result.Where(x => x != null).ForEach(x =>
                {
                    using (var depobll = new DepoBll())
                        source.Add(new SatınAlmaMalzemeleriL
                        {
                            SatınalmaId = ownerform != null ? ownerform.Id : 0,
                            MamülId = x.Id,
                            MamülAdı = x.MamülAdı,
                            MalzemeBirimi = x.MalzemeBirimi,
                            Stok = depobll.StokVer(x.Id),                            
                            Insert = true
                        });
                });
            tablo.Focus();
            tablo.RefreshDataSource();

            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            ButtonEnableDurum(true);

        }
        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var enti = tablo.GetRow<SatınAlmaMalzemeleriL>();
            if (!enti.HasValue()) return;
            //colEkleyebilir.OptionsColumn.AllowEdit = enti.Ekleyebilir != 2;
            //colDeğiştirebilir.OptionsColumn.AllowEdit = enti.Değiştirebilir != 2;
            //colSilebilir.OptionsColumn.AllowEdit = enti.Silebilir != 2;

        }
    }
}
