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
using DevExpress.XtraGrid.Views.Base;
using Zenix.Model.DTO;

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
            Text = "Satın Alma";
            Tablo.ViewCaption = Text;
            //ShowHideButtons(IsMdiChild, btnBağlıKayıtları);
            //btnBağlıKayıtları.Caption = "Ürünleri";


        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SatınAlmaBll)Bll).List(FilterFunctions.Filter<Satınalma>(AktifKayitlariGoster));

        }
        protected override void Tablo_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var entity = tablo.GetRow<SatınalmaL>();
            if (entity == null) return;
            using (var Satınalmabll = new SatınAlmaMalzemelerBll())
                TabloSatınalma.GridControl.DataSource = Satınalmabll.List(x => x.SatınalmaId == entity.Id);
        }
        protected override void SagMenuGoster(object sender, MouseEventArgs e)
        {
            var isRight = (e.Button == MouseButtons.Right);
            var entity = Tablo.GetRow<SatınalmaL>();
            ShowHideButtons(entity != null, btnYeniSatınAlma );
            base.SagMenuGoster(sender, e);
        }
        protected override void YeniSatınAlma()
        {
            var entity = Tablo.GetRow<SatınalmaL>();
            var clone = entity.Clone;
            var result = new ShowEditForms<SatınAlmaEditForm >().ShowDialogEditForm(Common.Enums.KartTuru.SatınAlma, clone.Id, clone);
            Listele();
            ShowEditFormDefault(result);
        }
    }
}