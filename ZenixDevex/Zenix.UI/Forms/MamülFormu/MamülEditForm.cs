using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;
using System;
using Zenix.Model.Entities.Base;
using Zenix.Common.Messages;

namespace Zenix.WinUI.Forms.MamülFormu
{
    public partial class MamülEditForm : BaseEditForm
    {
        bool isÜrün { get; }
        MamülL Ticarimamül = null;
        public MamülEditForm(bool isürün, MamülL mamül = null)
        {
            isÜrün = isürün;
            Ticarimamül = mamül;
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new MamülBll(myDataLayoutControl);
            this.KartTuru = KartTuru.Mamül;
            cmbAlanBirim.ToData<BirimTipi>();
            cmbAğırlıkBirim.ToData<BirimTipi>();
            cmbMalzemeBirim.ToData<BirimTipi>();
            cmbTeknikBirim.ToData<BirimTipi>();

            cmbMalzemeTipi.ToData<MalzemeTipi>(x => !x.Description.Contains("Ürün"));
            cmbSarfTipi.ToData<SarfTipi>();
            LayoutGizleGoster(!isÜrün, layMalzemetipi, layticari);


            EventsLoad();

        }
        protected internal override void Yukle()
        {
            if (Ticarimamül != null)
                BaseIslemTuru = IslemTuru.EntityInsert;
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? Ticarimamül ?? new MamülL() { MalzemeTipi = !isÜrün ? MalzemeTipi.HamMadde : default } : ((MamülBll)Bll).Single(FilterFunctions.Filter<Mamül>(Id));

            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            var maltipi = ((IMamül)OldEntity).MalzemeTipi;
            txtKod.Text = ((MamülBll)Bll).YeniKodVer(maltipi, x => x.MalzemeTipi == maltipi);
            if (Ticarimamül == null)
                txtMamülAdı.Focus();
            else
                txtTicariİsim.Focus();



        }



        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MamülL)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            cmbAlanBirim.Text = entity.AlanınBirimi.ToName();
            cmbAğırlıkBirim.Text = entity.AğırlığınBirimi.ToName();
            cmbMalzemeBirim.Text = entity.MalzemeBirimi.ToName();
            cmbTeknikBirim.Text = entity.BirimAuEbY.ToName();
            cmbMalzemeTipi.Text = entity.MalzemeTipi.ToName();
            cmbSarfTipi.Text = entity.SarfTipi.ToName();
            txtMamülAdı.Text = entity.MamülAdı;
            txtAmbalajMaddesi.Text = entity.AmbalajMaddeAdı;
            txtAmbalajMaddesi.Id = entity.AmbalajMaddeTipiId;
            txtAmbalajTipi.Text = entity.AmbalajTipiAdı;
            txtAmbalajTipi.Id = entity.AmbalajTipiId;
            txtAlan.EditValue = entity.Alan;
            txtAğırlık.EditValue = entity.Ağırlık;
            txtBoy.EditValue = entity.Boy;
            txtEn.EditValue = entity.En;
            txtUzunluk.EditValue = entity.Uzunluk;
            txtYükseklik.EditValue = entity.Yükseklik;
            txtAğızölçüsü.EditValue = entity.AğızÖlçüsü;
            txtHacim.EditValue = entity.Hacim;

