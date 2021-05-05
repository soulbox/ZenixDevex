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

namespace Zenix.WinUI.Forms.FirmaFormu
{
    public partial class FirmaListFormu : BaseListForm
    {


        public FirmaListFormu()
        {
            InitializeComponent();
            Bll = new FirmaBll();
        }

        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Firma;
            this.FormShow = new ShowEditForms<FirmaEditFormu>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Firma Kartları ";
            Tablo.ViewCaption = Text;
            //ShowHideButtons(IsMdiChild, btnBağlıKayıtları);
            //btnBağlıKayıtları.Caption = "Ürünleri";


        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((FirmaBll)Bll).List(FilterFunctions.Filter<Firma>(AktifKayitlariGoster));

        }

        //protected override void BağlıKayıtlarAc()
        //{
        //    var entity = Tablo.GetRow<Firma>();
        //    if (entity == null) return;
        //    ShowListForms<ÜrünListForm>.ShowListForm(Common.Enums.KartTuru.Ürün, entity.Id, entity.FirmaAdi);
        //}


    }
}