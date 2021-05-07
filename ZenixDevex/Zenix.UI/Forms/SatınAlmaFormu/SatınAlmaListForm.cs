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

namespace Zenix.WinUI.Forms.SatınAlmaFormu
{
    public partial class SatınAlmaListForm :BaseListForm
    {
        public SatınAlmaListForm()
        {
            InitializeComponent();
            Bll = new SatınAlmaBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Firma;
            this.FormShow = new ShowEditForms<SatınAlmaEditForm >();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Satın Alma Kartları ";
            Tablo.ViewCaption = Text;
            //ShowHideButtons(IsMdiChild, btnBağlıKayıtları);
            //btnBağlıKayıtları.Caption = "Ürünleri";


        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SatınAlmaBll)Bll).List(FilterFunctions.Filter<Satınalma>(AktifKayitlariGoster));

        }
    }
}