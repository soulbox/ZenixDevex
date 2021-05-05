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
    public partial class AmbalajTipiListForm : BaseListForm
    {
        public AmbalajTipiListForm()
        {
            InitializeComponent();
            Bll = new AmbalajTipiBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.AmbalajTipi;
            this.FormShow = new ShowEditForms<AmbalajTipiEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Ambalaj Kartları ";
            Tablo.ViewCaption = Text;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((AmbalajTipiBll)Bll).List(FilterFunctions.Filter<AmbalajTipi>(AktifKayitlariGoster));

        }
    }
}