using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;

namespace Zenix.WinUI.Forms.MalzemeFormu
{
    public partial class MalzemeEditForm : BaseEditForm
    {
        public MalzemeEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new MalzemeBll(myDataLayoutControl);
            this.KartTuru = KartTuru.Malzeme;
            cmbAmbalajTipi.ToData<AmbalajTipi>();
            cmbHacimBirim.ToData<BirimTipi>();
            cmbMalzemeBirim.ToData<BirimTipi>();
            cmbMalzemeTipi.ToData<MalzemeTipi>();
            cmbAmbalajMaddeTipi.ToData<AmbalajMaddeTipi>();


            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new Malzeme() : ((MalzemeBll)Bll).Single(FilterFunctions.Filter<Malzeme>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MalzemeBll)Bll).YeniKodVer();
            txtAdı.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Malzeme)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            cmbAmbalajTipi.Text = entity.AmbalajTipi.ToName();
            cmbHacimBirim.Text = entity.HacimBirimi.ToName();
            cmbMalzemeBirim.Text = entity.MalzemeBirimi.ToName();
            cmbMalzemeTipi.Text = entity.MalzemeTipi.ToName();
            cmbAmbalajMaddeTipi.Text = entity.AmbalajMaddeTipi.ToName();
            txtAdı.Text = entity.Adı;
            txtHacim.EditValue = entity.Hacim;


        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new Malzeme
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                AmbalajTipi = cmbAmbalajTipi.Text.GetEnum<AmbalajTipi>(),
                HacimBirimi = cmbHacimBirim.Text.GetEnum<BirimTipi>(),
                MalzemeBirimi = cmbMalzemeBirim.Text.GetEnum<BirimTipi>(),
                MalzemeTipi = cmbMalzemeTipi.Text.GetEnum<MalzemeTipi>(),
                AmbalajMaddeTipi = cmbAmbalajMaddeTipi.Text.GetEnum<AmbalajMaddeTipi>(),
                Adı = txtAdı.Text,
                Hacim = txtHacim.EditValue.ConvertTo<int>(),
            };
            ButtonEnableDurumu();
        }

    }
}