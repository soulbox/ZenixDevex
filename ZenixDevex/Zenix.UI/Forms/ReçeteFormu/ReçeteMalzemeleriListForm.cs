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
using DevExpress.XtraBars;
using Zenix.Common.Enums;
using Zenix.Model.Entities;
using Zenix.Common.Messages;
using Zenix.Common.Function;
using Zenix.BLL.General;

namespace Zenix.WinUI.Forms.ReçeteFormu
{
    public partial class ReçeteMalzemeleriListForm : BaseListForm
    {
        public ReçeteMalzemeleriListForm()
        {
            InitializeComponent();
            Bll = new MalzemeBll();

            ShowHideButtons(false,
            btnYeni,
            btnSil,
            btnDüzelt,
            btnKolonlar,
            barInsert,
            barInsertAciklama,
            barDelete,
            barDeleteAciklama,
            barDuzelt,
            barDuzeltAciklama,
            barKolonlar,
            barKolonlarAciklama);
        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = KartTuru.Reçete;
            //this.FormShow = new ShowEditForms<RolEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            //Tablo.ViewCaption = Text;

        }
        protected override void Listele()
        {         
            var liste = ((MalzemeBll)Bll).MalzemeAdListesi(x => !ListeDışıBırakılıcakKayıtlar.Contains(x.Id)).ToList();
            Tablo.GridControl.DataSource = liste;
            if (!isMultiSelect) return;
            if (liste.Any())
                EkelenebilecekEntityVar = true;
            else
                Msg.UyariMesajı("İşlem Yapılabilecek Kart Bulunamadı");

        }

    }
}