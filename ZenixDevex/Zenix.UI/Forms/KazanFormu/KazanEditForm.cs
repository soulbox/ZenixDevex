using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;

namespace Zenix.WinUI.Forms.KazanFormu
{
    public partial class KazanEditForm : BaseEditForm
    {
        public KazanEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new KazanBll(myDataLayoutControl);
            this.KartTuru = KartTuru.Kazan;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new Kazan() : ((KazanBll)Bll).Single(FilterFunctions.Filter<Kazan>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((KazanBll)Bll).YeniKodVer();
            txtKod.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kazan)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtAçıklama.Text = entity.Açıklama;
            txtNo.EditValue = entity.No;
        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new Kazan
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                Açıklama = txtAçıklama.Text,
                No = txtNo.EditValue.ConvertTo<byte>(),

            };
            ButtonEnableDurumu();
        }
    }
}