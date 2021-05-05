using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;

namespace Zenix.WinUI.Forms.MamülFormu
{
    public partial class MamülEditForm : BaseEditForm
    {
        public MamülEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new MamülBll(myDataLayoutControl);
            this.KartTuru = KartTuru.Mamül;
            cmbAlanBirim.ToData<BirimTipi>();
            cmbAğırlıkBirim.ToData<BirimTipi>();
            cmbMalzemeBirim.ToData<BirimTipi>();
            cmbTeknikBirim.ToData<BirimTipi>();
            cmbMalzemeTipi.ToData<MalzemeTipi>();
            cmbSarfTipi.ToData<SarfTipi>();



            EventsLoad();

        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new MamülL() : ((MamülBll)Bll).Single(FilterFunctions.Filter<Mamül>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MamülBll)Bll).YeniKodVer();
            txtAdı.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MamülL)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            cmbAlanBirim.Text      = entity.AlanınBirimi    .ToName();
            cmbAğırlıkBirim.Text   = entity.AğırlığınBirimi .ToName();
            cmbMalzemeBirim.Text   = entity.MalzemeBirimi   .ToName();
            cmbTeknikBirim.Text    = entity.BirimAuEbY      .ToName();
            cmbMalzemeTipi.Text    = entity.MalzemeTipi     .ToName();
            cmbSarfTipi.Text       = entity.SarfTipi        .ToName();
            txtAdı.Text            = entity.Adı                 ;
            txtAmbalajMaddesi.Text = entity.AmbalajMaddeAdı     ;
            txtAmbalajMaddesi.Id   = entity.AmbalajMaddeTipiId  ;
            txtAmbalajTipi.Text    = entity.AmbalajTipiAdı      ;
            txtAmbalajTipi.Id      = entity.AmbalajTipiId       ;
            txtAlan.EditValue      = entity.Alan                ;
            txtAğırlık.EditValue   = entity.Ağırlık             ;
            txtBoy.EditValue       = entity.Boy                 ;
            txtEn.EditValue        = entity.En                  ;
            txtUzunluk.EditValue   = entity.Uzunluk             ;
            txtYükseklik.EditValue = entity.Yükseklik           ;
            txtAğızölçüsü.EditValue = entity.AğızÖlçüsü         ;
            txtHacim.EditValue     = entity.Hacim               ;




        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new MamülL
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                AlanınBirimi       = cmbAlanBirim.Text     .GetEnum<BirimTipi>()   ,
                AğırlığınBirimi    =cmbAğırlıkBirim.Text   .GetEnum<BirimTipi>()   ,
                MalzemeBirimi      =cmbMalzemeBirim.Text   .GetEnum<BirimTipi>()   ,
                BirimAuEbY         =cmbTeknikBirim.Text    .GetEnum<BirimTipi>()   ,
                MalzemeTipi        =cmbMalzemeTipi.Text    .GetEnum<MalzemeTipi>() ,
                SarfTipi           =cmbSarfTipi.Text       .GetEnum<SarfTipi>()    ,
                Adı                = txtAdı.Text                                ,               
                AmbalajMaddeTipiId =txtAmbalajMaddesi       .GetId()            ,
                AmbalajTipiId      =txtAmbalajTipi          .GetId()            ,
                Alan               =txtAlan.EditValue       .ConvertTo<float>() ,
                Ağırlık            =txtAğırlık.EditValue    .ConvertTo<float>() ,
                Boy                =txtBoy.EditValue        .ConvertTo<float>() ,
                En                 =txtEn.EditValue         .ConvertTo<float>() ,
                Uzunluk            =txtUzunluk.EditValue    .ConvertTo<float>() ,
                Yükseklik          =txtYükseklik.EditValue  .ConvertTo<float>() ,
                AğızÖlçüsü         =txtAğızölçüsü.EditValue  .ConvertTo<float>() ,
                
                Hacim              =txtHacim.EditValue      .ConvertTo<int>()   ,
                
            };
            ButtonEnableDurumu();
        }
        protected override void SeçimYap(object sender)
        {
            if (!(sender is myButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtAmbalajTipi)
                    sec.Seç(txtAmbalajTipi);
                else if (sender == txtAmbalajMaddesi)
                    sec.Seç(txtAmbalajMaddesi);
            }
        }
    }

}