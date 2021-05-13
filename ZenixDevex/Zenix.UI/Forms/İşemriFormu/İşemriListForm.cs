using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.WinUI.Show;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using DevExpress.XtraBars;
using Zenix.WinUI.myUserControls.Grid;
using System.Linq;
using Zenix.Common.Function;
using DevExpress.XtraGrid.Views.Grid;
using Zenix.WinUI.MainForm;
using DevExpress.Data;
using Zenix.Model.DTO;
using Zenix.Common.Enums;
using Zenix.Common.Messages;

namespace Zenix.WinUI.Forms.İşemriFormu
{
    public partial class İşemriListForm : BaseListForm
    {
        public İşemriListForm()
        {
            InitializeComponent();
            Bll = new İşemriBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Firma;
            this.FormShow = new ShowEditForms<İşemriEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "İşemri Kartları ";
            Tablo.ViewCaption = Text;
            //ShowHideButtons(IsMdiChild, btnBağlıKayıtları);
            //btnBağlıKayıtları.Caption = "Ürünleri";


        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((İşemriBll)Bll).List(FilterFunctions.Filter<İşemri>(AktifKayitlariGoster));
            Tablo_SelectionChanged(tablo, null);
        }
        protected override void SagMenuGoster(object sender, MouseEventArgs e)
        {
            var isRight = (e.Button == MouseButtons.Right);
            var entity = Tablo.GetRow<İşemriL>();
            ShowHideButtons(entity != null, btnAşamalar);
            base.SagMenuGoster(sender, e);
        }
        protected override void Tablo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var entity = Tablo.GetRow<İşemriL>();
            if (entity.isNull()) return;
            using (var üretimbll = new ÜretimBll())
            {
                var list = üretimbll.List(x => x.İşemriId == entity.Id);
                TabloÜretim.GridControl.DataSource = list;

            }
            using (var reçetebll = new ReçeteMalzemelerBll())
            {

                var list = reçetebll.List(x => x.ReçeteId == entity.ReçeteId).Cast<ReçeteMalzemeleriL>().ToList();
                list.ForEach(x => x.ŞarjMiktarı = entity.ŞarjMiktarı);
                ReçeteTablo.GridControl.DataSource = list;
                var hacimlimalzeme = list.FirstOrDefault();
                ReçeteTablo.ViewCaption = hacimlimalzeme == null ? "Reçetesi" : $"Reçete-{hacimlimalzeme.HacimliMalzemeAdı}-Hacim:{hacimlimalzeme.Hacim}";

            }
        }
        protected override void TümAşamalarYapıldı()
        {

            if (Msg.HayirSeciliEvetHayir("Tüm Aşamalar Üretime Aktarılacak. Onaylıyormusunuxz?", "Tüm Aşamalar") != DialogResult.Yes)
                return;
            var entity = Tablo.GetRow<İşemriL>();
            if (entity.isNull()) return;
            using (var depobll = new DepoBll())
            using (var reçetebll = new ReçeteMalzemelerBll())
            using (var üretimbll = new ÜretimBll())
            {

                var reçetelist = reçetebll.ReçeteList(x => x.Id == entity.ReçeteId);
                var depodakiler = depobll.MalzemeDepoList(x => x.İşemriId == entity.Id && reçetelist.Select(a => a.MamülId).Contains(x.MamülId));
                var depos = reçetelist.Select(x =>
                {
                    var Depodakimiktar = depodakiler.Where(a => a.MamülId == x.MamülId)
                    .Select(a => a.DepoMiktar).DefaultIfEmpty(0).Sum();
                    var DepoMiktarMutlak = Math.Abs(Depodakimiktar);
                    return DepoMiktarMutlak < x.ihtiyaç ? new Depo
                    {
                        DepoMiktar = -1 * (x.ihtiyaç - DepoMiktarMutlak),
                        DepoTipi=DepoTipi.ÜKullanıldı,
                        MamülId=x.MamülId,
                        İşemriId=entity.Id,
                        KayıtTarihi=DateTime.Now,                        
                    } : null;
                }).Where(x => x != null).ToList();


            }


        }
        protected override void AşamaOnayla()
        {
            var tip = (AşamaTipi)cmbAşamaTipi.EditValue;
            switch (tip)
            {
                case AşamaTipi.yok:
                    break;
                case AşamaTipi.Etiketveinkjet:
                    break;
                case AşamaTipi.kapakvedolum:
                    break;
                case AşamaTipi.kutu:
                    break;
                case AşamaTipi.stand:
                    break;
                case AşamaTipi.fırça:
                    break;
                case AşamaTipi.sarf:
                    break;
                case AşamaTipi.koli:
                    break;
                case AşamaTipi.palet:
                    break;
                case AşamaTipi.kapak:
                    break;
                case AşamaTipi.sergrafi:
                    break;
                case AşamaTipi.inkjet:
                    break;
                case AşamaTipi.dolum:
                    break;
                case AşamaTipi.etiket:
                    break;
                case AşamaTipi.Şarj:
                    break;
                default:
                    break;
            }

        }
    }
}
