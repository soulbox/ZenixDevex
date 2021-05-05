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
    public partial class AmbalajTipiEditForm : BaseEditForm
    {
        public AmbalajTipiEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new AmbalajTipiBll (myDataLayoutControl);
            this.KartTuru = KartTuru.AmbalajTipi ;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new AmbalajTipi() : ((AmbalajTipiBll)Bll).Single(FilterFunctions.Filter<AmbalajTipi>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((AmbalajTipiBll)Bll).YeniKodVer();
            txtAdı.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (AmbalajTipi)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;

        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new AmbalajTipi
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                Adı=txtAdı.Text,

            };
            ButtonEnableDurumu();
        }
    }
}
