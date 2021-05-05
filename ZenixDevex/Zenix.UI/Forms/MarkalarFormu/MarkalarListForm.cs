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
using Zenix.Model.DTO;
using Zenix.WinUI.Forms.RevizyonFormu;

namespace Zenix.WinUI.Forms.MarkalarFormu
{
    public partial class MarkalarListForm :BaseListForm
    {
        public MarkalarListForm()
        {
            InitializeComponent();
            Bll = new MarkalarBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Markalar;
            this.FormShow = new ShowEditForms<MarkalarEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Marka Kartları ";
            Tablo.ViewCaption = Text;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((MarkalarBll)Bll).List(FilterFunctions.Filter<Markalar>(AktifKayitlariGoster));

        }

    }
}