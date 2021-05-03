using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;
using System;

namespace Zenix.WinUI.Forms.MarkalarFormu
{
    public partial class MarkalarEditForm : BaseEditForm
    {
        public MarkalarEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new MarkalarBll(myDataLayoutControl);
            this.KartTuru = KartTuru.Markalar;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new MarkalarS() : ((MarkalarBll)Bll).Single(FilterFunctions.Filter<Markalar>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MarkalarBll)Bll).YeniKodVer(x => x.ÜrünId == ((MarkalarS)OldEntity).ÜrünId);
            txtAdı.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MarkalarS)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtAdı.Text = entity.Adı;
            txtFirma.Text = entity.FirmaAdı;
            txtFirma.Id = entity.FirmaId;
            txtÜrün.Text = entity.ÜrünAdı;
            txtÜrün.Id = entity.ÜrünId;
            txtGTIN.Text = entity.GTIN;
            txtAçıklama.Text = entity.Açıklama;

        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new Markalar
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                Adı = txtAdı.Text,
                FirmaId = txtFirma.GetId(),
                ÜrünId = txtÜrün.GetId(),
                GTIN = txtGTIN.Text,
                Açıklama = txtAçıklama.Text,        

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
                else if (sender == txtÜrün)
                    sec.Seç(txtÜrün);
            }
        }
        protected override void EditValueChanged(object sender, EventArgs e)
        {
            if (sender is myButtonEdit btn && btn == txtÜrün && ((MarkalarS)OldEntity).ÜrünId != btn.Id)
                txtKod.Text = ((MarkalarBll )Bll).YeniKodVer(x => x.ÜrünId  == btn.Id);
            base.EditValueChanged(sender, e);
        }
        protected override bool EntityInsert()
        {
            return ((MarkalarBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.ÜrünId == txtÜrün .Id);
        }
        protected override bool EntityUpdate()
        {
            return ((MarkalarBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.ÜrünId == txtÜrün.Id);

        }
    }
}