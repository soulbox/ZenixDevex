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

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new Markalar() : ((MarkalarBll)Bll).Single(FilterFunctions.Filter<Markalar>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((MarkalarBll)Bll).YeniKodVer();
            txtAdı.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Markalar)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtAdı.Text = entity.Adı;
        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new Markalar
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