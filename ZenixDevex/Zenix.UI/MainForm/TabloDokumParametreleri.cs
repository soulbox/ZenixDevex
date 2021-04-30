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
using Zenix.Common.Enums;
using Zenix.Common.Function;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities.Base.Interfaces;
using Zenix.Model.Entities;

namespace Zenix.WinUI.MainForm
{
    public partial class TabloDokumParametreleri : BaseEditForm
    {
        DokumSekli dokumSekli;
      readonly   string RaporBasligi;
        public TabloDokumParametreleri(params object[] prm)
        {
            RaporBasligi = prm[0].ToString();
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl1;
            EventsLoad();
            HideItems = new DevExpress.XtraBars.BarItem[]
            {
            btnYeni,
            btnKaydet,
            btnGeriAl,
            btnSil,
            };
            ShowItems = new DevExpress.XtraBars.BarItem[]
            {
            btnYazdir,
            btnBaskiOnizleme
            };

        }
        protected internal override void Yukle()
        {
            txtRaporBasligi.Text = RaporBasligi;
            txtBaslikEkle.Properties.Items.AddRange(EnumFunction.GetEnumDescriptionList<EvetHayir>());
            txtRaporKagidaSigdir.Properties.Items.AddRange(EnumFunction.GetEnumDescriptionList<RaporuKagidaSigdirmaTuru>());
            txtYazdirmaYonu.Properties.Items.AddRange(EnumFunction.GetEnumDescriptionList<YazdirmaYonu>());
            txtYatayCizgiGoster.Properties.Items.AddRange(EnumFunction.GetEnumDescriptionList<EvetHayir>());
            txtDikeyCizgiGoster.Properties.Items.AddRange(EnumFunction.GetEnumDescriptionList<EvetHayir>());
            txtSutunBaslikGoster.Properties.Items.AddRange(EnumFunction.GetEnumDescriptionList<EvetHayir>());
            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());

            txtBaslikEkle.SelectedItem = EvetHayir.Evet.ToName();
            txtRaporKagidaSigdir.SelectedItem = RaporuKagidaSigdirmaTuru.YaziBoyutunuKuculterekSigdir.ToName();
            txtYazdirmaYonu.SelectedItem =  YazdirmaYonu.Otomatik.ToName();
            txtYatayCizgiGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtDikeyCizgiGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtSutunBaslikGoster.SelectedItem = EvetHayir.Evet.ToName();
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();


        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new DokumParametreleri()
            {
                RaporBaslik = txtRaporBasligi.Text,
                BaslikEkle = txtBaslikEkle.Text.GetEnum<EvetHayir>(),
                RaporuKagidaSigdir = txtRaporKagidaSigdir.Text.GetEnum<RaporuKagidaSigdirmaTuru>(),
                YazdirmaYonu = txtYazdirmaYonu.Text.GetEnum<YazdirmaYonu>(),
                YatayCizgiGoster = txtYatayCizgiGoster.Text.GetEnum<EvetHayir>(),
                DikeyCizgiGoster = txtDikeyCizgiGoster.Text.GetEnum<EvetHayir>(),
                SutunBaslikGoster = txtSutunBaslikGoster.Text.GetEnum<EvetHayir>(),
                YazdirilicakAdet=(int)txtYazdirilicakAdet.Value ,
                YaziciAdi=txtYaziciAdi.Text ,
                DokumSekli= dokumSekli,
            };

            return entity;
        }
        protected override void Yazdir()
        {
            dokumSekli = DokumSekli.TabloYazdir;
            Close();
        }
        protected override void BaskiOnizleme()
        {
            dokumSekli = DokumSekli.TabloBaskiOnizleme;
            Close();

        }
        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtBaslikEkle) return;
            txtRaporBasligi.Enabled = txtBaslikEkle.Text.GetEnum<EvetHayir>() == EvetHayir.Evet;
        }
    }
}