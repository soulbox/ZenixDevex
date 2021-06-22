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
using Zenix.Model.DTO;
using System.Drawing;
using Zenix.Common.Enums;
using Zenix.Common.Messages;
using Zenix.Model.Entities.Base;
using Zenix.BLL.Functions;

namespace Zenix.WinUI.Forms.DepoFormu
{
    public partial class YarıMamülDepoListForm : BaseListForm
    {
        public YarıMamülDepoListForm()
        {
            InitializeComponent();
            Bll = new DepoBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Depo;
            //this.FormShow = new ShowEditForms<FirmaEditFormu>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Yarı Mamül Depo";
            Tablo.ViewCaption = Text;


        }
        protected override void Listele()
        {
            var depolist = ((DepoBll)Bll).YarıMamülDepoList(x => x.YarıMamülId != null);
            Tablo.GridControl.DataSource = depolist;
        }
        protected override void ShowEditForm(long id)
        {
            //base.ShowEditForm(id);
        }
    }
}