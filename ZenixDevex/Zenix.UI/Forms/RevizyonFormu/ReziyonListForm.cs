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
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;

namespace Zenix.WinUI.Forms.RevizyonFormu
{
    public partial class ReziyonListForm : BaseListForm
    {

        readonly Ürün ürün;
        public ReziyonListForm(params object[] prm)
        {
            ürün = (Ürün)prm[0];
            InitializeComponent();
            Bll = new RevizyonBll();
        }
        protected override void Degiskenleridoldur()
        {

            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Revizyon;
            this.Navigator = longNavigator.controlNavigator;
            //this.FormShow = new ShowEditForms<ÜrünEditForm>();
            this.Text = $"[{ürün.Adı }] Ürününün Revizyonları";
            Tablo.ViewCaption = Text;

            //if (IsMdiChild)
            //    ShowItems = new BarItem[] { btnBagliKayitlar, btnİrsaliyeAyarı };


        }
        protected override void Listele()
        {

            var liste = ((RevizyonBll)Bll).List(x => x.Durum == AktifKayitlariGoster && x.ÜrünId == ürün.Id);
            Tablo.GridControl.DataSource = liste;

        }
        protected override void ShowEditForm(long id)
        {
            var result = new ShowEditForms<RevizyonEditForm >().ShowDialogEditForm(Common.Enums.KartTuru.Revizyon , id, ürün);
            ShowEditFormDefault(result);
        }
    }
}