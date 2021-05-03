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
using Zenix.Common.Function;

namespace Zenix.WinUI.Forms.PaketlemeFormu
{
    public partial class PaketlemeEditForm : BaseEditForm
    {
        readonly MarkalarS marka;
        public PaketlemeEditForm(params object[] prm)
        {
            marka = (MarkalarS)prm[0];
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new PaketlemeBll(myDataLayoutControl);
            this.KartTuru = Common.Enums.KartTuru.Paketleme;
            Text = "Paketleme Kartı";
            cmbAyartipi.ToData<AyarTipi>();
            cmbBirim.ToData<BirimTipi>();

            EventsLoad();
        }
        protected internal override void Yukle()
        {
            //if (isirsaliye && BaseIslemTuru == IslemTuru.EntityInsert)
            //    LayoutGizle(layFirma, layGTIN, layBarcodeSize, laygecikme);
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Paketleme() : ((PaketlemeBll)Bll).Single(FilterFunctions.Filter<Paketleme>(Id));

            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((PaketlemeBll)Bll).YeniKodVer(x => x.MarkalarId  == marka.Id);
            cmbAyartipi.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Paketleme)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtAçıklama.Text = entity.Açıklama;
            txtKutu.EditValue = entity.Kutu;
            txtKoli.EditValue = entity.Koli;
            txtStand.EditValue = entity.Stand;
            cmbAyartipi.Text = entity.AyarTipi.ToName();
            cmbBirim.Text = entity.BirimTipi.ToName();



        }
        protected override void GuncelNesneOluştur()
        {
            CurrentEntity = new Paketleme
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                Açıklama = txtAçıklama.Text,
                MarkalarId=marka.Id,
                AyarTipi = cmbAyartipi.Text.GetEnum<AyarTipi>(),
                BirimTipi = cmbBirim.Text.GetEnum<BirimTipi>(),
                Koli = txtKoli.EditValue.ConvertTo<int>(),
                Kutu = txtKutu.EditValue.ConvertTo<int>(),
                Stand = txtStand.EditValue.ConvertTo<int>(),
            };
            ButtonEnableDurumu();

        }

        protected override bool EntityInsert()
        {
            return ((PaketlemeBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.MarkalarId == marka.Id);
        }
        protected override bool EntityUpdate()
        {
            return ((PaketlemeBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.MarkalarId == marka.Id);

        }
    }
}