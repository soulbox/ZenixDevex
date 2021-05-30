using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;

namespace Zenix.WinUI.Forms.AmbalajTipiFormu
{
    public partial class FirmaTipiEditForm : BaseEditForm
    {
        public FirmaTipiEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new FirmaTipiBll(myDataLayoutControl);
            this.KartTuru = KartTuru.FirmaTipi;
            EventsLoad();

        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new FirmaTipi() : ((FirmaTipiBll)Bll).Single(FilterFunctions.Filter<FirmaTipi>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((FirmaTipiBll)Bll).YeniKodVer();
            txtAdı.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (FirmaTipi)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new FirmaTipi
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                Adı = txtAdı.Text,

            };
            ButtonEnableDurumu();
        }
    }
}
