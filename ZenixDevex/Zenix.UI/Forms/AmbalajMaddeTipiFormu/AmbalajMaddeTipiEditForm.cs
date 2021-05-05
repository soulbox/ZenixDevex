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
    public partial class AmbalajMaddeTipiEditForm : BaseEditForm
    {
        public AmbalajMaddeTipiEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new AmbalajMaddeTipiBll(myDataLayoutControl);
            this.KartTuru = KartTuru.AmbalajMaddeTipi;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new AmbalajMaddeTipi() : ((AmbalajMaddeTipiBll)Bll).Single(FilterFunctions.Filter<AmbalajMaddeTipi>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AmbalajMaddeTipiBll)Bll).YeniKodVer();
            txtAdı.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AmbalajMaddeTipi)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new AmbalajMaddeTipi
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
