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


namespace Zenix.WinUI.Forms.ÜretimFormu
{
    public partial class ÜretimListForm : BaseListForm
    {
        public ÜretimListForm()
        {
            InitializeComponent();
            Bll = new ÜretimBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Üretim;
            this.FormShow = new ShowEditForms<ÜretimEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Üretim Kartları ";
            Tablo.ViewCaption = Text;
            //ShowHideButtons(IsMdiChild, btnBağlıKayıtları);
            //btnBağlıKayıtları.Caption = "Ürünleri";


        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((ÜretimBll)Bll).List(null);

        }
    }
}