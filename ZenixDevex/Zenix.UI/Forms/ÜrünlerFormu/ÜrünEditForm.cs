using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;
using System;

namespace Zenix.WinUI.Forms.ÜrünlerFormu
{
    public partial class ÜrünEditForm : BaseEditForm
    {
        public ÜrünEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new ÜrünBll(myDataLayoutControl);
            this.KartTuru = KartTuru.Ürün;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new ÜrünS() : ((ÜrünBll)Bll).Single(FilterFunctions.Filter<Ürün>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ÜrünBll)Bll).YeniKodVer();
            txtFirma.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (ÜrünS)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtFirma.Text = entity.FirmaAdi;
            txtFirma.Id = entity.FirmaId;
            txtMamül.Text = entity.MamülAdı;
            txtMamül.Id = entity.MamülId;
            txtMarka.Text = entity.MarkaAdı;
            txtMarka.Id = entity.MarkaId;
            txtGTIN.Text = entity.GTIN;
            txtKoli.EditValue = entity.Koli;
            txtStand.EditValue = entity.Stand;
            txtKutu.EditValue = entity.Kutu;
        }
        protected override void GuncelNesneOluştur()
        {
            long? firmaid = null;
            var gelenid = txtFirma.GetId();
            if (gelenid != 0)
                firmaid = gelenid;
            CurrentEntity = new Ürün
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                FirmaId = firmaid,
                MamülId = txtMamül.GetId(),
                MarkaId = txtMarka.GetId(),
                GTIN = txtGTIN.Text,
                Koli = txtKoli.EditValue.ConvertTo<int>(),
                Stand = txtStand.EditValue.ConvertTo<int>(),
                Kutu = txtKutu.EditValue.ConvertTo<int>(),

            };
            ButtonEnableDurumu();
        }
        protected override void SeçimYap(object sender)
        {
            if (!(sender is myButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtFirma)
                    sec.Seç(txtFirma);
                else if (sender == txtMarka)
                    sec.Seç(txtMarka);
                else if (sender == txtMamül)
                    sec.Seç(txtMamül);
            }
        }
    }
}