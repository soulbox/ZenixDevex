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

            this.btnBağlıKayıtları.ImageOptions.Image = Properties.Resources.code_fork_16px;
            this.btnBağlıKayıtları.ImageOptions.LargeImage = Properties.Resources.code_fork_32px;
            btnBağlıKayıtları.Caption = "Revizyon Kartları";
            ShowHideButtons(IsMdiChild, btnBağlıKayıtları, btnŞarz, btnPaketleme);




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
        Ürün GetÜrün { get => tablo.GetRow<Ürün>(); }
        protected override void BağlıKayıtlarAc()
        {
            if (GetÜrün == null) return;
            ShowListForms<ReziyonListForm>.ShowListForm(Common.Enums.KartTuru.Revizyon, GetÜrün);
        }
        protected override void ŞarjAc()
        {
            if (GetÜrün == null) return;
            ShowListForms<ŞarzListForm>.ShowListForm(Common.Enums.KartTuru.Şarj, GetÜrün);

        }
        protected override void PaketlemeAc()
        {
            if (GetÜrün == null) return;
            ShowListForms<PaketlemeListForm>.ShowListForm(Common.Enums.KartTuru.Paketleme, GetÜrün);

        }
    }

}