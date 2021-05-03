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

        readonly MarkalarS marka;
        public ReziyonListForm(params object[] prm)
        {
            marka = (MarkalarS)prm[0];
            InitializeComponent();
            Bll = new RevizyonBll();
        }
        protected override void Degiskenleridoldur()
        {

            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Revizyon;
            this.Navigator = longNavigator.controlNavigator;
            //this.FormShow = new ShowEditForms<RevizyonEditForm>();
            this.Text = $"[{marka.Adı}-{marka.ÜrünAdı}] Revizyonları";
            Tablo.ViewCaption = Text;

            //if (IsMdiChild)
            //    ShowItems = new BarItem[] { btnBagliKayitlar, btnİrsaliyeAyarı };


        }
        protected override void Listele()
        {

            var liste = ((RevizyonBll)Bll).List(x =>  x.Durum == AktifKayitlariGoster);
            Tablo.GridControl.DataSource = liste;

        }
        protected override void ShowEditForm(long id)
        {
            var result = new ShowEditForms<RevizyonEditForm>().ShowDialogEditForm(Common.Enums.KartTuru.Revizyon, id, marka);
            ShowEditFormDefault(result);
        }
    }
}