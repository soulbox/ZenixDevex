using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Function;
using Zenix.Common.Enums;
using Zenix.Model.DTO;
using Zenix.WinUI.myUserControls.Controls;
using Zenix.WinUI.MainForm;
using System;
using System.Linq;

namespace Zenix.WinUI.Forms.İşemriFormu
{
    public partial class İşemriEditForm : BaseEditForm
    {
        int şarjno = 1;

        public İşemriEditForm()
        {
            InitializeComponent();

            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new İşemriBll(myDataLayoutControl);
            this.KartTuru = KartTuru.İşemri;
            EventsLoad();


        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new İşemriS() : ((İşemriBll)Bll).Single(FilterFunctions.Filter<İşemri>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((İşemriBll)Bll).YeniKodVer();
            txtReçete.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (İşemriS)OldEntity;
            txtKod.Text = entity.Kod;
            tglDurum.IsOn = entity.Durum;
            txtReçete.Id = entity.ReçeteId;
            txtŞarjMiktarı.EditValue = entity.ŞarjMiktarı;
            dtTarih.DateTime = entity.işemriTarih;
            if (BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert) return;
            txtReçete.Text = entity.ReçeteAdı;


        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new İşemri
            {
                Id = Id,
                Kod = txtKod.Text,
                Durum = tglDurum.IsOn,
                işemriTarih = dtTarih.DateTime,
                KullanıcıId = AnaForm.Kullanıcı.Id,
                ReçeteId = txtReçete.GetId(),
                ŞarjMiktarı = txtŞarjMiktarı.EditValue.ConvertTo<int>(),
                ŞarjNo = şarjno,

            };
            ButtonEnableDurumu();
        }
        protected override void SeçimYap(object sender)
        {
            if (!(sender is myButtonEdit)) return;
            using (var sec = new SelectFunctions())
            {
                if (sender == txtReçete)
                    sec.Seç(txtReçete);
            }
        }
        protected override void EditValueChanged(object sender, EventArgs e)
        {
            void ChangeŞarjMiktarı()
            {
                var şarjmiktarı = txtŞarjMiktarı.EditValue.ConvertTo<float>();
                var source = ReçeteTablo.DataController.ListSource.Cast<ReçeteMalzemeleriL>();
                source.ToList().ForEach(x => x.ŞarjMiktarı = şarjmiktarı);
                ReçeteTablo.Focus();
                ReçeteTablo.RefreshDataSource();
                ReçeteTablo.GridControl.RefreshDataSource();
            }
            if (sender is myButtonEdit btn && sender == txtReçete && btn.Id > 0)
            {
                using (var reçetebll = new ReçeteMalzemelerBll())
                {
                    var list = reçetebll.List(x => x.ReçeteId == btn.Id).Cast<ReçeteMalzemeleriL>().Order().ToBindingList<ReçeteMalzemeleriL>();
                    ReçeteTablo.GridControl.DataSource = list;
                    var hacimlimalzeme = list.FirstOrDefault();


                    ReçeteTablo.ViewCaption = hacimlimalzeme == null ? "Reçetesi" : $"Reçete-{hacimlimalzeme.HacimliMalzemeAdı}-Hacim:{hacimlimalzeme.Hacim}";
                    ChangeŞarjMiktarı();
                }
            }
            if (sender is mySpinEdit && sender == txtŞarjMiktarı)
                ChangeŞarjMiktarı();
            base.EditValueChanged(sender, e);

        }

        
    }

}