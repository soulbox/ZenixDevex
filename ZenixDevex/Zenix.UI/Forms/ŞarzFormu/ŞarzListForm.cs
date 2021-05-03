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

namespace Zenix.WinUI.Forms.ŞarzFormu
{
    public partial class ŞarzListForm : BaseListForm
    {
        readonly MarkalarS marka;

        public ŞarzListForm(params object[] prm)
        {
            marka = (MarkalarS)prm[0];
            InitializeComponent();
            Bll = new ŞarzBll();

        }
        protected override void Degiskenleridoldur()
        {

            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Şarj;
            this.Navigator = longNavigator.controlNavigator;
            //this.FormShow = new ShowEditForms<ÜrünEditForm>();
           
            this.Text = $"[{marka.Adı}-{marka.ÜrünAdı}] Şarjları";

            Tablo.ViewCaption = Text;

            //if (IsMdiChild)
            //    ShowItems = new BarItem[] { btnBagliKayitlar, btnİrsaliyeAyarı };


        }
        protected override void Listele()
        {

            var liste = ((ŞarzBll)Bll).List(x => x.Durum == AktifKayitlariGoster && x.MarkalarId == marka.Id);
            Tablo.GridControl.DataSource = liste;

        }
        protected override void ShowEditForm(long id)
        {
            var result = new ShowEditForms<ŞarzEditForm >().ShowDialogEditForm(Common.Enums.KartTuru.Şarj, id, marka);
            ShowEditFormDefault(result);
        }

    }
}