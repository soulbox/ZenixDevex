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
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;

namespace Zenix.WinUI.Forms.ÜrünlerFormu
{
    public partial class ÜrünEditForm : BaseEditForm
    {
        long firmaId;
        string firmaAdi;
        public ÜrünEditForm(params object[] prm)
        {
            InitializeComponent();
            firmaId = (long)prm[0];
            firmaAdi = prm[1].ToString();

            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new ÜrünBll(myDataLayoutControl);
            this.KartTuru = Common.Enums.KartTuru.Ürün;
            Text = "Ürün Kartı";
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            //if (isirsaliye && BaseIslemTuru == IslemTuru.EntityInsert)
            //    LayoutGizle(layFirma, layGTIN, layBarcodeSize, laygecikme);
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new ÜrünL() { FirmaId = firmaId, FirmaAdı = firmaAdi } : ((ÜrünBll)Bll).Single(FilterFunctions.Filter<Ürün>(Id));

            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ÜrünBll)Bll).YeniKodVer(x => x.FirmaId == firmaId);
            txtAdı.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (ÜrünL)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtGTIN.Text = entity.GTIN;
            txtAdı.Text = entity.Adı;
            txtMarka.Text = entity.Marka;
        }
        protected override void GuncelNesneOluştur()
        {
            CurrentEntity = new Ürün
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                GTIN = txtGTIN.Text,
                Adı = txtAdı.Text,
                Marka = txtMarka.Text,
                FirmaId = firmaId

            };
            ButtonEnableDurumu();

        }

        protected override bool EntityInsert()
        {
            return ((ÜrünBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.FirmaId == firmaId);
        }
        protected override bool EntityUpdate()
        {
            return ((ÜrünBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.FirmaId == firmaId);

        }
    }
}