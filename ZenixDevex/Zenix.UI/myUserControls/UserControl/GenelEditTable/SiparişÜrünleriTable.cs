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

namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    public partial class SiparişÜrünleriTable : BaseTablo
    {
        public SiparişÜrünleriTable()
        {
            InitializeComponent();
            repoimagecomboBirim.Items.AddEnum<BirimTipi>();
            Bll = new SiparişÜrünleriBll();
            baseTablo = tablo;
            //ShowItems = new BarItem[] { btnTümSeçimleriKaldır, btnTümünüSeç };
            EventsLoad();
        }
        protected internal override void Listele()
        {
            var lists = ((SiparişÜrünleriBll)Bll).List(x => x.SiparişId == ownerform.Id).ToBindingList<SiparişÜrünleriL>();
            tablo.GridControl.DataSource = lists;
        }
        protected override void HareketEkle()
        {

            var source = tablo.DataController.ListSource;
            ListeDışıtutulacakkayıtlar = source.Cast<SiparişÜrünleriL>().Where(x => !x.Delete).Select(x => x.ÜrünId).ToList();
            var entities = ShowListForms<ÜrünListForm>.ShowDialogListForm(ListeDışıtutulacakkayıtlar, true).EntityListConvert<ÜrünL>();
            //var entities = ShowListForms<ReçeteMalzemeleriListForm>.ShowDialogListForm(ListeDışıtutulacakkayıtlar, true).EntityListConvert<MamülL>();

            if (entities == null) return;
            entities.ForEach(x =>
            {
                source.Add(new SiparişÜrünleriL
                {
                    SiparişId = ownerform != null ? ownerform.Id : 0,
                    ÜrünId = x.Id,
                    MamülAdı = x.MamülAdı,
                    FirmaAdi = x.FirmaAdi,
                    MarkaAdı = x.MarkaAdı,
                    GTIN = x.GTIN,
                    Kutu = x.Kutu,
                    Koli = x.Koli,
                    Stand = x.Stand,
                    Insert = true
                });
            });
            tablo.Focus();
            tablo.RefreshDataSource();

            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            ButtonEnableDurum(true);

        }
        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //colMiktar=koliadedi*koliiçi
            var enti = tablo.GetRow<SiparişÜrünleriL>();
            if (enti != null && e.Column == colMiktar)
            {
                enti.KoliAdedi = enti.Koli != 0 ? enti.Miktar / enti.Koli : enti.KoliAdedi;
                tablo.GridControl.RefreshDataSource();
            }
            else if (enti != null && e.Column == colkoliadedi)
            {
                enti.Miktar = enti.Koli * enti.KoliAdedi;
                tablo.GridControl.RefreshDataSource();
            }

            base.Tablo_CellValueChanged(sender, e);
        }
        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var enti = tablo.GetRow<SiparişÜrünleriL>();
            if (!enti.HasValue()) return;


            //colEkleyebilir.OptionsColumn.AllowEdit = enti.Ekleyebilir != 2;
            //colDeğiştirebilir.OptionsColumn.AllowEdit = enti.Değiştirebilir != 2;
            //colSilebilir.OptionsColumn.AllowEdit = enti.Silebilir != 2;

        }
    }
}
