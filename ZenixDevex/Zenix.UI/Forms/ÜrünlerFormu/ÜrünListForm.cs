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

namespace Zenix.WinUI.Forms.ÜrünlerFormu
{
    public partial class ÜrünListForm : BaseListForm
    {
        readonly long firmaId;
        readonly string firmaAdi;
        public ÜrünListForm(params object[] prm)
        {
            InitializeComponent();
            firmaId = (long)prm[0];
            firmaAdi = prm[1].ToString();
            Bll = new ÜrünBll();


        }
        protected override void Degiskenleridoldur()
        {

            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Ürün;
            this.Navigator = longNavigator.controlNavigator;
            this.FormShow = new ShowEditForms<ÜrünEditForm>();
            this.Text = $"[{firmaAdi}] Firmasının Ürünleri";
            Tablo.ViewCaption = Text;
            //if (IsMdiChild)
            //    ShowItems = new BarItem[] { btnBagliKayitlar, btnİrsaliyeAyarı };


        }

        protected override void Listele()
        {

            var liste = ((ÜrünBll)Bll).List(x => x.Durum == AktifKayitlariGoster && x.FirmaId == firmaId);
            Tablo.GridControl.DataSource = liste;

        }
        protected override void ShowEditForm(long id)
        {
            var result = new ShowEditForms<ÜrünEditForm>().ShowDialogEditForm(Common.Enums.KartTuru.Ürün, id, firmaId, firmaAdi);
            ShowEditFormDefault(result);
        }
    }

}