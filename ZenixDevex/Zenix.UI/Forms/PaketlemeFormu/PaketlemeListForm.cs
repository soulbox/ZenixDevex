﻿using System;
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
namespace Zenix.WinUI.Forms.PaketlemeFormu
{
    public partial class PaketlemeListForm : BaseListForm
    {
        readonly Ürün ürün;

        public PaketlemeListForm(params object[] prm)
        {
            ürün = (Ürün)prm[0];
            InitializeComponent();
            Bll = new PaketlemeBll ();

        }
        protected override void Degiskenleridoldur()
        {

            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Paketleme;
            this.Navigator = longNavigator.controlNavigator;
            //this.FormShow = new ShowEditForms<ÜrünEditForm>();
            this.Text = $"[{ürün.Adı }] Ürününün Paketleri";
            Tablo.ViewCaption = Text;

            //if (IsMdiChild)
            //    ShowItems = new BarItem[] { btnBagliKayitlar, btnİrsaliyeAyarı };


        }
        protected override void Listele()
        {

            var liste = ((PaketlemeBll )Bll).List(x => x.Durum == AktifKayitlariGoster && x.ÜrünId == ürün.Id);
            Tablo.GridControl.DataSource = liste;

        }
        protected override void ShowEditForm(long id)
        {
            var result = new ShowEditForms<PaketlemeEditForm>().ShowDialogEditForm(Common.Enums.KartTuru.Paketleme, id, ürün);
            ShowEditFormDefault(result);
        }
    }
}