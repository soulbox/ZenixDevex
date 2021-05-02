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
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using Zenix.BLL.Functions;

namespace Zenix.WinUI.Forms.ÜlkeFormu
{
    public partial class ÜlkeListForm : BaseListForm
    {
        public ÜlkeListForm()
        {
            InitializeComponent();
            Bll = new ÜlkeBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Ülke;
            this.FormShow = new ShowEditForms<ÜlkeEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Ülke Kartları ";
            Tablo.ViewCaption = Text;
            //if (IsMdiChild)
            //    ShowItems = new BarItem[] { btnBagliKayitlar };

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = Bll.ToBll<ÜlkeBll>().List(null );
        }
    }
}