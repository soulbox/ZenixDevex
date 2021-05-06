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
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using Zenix.WinUI.MainForm;
using Zenix.WinUI.Show;

namespace Zenix.WinUI.Forms.ReçeteFormu
{
    public partial class ReçeteListForm : BaseListForm
    {
        public ReçeteListForm()
        {
            InitializeComponent();
            Bll = new ReçeteBll();
        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Reçete;
            this.FormShow = new ShowEditForms<ReçeteEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Reçete Kartları";
            Tablo.ViewCaption = Text;

        }
        protected override void Listele()
        {
            var liste = ((ReçeteBll)Bll).List(x => x.Durum == AktifKayitlariGoster);

            Tablo.GridControl.DataSource = liste;
        }
    }
}