using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.WinUI.Show;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using DevExpress.XtraBars;
using Zenix.WinUI.myUserControls.Grid;
using System.Linq;
using Zenix.Common.Function;
using DevExpress.XtraGrid.Views.Grid;
using Zenix.WinUI.MainForm;
using Zenix.WinUI.Forms.ÜrünlerFormu;

namespace Zenix.WinUI.Forms.AmbalajTipiFormu
{
    public partial class AmbalajMaddeTipiListForm : BaseListForm
    {
        public AmbalajMaddeTipiListForm()
        {
            InitializeComponent();
            Bll = new AmbalajMaddeTipiBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.AmbalajMaddeTipi;
            this.FormShow = new ShowEditForms<AmbalajMaddeTipiEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Ambalaj Madde Kartları ";
            Tablo.ViewCaption = Text;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AmbalajMaddeTipiBll)Bll).List(FilterFunctions.Filter<AmbalajMaddeTipi>(AktifKayitlariGoster));

        }
    }
}