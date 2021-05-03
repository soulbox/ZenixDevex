using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.WinUI.Show;
using Zenix.Model.DTO;
using Zenix.WinUI.Functions;
using Zenix.WinUI.Forms.RevizyonFormu;
using Zenix.WinUI.Forms.ŞarzFormu;
using Zenix.Model.Entities;
using Zenix.WinUI.Forms.PaketlemeFormu;

namespace Zenix.WinUI.Forms.ÜrünlerFormu
{
    public partial class ÜrünListForm : BaseListForm
    {

        public ÜrünListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new ÜrünBll();


        }
        protected override void Degiskenleridoldur()
        {

            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Ürün;
            this.Navigator = longNavigator.controlNavigator;
            this.FormShow = new ShowEditForms<ÜrünEditForm>();
            this.Text = $"Ürün Kartları";
            Tablo.ViewCaption = Text;

            //this.btnBağlıKayıtları.ImageOptions.Image = Properties.Resources.code_fork_16px;
            //this.btnBağlıKayıtları.ImageOptions.LargeImage = Properties.Resources.code_fork_32px;
            //btnBağlıKayıtları.Caption = "Revizyon Kartları";
            //ShowHideButtons(IsMdiChild, btnBağlıKayıtları, btnŞarz, btnPaketleme);




        }

        protected override void Listele()
        {

            Tablo.GridControl.DataSource = ((ÜrünBll)Bll).List(FilterFunctions.Filter<Ürün>(AktifKayitlariGoster));

        }


    }

}