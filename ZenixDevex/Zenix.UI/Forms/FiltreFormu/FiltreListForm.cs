using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.WinUI.Show;
using DevExpress.XtraGrid;
using Zenix.Common.Enums;

namespace Zenix.WinUI.Forms.FiltreFormu
{
    public partial class FiltreListForm : BaseListForm
    {
        readonly KartTuru FiltreKayitTuru;
        readonly GridControl FiltreGrid;
        public FiltreListForm(params object[] prm)
        {
            FiltreKayitTuru = (KartTuru)prm[0];
            FiltreGrid = (GridControl)prm[1];

            InitializeComponent();
            Bll = new FiltreBll();
            HideItems = new DevExpress.XtraBars.BarItem[] 
            {
                btnFiltrele,
                btnKolonlar,
                btnYazdır,
                btnGonder,
                barFiltre,
                barFiltreAciklama,
                barKolonlar,
                barKolonlarAciklama,
                barYazdir,
                barYazdirAciklama,
                barGonder,
                barGonderAciklama 
            };

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = KartTuru.Filtre;
            //this.FormShow = new ShowEditForms<PLCEditForm>();
            this.Navigator = longNavigator.controlNavigator;

            //this.Text = $"[{MakineAdi}] - [{MakineNo }] PLC Cihazları  ";
            Tablo.ViewCaption = Text;
        }
        protected override void Listele()
        {
            var source = ((FiltreBll)Bll).List(x=>x.KartTuru == FiltreKayitTuru);
            Tablo.GridControl.DataSource = source;
        }
        protected override void ShowEditForm(long id)
        {
            var result = new ShowEditForms<FiltreEditForm>().ShowDialogEditForm(KartTuru.Filtre, id, FiltreKayitTuru,FiltreGrid );
            ShowEditFormDefault(result);

        }
    }
}