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
using Zenix.Model.Entities.Base;
using DevExpress.XtraGrid.Views.Base;

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
        }
        protected override void SagMenuGoster(object sender, MouseEventArgs e)
        {
            var isRight = (e.Button == MouseButtons.Right);
            var entity = Tablo.GetRow<İşemriL>();
            ShowHideButtons(entity != null, btnAşamalar);
            base.SagMenuGoster(sender, e);
        }
        protected override void Tablo_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var entity = Tablo.GetRow<İşemriL>();

            if (entity.isNull())
            {
                ReçeteTablo.GridControl.DataSource = null;
                TabloÜretim.GridControl.DataSource = null;
                return;
            }
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

        enum Çarpan : int
        {
            giriş = 1,
            çıkış = -1
        }
        protected override void TümAşamalarYapıldı()
        {

            if (Msg.HayirSeciliEvetHayir("Tüm Aşamalar Üretime Aktarılacak. Onaylıyormusunuz?", "Tüm Aşamalar") != DialogResult.Yes)
                return;
            var entity = Tablo.GetRow<İşemriL>();
            if (entity.isNull()) return;


            using (var depobll = new DepoBll())
            using (var reçetebll = new ReçeteMalzemelerBll())
            using (var üretimbll = new ÜretimBll())
            {
                //işemrinin reçete malzemeleri
                var reçetelist = reçetebll.ReçeteList(x => x.ReçeteId == entity.ReçeteId, entity.ŞarjMiktarı);
                var mamülidler = reçetelist.Select(a => a.MamülId).ToList();
                //işemrinin reçetesindeki malzemelerin deposundaki liste
                var depodakiler = depobll.MalzemeDepoList(x => x.İşemriId == entity.Id && mamülidler.Contains(x.MamülId));
                var üretimdekiler = üretimbll.ÜretimList(x => x.İşemriId == entity.Id);


                (Depo depo, Üretim üretim) KayıtGetir(long mamülid, DepoTipi depoTipi, float ihtiyaç, Çarpan girişçıkış, bool isürün = false)
                {
                    var Depodakimiktar = depodakiler.Where(a => !isürün ? a.MamülId == mamülid : a.MamülId == mamülid && a.İşemriId == entity.Id)
                 .Select(a => a.DepoMiktar).DefaultIfEmpty(0).Sum();

                    var DepoMiktarMutlak = Math.Abs(Depodakimiktar);
                    //Üretimdeki x malzemesinin Miktar toplamı
                    var üretimdekimiktar = üretimdekiler.Where(a => a.MamülId == mamülid && a.İşemriId==entity.Id)
                    .Select(a => a.Miktar).DefaultIfEmpty(0).Sum();
                    var üretimMiktarMutlak = Math.Abs(üretimdekimiktar);
                    var üretim = üretimMiktarMutlak < ihtiyaç ? new Üretim
                    {
                        Id = IslemTuru.EntityInsert.IdOlustur(null),
                        Kod = depobll.YeniKodVer(),
                        Miktar = (ihtiyaç - üretimMiktarMutlak),
                        AşamaTipi = AşamaTipi.TamÜretim,
                        MamülId = mamülid,
                        İşemriId = entity.Id,
                        KayıtTarihi = DateTime.Now,
                    } : null;

                    var depo = DepoMiktarMutlak < ihtiyaç ? new Depo
                    {
                        Id = IslemTuru.EntityInsert.IdOlustur(null),
                        Kod = depobll.YeniKodVer(),
                        DepoMiktar = (int)girişçıkış * (ihtiyaç - DepoMiktarMutlak),
                        DepoTipi = depoTipi,
                        MamülId = mamülid,
                        İşemriId = entity.Id,
                        KayıtTarihi = DateTime.Now,
                    } : null;
                    if (isürün)
                        depo.ÜrünId = entity.ÜrünId;
                    return (depo, üretim);

                }

                //
                var AksiyonListesi = reçetelist.Select(x => KayıtGetir(x.MamülId, DepoTipi.ÜKullanıldı, x.ihtiyaç, Çarpan.çıkış)).ToList();
                var update = entity.Clone;
                update.Durum = false;
                //şarj/hacim*1000
                var düşülecekMalzemeler = AksiyonListesi.Where(x => x.depo != null)
                    .Select(x => x.depo).Cast<BaseEntity>().ToList();
                var üretimdüşülecekmalzemeler = AksiyonListesi.Where(x => x.üretim != null)
                    .Select(x => x.üretim).Cast<BaseEntity>().ToList();

                var hacim = reçetelist.FirstOrDefault()?.Hacim;
                var ürünihtiyaç = (float)((float)entity.ŞarjMiktarı / (float)hacim.Value * 1000);
                var ürüneklenicek = KayıtGetir(entity.MamülId, DepoTipi.Üretildi, ürünihtiyaç, Çarpan.giriş, true);
                if (ürüneklenicek.depo != null)
                    düşülecekMalzemeler.Add(ürüneklenicek.depo);
                if (ürüneklenicek.üretim != null)
                    üretimdüşülecekmalzemeler.Add(ürüneklenicek.üretim);

                if (!depobll.Insert(düşülecekMalzemeler) & !üretimbll.Insert(üretimdüşülecekmalzemeler) & !((İşemriBll)Bll).Update(entity, update))
                    Msg.HataMesajı("Bu işemrinin Reçetedeki Malzemeleri Malzeme Depodan Düşülemedi");
                else
                {
                    Listele();
                    Tablo_FocusedRowChanged(null, null);
                }

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
