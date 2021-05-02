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

namespace Zenix.WinUI.Forms.ŞarzFormu
{
    public partial class ŞarzEditForm : BaseEditForm
    {
        readonly Ürün ürün;
        public ŞarzEditForm(params object[] prm)
        {
            InitializeComponent();
            ürün = (Ürün)prm[0];
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new ŞarzBll(myDataLayoutControl);
            this.KartTuru = Common.Enums.KartTuru.Şarj;
            Text = "Revizyon Kartı";
            var dt = DateTime.Now;
            dtŞarzTarih.Properties.MinValue = dt.AddYears(-20);
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            //if (isirsaliye && BaseIslemTuru == IslemTuru.EntityInsert)
            //    LayoutGizle(layFirma, layGTIN, layBarcodeSize, laygecikme);
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Şarz() : ((ŞarzBll)Bll).Single(FilterFunctions.Filter<Şarz>(Id));

            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ŞarzBll)Bll).YeniKodVer(x => x.ÜrünId == ürün.Id);
            dtŞarzTarih.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Şarz)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            dtŞarzTarih.DateTime = entity.Tarih;
            txtAçıklama.Text = entity.Açıklama;

        }
        protected override void GuncelNesneOluştur()
        {
            CurrentEntity = new Şarz
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                Tarih = dtŞarzTarih.DateTime,
                Açıklama = txtAçıklama.Text,
                ÜrünId = ürün.Id,

            };
            ButtonEnableDurumu();

        }

        protected override bool EntityInsert()
        {
            return ((ŞarzBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.ÜrünId == ürün.Id);
        }
        protected override bool EntityUpdate()
        {
            return ((ŞarzBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.ÜrünId == ürün.Id);

        }
    }
}