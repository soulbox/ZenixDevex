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
using Zenix.WinUI.Forms.RevizyonFormu;

namespace Zenix.WinUI.Forms.ÜrünlerFormu
{
    public partial class ÜrünListForm : BaseListForm
    {
        public ÜrünListForm()
        {
            InitializeComponent();
            Bll = new ÜrünBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Ürün;
            this.FormShow = new ShowEditForms<ÜrünEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Ürün Tanıtım Kartları ";
            Tablo.ViewCaption = Text;
            ShowHideButtons(IsMdiChild, btnBağlıKayıtları);
            btnBağlıKayıtları.Caption = "Revizyon Kartı";
            btnBağlıKayıtları.ImageOptions.Image = Properties.Resources.code_fork_16px ;
            btnBağlıKayıtları.ImageOptions.LargeImage = Properties.Resources.code_fork_32px;


        }
        protected override void Listele()
        {
            var liste = ((ÜrünBll)Bll).List(FilterFunctions.Filter<Ürün>(AktifKayitlariGoster));
            Tablo.GridControl.DataSource = ((ÜrünBll)Bll).List(FilterFunctions.Filter<Ürün>(AktifKayitlariGoster));

        }
        protected override void BağlıKayıtlarAc()
        {
            var entity = tablo.GetRow<ÜrünL>();
            if (entity.isNull()) return;
            ShowListForms<RevizyonListForm>.ShowListForm(Common.Enums.KartTuru.Revizyon, entity);

        }

    }
}