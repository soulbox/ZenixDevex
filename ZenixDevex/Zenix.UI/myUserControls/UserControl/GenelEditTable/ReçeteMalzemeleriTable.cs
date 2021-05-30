using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.myUserControls.UserControl.Base;
using Zenix.BLL.General;
using Zenix.Model.DTO;
using Zenix.WinUI.Show;
using Zenix.WinUI.Forms.KullanıcıForms;
using Zenix.BLL.Functions;
using DevExpress.Utils.Extensions;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.Common.Enums;
using DevExpress.XtraBars;
using Zenix.WinUI.Forms.ReçeteFormu;
using Zenix.Common.Messages;

namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    public partial class ReçeteMalzemeleriTable : BaseTablo
    {
        public ReçeteMalzemeleriTable()
        {
            InitializeComponent();
            repoimagecomboFaz.Items.AddEnum<FazTipi>();
            repoimgaecomboAşama.Items.AddEnum<AşamaTipi>();

            Bll = new ReçeteMalzemelerBll();
            baseTablo = tablo;
            //ShowItems = new BarItem[] { btnTümSeçimleriKaldır, btnTümünüSeç };
            EventsLoad();
        }

        protected internal override void Listele()
        {
            var lists = ((ReçeteMalzemelerBll)Bll).List(x => x.ReçeteId == ownerform.Id).ToBindingList<ReçeteMalzemeleriL>();
            var hacim = lists.FirstOrDefault(x => x.Hacim > 0)?.Hacim;
            var enti = lists.FirstOrDefault(x => x.Hacim > 0);
            tablo.ViewCaption = hacim.HasValue ? $"Malzemeleri {enti.HacimliMalzemeAdı}-{hacim}{enti.HacimliMalzemeBirimi  } " : $"Malzemeleri";

            lists.ForEach(x =>
                {
                    bool isKim = x.MalzemeTipi == MalzemeTipi.HamMadde | x.MalzemeTipi == MalzemeTipi.Esans;
                    x.Miktar = !isKim ? (100 / (float)hacim * 1000) : x.Miktar;
                });
            tablo.GridControl.DataSource = lists;
            SortList();
        }
        void SortList()
        {
            var source = tablo.DataController.ListSource.Cast<ReçeteMalzemeleriL>();
            tablo.GridControl.DataSource =source.Order().ToBindingList<ReçeteMalzemeleriL>();
        }
        protected override void HareketEkle()
        {

            var source = tablo.DataController.ListSource;
            ListeDışıtutulacakkayıtlar = source.Cast<ReçeteMalzemeleriL>().Where(x => !x.Delete).Select(x => (long)x.MamülId).ToList();
            var entities = ShowListForms<ReçeteMalzemeleriListForm>.ShowDialogListForm(ListeDışıtutulacakkayıtlar, true).EntityListConvert<MamülL>();
            //var entities = ShowListForms<ReçeteMalzemeleriListForm>.ShowDialogListForm(ListeDışıtutulacakkayıtlar, true).EntityListConvert<MamülL>();

            if (entities == null) return;
            var birdenfazlahacimlimalzeme = source.Cast<ReçeteMalzemeleriL>().Where(x => x.Hacim > 0).Count() >= 1 &
                entities.Where(x => x.Hacim > 0).Count() >= 1;
            if (birdenfazlahacimlimalzeme)
            {
                Msg.HataMesajı("Şişe veya Kavanoz seçildi ");
                return;
            }
            var hacimentity = entities.FirstOrDefault(x => x.Hacim > 0);

            var hacim = hacimentity?.Hacim;
            var hacimmalzeme = hacimentity?.MamülAdı;

            entities.ForEach(x =>
            {
                bool isKim = x.MalzemeTipi == MalzemeTipi.HamMadde | x.MalzemeTipi == MalzemeTipi.Esans;
                using (var depobll = new DepoBll())
                    source.Add(new ReçeteMalzemeleriL
                    {
                        ReçeteId = ownerform != null ? ownerform.Id : 0,
                        MamülAdı = x.MamülAdı,
                        MamülId = x.Id,
                        Insert = true,
                        Miktar = !isKim & hacim.HasValue ? (100 / (float)hacim.Value * 1000) : 0,
                        ReçeteBirimi = isKim ? BirimTipi.kg : BirimTipi.ad,
                        AşamaTipi = isKim ? AşamaTipi.Şarj : AşamaTipi.yok,
                        MalzemeTipi = x.MalzemeTipi,
                        Hacim = x.Hacim,
                        Stok = depobll.StokVer(x.Id)

                    });

            });
            var sourcehacim = source.Cast<ReçeteMalzemeleriL>().FirstOrDefault(x => x.Hacim > 0);
            source.Cast<ReçeteMalzemeleriL>().ForEach(x =>
            {
                bool isKim = x.MalzemeTipi == MalzemeTipi.HamMadde | x.MalzemeTipi == MalzemeTipi.Esans;
                var sourcehacimval = sourcehacim?.Hacim;
                x.Miktar = !isKim & sourcehacimval.HasValue ? (100 / (float)sourcehacimval.Value * 1000) : x.Miktar;

            });
            tablo.ViewCaption = (sourcehacim?.Hacim).HasValue ? $"Malzemeleri {sourcehacim.MamülAdı}-{sourcehacim.Hacim}{sourcehacim.MalzemeBirimi} " : $"Malzemeleri";

            tablo.Focus();
            tablo.RefreshDataSource();

            tablo.GridControl.RefreshDataSource();
            SortList();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            ButtonEnableDurum(true);

        }
        protected internal override bool HatalıGiriş()
        {
            void hata(int rowhandle, string msg)
            {
                tablo.Focus();
                tablo.FocusedRowHandle = rowhandle;
                Msg.HataMesajı(msg);
            }

            if (!tablevaluechanged) return false;
            //if (tablo.DataRowCount == 0) return false;
            var source = tablo.DataController.ListSource.Cast<ReçeteMalzemeleriL>();
            bool isKimyasal(ReçeteMalzemeleriL enti) => enti.MalzemeTipi == MalzemeTipi.HamMadde | enti.MalzemeTipi == MalzemeTipi.Esans;

            var kimyasaloran = source.Where(x => isKimyasal(x)).Select(x => x.Miktar).DefaultIfEmpty(0).Sum();
            if (kimyasaloran > 100 | kimyasaloran == 0)
            {
                Msg.HataMesajı("Kimyasal Miktar toplam oranı 100 den büyük yada 0 olamaz!");
                return true;
            }

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var enti = tablo.GetRow<ReçeteMalzemeleriL>(i);
                bool isKim = isKimyasal(enti);
                if (enti.MalzemeİçiÜrün == 0 & !isKim)
                {
                    hata(i, "Malzeme içi Ürün Miktarı 0 olamaz!");
                    return true;
                }
            }



            return false;
        }
        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;
            var enti = tablo.GetRow<ReçeteMalzemeleriL>();
            if (!enti.HasValue()) return;
            bool isKim = enti.MalzemeTipi == MalzemeTipi.HamMadde | enti.MalzemeTipi == MalzemeTipi.Esans;
            colFazTipi.OptionsColumn.AllowEdit = isKim;
            colMiktar.OptionsColumn.AllowEdit = isKim;
            colMalzemeİçiÜrün.OptionsColumn.AllowEdit = !isKim;
            colAşamaTipi.OptionsColumn.AllowEdit = !isKim;


            //colEkleyebilir.OptionsColumn.AllowEdit = enti.Ekleyebilir != 2;
            //colDeğiştirebilir.OptionsColumn.AllowEdit = enti.Değiştirebilir != 2;
            //colSilebilir.OptionsColumn.AllowEdit = enti.Silebilir != 2;

        }

        private void myGridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