            txtTicariİsim.Text = entity.Ticariİsim;


        }
        protected override void EditValueChanged(object sender, EventArgs e)
        {

            var maltipi = cmbMalzemeTipi.Text.GetEnum<MalzemeTipi>();
            var oldmal = ((Mamül)OldEntity).MalzemeTipi;
            var curmal = ((Mamül)CurrentEntity)?.MalzemeTipi;
            if (sender != txtKod)
                if (sender == cmbMalzemeTipi && isLoaded)
                    if (maltipi != oldmal || BaseIslemTuru == IslemTuru.EntityInsert)
                        txtKod.Text = ((MamülBll)Bll).YeniKodVer(maltipi, x => x.MalzemeTipi == maltipi);
                    else
                        txtKod.Text = ((Mamül)OldEntity).Kod;
            txtHacim.Enabled = maltipi == MalzemeTipi.Ürün | maltipi == MalzemeTipi.Şişe | maltipi == MalzemeTipi.Kavanoz | maltipi == MalzemeTipi.Diğer;

            base.EditValueChanged(sender, e);

        }
        protected override void GuncelNesneOluştur()
        {
            var malzemetipi = isÜrün ? MalzemeTipi.Ürün : cmbMalzemeTipi.Text.GetEnum<MalzemeTipi>();
            var sarftipi = malzemetipi == MalzemeTipi.Ürün ? SarfTipi.Yok : cmbSarfTipi.Text.GetEnum<SarfTipi>();
            CurrentEntity = new Mamül
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                AlanınBirimi = cmbAlanBirim.Text.GetEnum<BirimTipi>(),
                AğırlığınBirimi = cmbAğırlıkBirim.Text.GetEnum<BirimTipi>(),
                MalzemeBirimi = cmbMalzemeBirim.Text.GetEnum<BirimTipi>(),
                BirimAuEbY = cmbTeknikBirim.Text.GetEnum<BirimTipi>(),
                MalzemeTipi = malzemetipi,
                SarfTipi = sarftipi,
                MamülAdı = txtMamülAdı.Text,
                AmbalajMaddeTipiId = txtAmbalajMaddesi.GetId(),
                AmbalajTipiId = txtAmbalajTipi.GetId(),
                Alan = txtAlan.EditValue.ConvertTo<float>(),
                Ağırlık = txtAğırlık.EditValue.ConvertTo<float>(),
                Boy = txtBoy.EditValue.ConvertTo<float>(),
                En = txtEn.EditValue.ConvertTo<float>(),
                Uzunluk = txtUzunluk.EditValue.ConvertTo<float>(),
                Yükseklik = txtYükseklik.EditValue.ConvertTo<float>(),
                AğızÖlçüsü = txtAğızölçüsü.EditValue.ConvertTo<float>(),
                Hacim = txtHacim.Enabled ? txtHacim.EditValue.ConvertTo<int>() : default,
                Ticariİsim = txtTicariİsim.Text,

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
        protected override bool EntityInsert()
        {
            return !HasError(CurrentEntity) && ((MamülBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.MalzemeTipi == ((IMamül)CurrentEntity).MalzemeTipi);

        }
        protected override bool EntityUpdate()
        {
            return !HasError(CurrentEntity) && ((MamülBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.MalzemeTipi == ((IMamül)CurrentEntity).MalzemeTipi);

        }
        bool HasError(BaseEntity curent)
        {
            var ent = (Mamül)curent;
            var hacimvar = ent.Hacim > 0;
            var birimvar = ent.MalzemeBirimi != BirimTipi.yok;
            var kimyasalbirim = ent.MalzemeBirimi == BirimTipi.kg | ent.MalzemeBirimi == BirimTipi.mL;
            var adbirim = ent.MalzemeBirimi == BirimTipi.ad;
            var hacimlibirim = hacimvar & birimvar;
            var hacimsizbirim = !hacimvar & birimvar;
            var hacimsizkimyasalbirim = !hacimvar & kimyasalbirim;
            var hacimsizaded = !hacimvar & adbirim;
            switch (ent.MalzemeTipi)
            {
                case MalzemeTipi.Şişe:
                case MalzemeTipi.Kavanoz:
                case MalzemeTipi.Ürün:
                    if (!hacimlibirim)
                        Msg.HataMesajı("Hacim değerini yada birim tipini giriniz!");
                    return !hacimlibirim;
                case MalzemeTipi.HamMadde:
                case MalzemeTipi.Esans:
                    if (!hacimsizkimyasalbirim)
                        Msg.HataMesajı(" Birim tipini giriniz!");
                    return !hacimsizkimyasalbirim;
                case MalzemeTipi.Koli:
                case MalzemeTipi.Kutu:
                case MalzemeTipi.Ambalaj:
                case MalzemeTipi.Etiket:
                case MalzemeTipi.Kapak:
                case MalzemeTipi.Sarf:
                    if (!hacimsizaded)
                        Msg.HataMesajı(" Birim tipini giriniz!");
                    return !hacimsizaded;
                default:
                    return false;
            }

        }
    }

}