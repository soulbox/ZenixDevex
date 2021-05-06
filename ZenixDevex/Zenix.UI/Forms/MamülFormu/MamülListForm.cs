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

namespace Zenix.WinUI.Forms.MamülFormu
{
    public partial class MamülListForm : BaseListForm

    {
        public MamülListForm()
        {
            InitializeComponent();
            Bll = new MamülBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.FirmaTipi;
            this.FormShow = new ShowEditForms<MamülEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Mamül Kartları ";
            Tablo.ViewCaption = Text;

        }
        protected override void Listele()
        {
            //var liste = ((MamülBll)Bll).List(FilterFunctions.Filter<Mamül>(AktifKayitlariGoster));
            Tablo.GridControl.DataSource = ((MamülBll)Bll).List(FilterFunctions.Filter<Mamül >(AktifKayitlariGoster));

        }
    }
}