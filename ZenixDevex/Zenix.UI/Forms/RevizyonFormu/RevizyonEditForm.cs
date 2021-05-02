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

namespace Zenix.WinUI.Forms.RevizyonFormu
{
    public partial class RevizyonEditForm : BaseEditForm
    {
        readonly Ürün ürün;
        public RevizyonEditForm(params object[] prm)
        {
            ürün = (Ürün)prm[0];
            InitializeComponent();
            
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new RevizyonBll(myDataLayoutControl);
            this.KartTuru = Common.Enums.KartTuru.Revizyon;
            Text = "Revizyon Kartı";
            dtRevTarih.Properties.MinValue = DateTime.Now.AddYears(-20);
      

            EventsLoad();
        }
        protected internal override void Yukle()
        {
            //if (isirsaliye && BaseIslemTuru == IslemTuru.EntityInsert)
            //    LayoutGizle(layFirma, layGTIN, layBarcodeSize, laygecikme);
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Revizyon() : ((RevizyonBll)Bll).Single(FilterFunctions.Filter<Revizyon>(Id));

            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RevizyonBll)Bll).YeniKodVer(x => x.ÜrünId == ürün.Id);
            dtRevTarih.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Revizyon)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            dtRevTarih.DateTime = entity.RevizyonTarihi;
            txtAçıklama.Text = entity.Açıklama;

        }
        protected override void GuncelNesneOluştur()
        {
            CurrentEntity = new Revizyon
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                RevizyonTarihi = dtRevTarih.DateTime,
                Açıklama = txtAçıklama.Text,
                ÜrünId = ürün.Id,

            };
            ButtonEnableDurumu();

        }

        protected override bool EntityInsert()
        {
            return ((RevizyonBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.ÜrünId  == ürün.Id);
        }
        protected override bool EntityUpdate()
        {
            return ((RevizyonBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.ÜrünId == ürün.Id);

        }
    }
}