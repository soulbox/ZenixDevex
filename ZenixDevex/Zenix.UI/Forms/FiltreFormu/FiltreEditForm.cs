using Zenix.WinUI.Forms.BaseForms;
using Zenix.Common.Enums;
using DevExpress.XtraGrid;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using DevExpress.XtraBars;

namespace Zenix.WinUI.Forms.FiltreFormu
{
    public partial class FiltreEditForm : BaseEditForm
    {
        readonly KartTuru FiltreKayitTuru;
        readonly GridControl FiltreGrid;
        public FiltreEditForm(params object[] prm)
        {
            FiltreKayitTuru = (KartTuru)prm[0];
            FiltreGrid = (GridControl)prm[1];
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new FiltreBll(myDataLayoutControl);
            
            this.KartTuru = KartTuru.Filtre;

            HideItems = new BarItem[] { btnYeni, btnGeriAl };
            ShowItems = new BarItem[] { btnFarkliKaydet, btnUygula };

            EventsLoad();

        }
        protected internal override void Yukle()
        {
            txtFiltreMetni.SourceControl = FiltreGrid;


            while (true)
            {
                if (BaseIslemTuru == IslemTuru.EntityInsert)
                {
                    OldEntity = new Filtre();
                    Id = BaseIslemTuru.IdOlustur(OldEntity);
                    txtKod.Text = ((FiltreBll)Bll).YeniKodVer(x => x.KartTuru == FiltreKayitTuru);
                    txtFiltreAdi.Focus();

                }
                else
                {
                    OldEntity = ((FiltreBll)Bll).Single(FilterFunctions.Filter<Filtre>(Id));
                    if (OldEntity == null)
                    {
                        BaseIslemTuru = IslemTuru.EntityInsert;
                        continue;
                    }
                    NesneyiKontrollereBagla();

                }
                break;
            }

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Filtre)OldEntity;
            txtKod.Text = entity.Kod;
            txtFiltreAdi.Text = entity.FiltreAdi;
            txtFiltreMetni.FilterString  = entity.FiltreMetni;


        }
        protected override void GuncelNesneOluştur()
        {
            CurrentEntity = new Filtre
            {
                Id = Id,
                Kod = txtKod.Text,
                FiltreAdi = txtFiltreAdi.Text,
                FiltreMetni = txtFiltreMetni.FilterString,
                KartTuru = FiltreKayitTuru
            };
            ButtonEnableDurumu();
        }
        protected override bool EntityInsert()
        {
            return ((FiltreBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == FiltreKayitTuru);
        }
        protected override bool EntityUpdate()
        {
            return ((FiltreBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == FiltreKayitTuru);

        }
        protected override void FiltreUygula()
        {
            txtFiltreMetni.Select();
            txtFiltreMetni.ApplyFilter();
        }
        protected internal override void ButtonEnableDurumu()
        {
            if (!isLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnFarkliKaydet, btnSil, BaseIslemTuru, OldEntity, CurrentEntity);
        }
        protected override void SeçimYap(object sender)
        {
            //if (!(sender is ButtonEdit)) return;
            //using (var sec = new SelectFunctions())
            //{
            //    sec.Seç(txtMakine);

            //    //if (sender == txtkendisi)
            //    //    sec.Seç(txtkendisi);
            //    //else if (sender == ilişkiliolansa)
            //    //    sec.Seç(ilişkiliolansa, txtkendisi);
            //}
        }
    }
}