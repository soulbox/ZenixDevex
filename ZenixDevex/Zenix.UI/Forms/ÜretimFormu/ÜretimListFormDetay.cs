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

namespace Zenix.WinUI.Forms.ÜretimFormu
{
    public partial class ÜretimListFormDetay : BaseListForm
    {
        public ÜretimListFormDetay()
        {
            InitializeComponent();
            Bll = new ÜretimBll();
        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Üretim;
            this.FormShow = new ShowEditForms<ÜretimEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Üretim Kartları ";
            //Tablo.ViewCaption = Text;
            //ShowHideButtons(IsMdiChild, btnBağlıKayıtları);
            //btnBağlıKayıtları.Caption = "Ürünleri";
            ShowHideButtons(false, btnYeni, btnDüzelt, btnSil);


        }
        protected override void Listele()
        {
            using (var işemribll = new İşemriBll())
                Tablo.GridControl.DataSource = işemribll.List(FilterFunctions.Filter<İşemri>(AktifKayitlariGoster));

        }
        protected override void SagMenuGoster(object sender, MouseEventArgs e)
        {
            var isRight = (e.Button == MouseButtons.Right);
            var entity = Tablo.GetRow<İşemriL>();
            var isExistEntity = entity != null;
            ShowHideButtons(isExistEntity, btnAşamalar);
            if (isExistEntity)
                using (var reçetemalz = new YarıMamülBll())
                    repoYarıMamülLookUp.DataSource = reçetemalz.List(x => x.ÜrünId == entity.ÜrünId);
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

            using (var işemribll = new İşemriBll())
            using (var depobll = new DepoBll())
            using (var reçetebll = new ReçeteMalzemelerBll())
            using (var üretimbll = new ÜretimBll())
            {
                //işemrinin reçete malzemeleri
                var reçetelist = reçetebll.ReçeteList(x => x.ReçeteId == entity.ReçeteId, entity.ŞarjMiktarı);
                var mamülidler = reçetelist.Select(a => a.MamülId).ToList();
                //mamülidler.Add(entity.MamülId);//ürünidde gelsin
                //işemrinin reçetesindeki malzemelerin deposundaki liste
                var depodakiler = depobll.MalzemeDepoList(x => (x.İşemriId == entity.Id && mamülidler.Contains(x.MamülId)) | (x.ÜrünId.HasValue && x.ÜrünId == entity.ÜrünId));
                var üretimdekiler = üretimbll.ÜretimList(x => x.İşemriId == entity.Id);


                (Depo depo, Üretim üretim) KayıtGetir(long mamülid, DepoTipi depoTipi, float ihtiyaç, Çarpan girişçıkış, bool isürün = false)
                {
                    //depodaki ürün yada mamülün toplam miktarı
                    var Depodakimiktar = depodakiler.Where(a => !isürün ? a.MamülId == mamülid : a.MamülId == mamülid && a.İşemriId == entity.Id)
                 .Select(a => a.DepoMiktar).DefaultIfEmpty(0).Sum();

                    var DepoMiktarMutlak = Math.Abs(Depodakimiktar);
                    //Üretimdeki x malzemesinin Miktar toplamı
                    var üretimdekimiktar = üretimdekiler.Where(a => a.MamülId == mamülid && a.İşemriId == entity.Id)
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
                    if (isürün && depo != null)
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

                if (!depobll.Insert(düşülecekMalzemeler) & !üretimbll.Insert(üretimdüşülecekmalzemeler) & !işemribll.Update(entity, update))
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
            var Yarımamül = (YarıMamülL)barYarıMamül.EditValue;
            var entity = Tablo.GetRow<İşemriL>();

            var istenenmiktar = barÜretimMiktar.EditValue.ConvertTo<float>();

            if (Yarımamül.isNull(entity)) return;

            using (var işemribll = new İşemriBll())
            using (var depobll = new DepoBll())
            using (var reçetebll = new ReçeteMalzemelerBll())
            using (var üretimbll = new ÜretimBll())
            {
                //işemrinin  yarımamül Reçete Listesi
                var reçetelist = reçetebll.ReçeteList(x => x.ReçeteId == entity.ReçeteId, entity.ŞarjMiktarı);
                var mamülidler = reçetelist.Select(a => a.MamülId).ToList();
                var check = reçetelist.FirstOrDefault(x => x.YarıMamülId == Yarımamül.Id && x.Stok < istenenmiktar);
                var isŞarj = Yarımamül.YarıMamülAdı.Contains("Şarj");
                if (!isŞarj &&  check != null)
                {
                    Msg.HataMesajı($@"{(string.IsNullOrEmpty(check.YarıMamülAdı) ? default : $"Yarımamül:{check.YarıMamülAdı}")}
Ürün:{check.MamülAdı }
Stok:{check.Stok}
ihtiyaç:{check.ihtiyaç}
Girilen Miktar:{istenenmiktar}

Yetersiz Stok!");
                    return;
                }

                //işemrinin reçetesindeki malzemelerin deposundaki liste
                //var list = depobll.MalzemeDepoList(null);
                //var mamülDepoStok = depobll. MalzemeDepoList(x =>  mamülidler.Contains(x.MamülId));
                var depodakiler = depobll.MalzemeDepoList(x => x.İşemriId == entity.Id && mamülidler.Contains(x.MamülId));
                var üretimdekiler = üretimbll.ÜretimList(x => x.İşemriId == entity.Id);

                (List<Depo> depo, Üretim üretim) KayıtGetir(long mamülid, DepoTipi depoTipi, float ihtiyaç, float stok)
                {
                    //depodaki ürün yada mamülün toplam miktarı
                    List<Depo> resultdepo = new List<Depo>();
                    var Depodakimiktar = depodakiler.Where(a => a.MamülId == mamülid)
                 .Select(a => a.DepoMiktar).DefaultIfEmpty(0).Sum();

                    var DepoMiktarMutlak = Math.Abs(Depodakimiktar);
                    //Üretimdeki x malzemesinin Miktar toplamı
                    var üretimdekimiktar = üretimdekiler.Where(a => a.MamülId == mamülid && a.YarıMamülId == Yarımamül.Id)
                    .Select(a => a.Miktar).DefaultIfEmpty(0).Sum();
                    var üretimMiktarMutlak = Math.Abs(üretimdekimiktar);

                    var yarımamülmiktar = depodakiler.Where(a => a.MamülId == mamülid && a.YarıMamülId == Yarımamül.Id)
                        .Select(a => a.DepoMiktar).DefaultIfEmpty(0).Sum();
                    var yarımamülmiktarMutlak = Math.Abs(üretimdekimiktar);
                    var kod = depobll.YeniKodVer();
                    var KalanDepo = ihtiyaç - üretimMiktarMutlak;
                    var depoId = IslemTuru.EntityInsert.IdOlustur(null);

                    //üretim ekle       (şarjdeğil ve yarımamül)                      (şarj ise)
                    var üretim = (!isŞarj & stok > 0 & istenenmiktar <= stok) | (isŞarj & ihtiyaç > 0 & DepoMiktarMutlak < ihtiyaç) ? new Üretim
                    {
                        Id = depoId,
                        Kod = kod,
                        Miktar = isŞarj ? KalanDepo : istenenmiktar,
                        AşamaTipi = AşamaTipi.YarıMamül,
                        MamülId = mamülid,
                        İşemriId = entity.Id,
                        YarıMamülId = Yarımamül.Id,
                    } : null;

                    //depo yada Şarj düş
                    var depo = DepoMiktarMutlak < ihtiyaç ? new Depo
                    {
                        Id = depoId,
                        Kod = kod,
                        DepoMiktar = -1 * (isŞarj ? KalanDepo : istenenmiktar),
                        DepoTipi = depoTipi,
                        MamülId = mamülid,
                        İşemriId = entity.Id,
                    } : null;

                    //yarımamül ekle
                    var yarımamül = stok > 0 & istenenmiktar <= stok & !isŞarj ? new Depo
                    {
                        Id = depoId + 1,
                        Kod = kod,
                        DepoMiktar = istenenmiktar,
                        DepoTipi = depoTipi,
                        MamülId = mamülid,
                        İşemriId = entity.Id,
                        YarıMamülId = Yarımamül.Id,
                    } : null;
                    if (depo != null)
                        resultdepo.Add(depo);
                    if (yarımamül != null)
                        resultdepo.Add(yarımamül);


                    return (resultdepo, üretim);

                }
                var AksiyonListesi = reçetelist
                    .Where(x => x.YarıMamülId == Yarımamül.Id)
                    .Select(x => KayıtGetir(x.MamülId, DepoTipi.ÜKullanıldı, x.ihtiyaç, x.Stok)).ToList();
                var düşülecekMalzemeler = AksiyonListesi.Where(x => x.depo != null)
                                    .SelectMany(x => x.depo).Cast<BaseEntity>().ToList();
                var üretimdüşülecekmalzemeler = AksiyonListesi.Where(x => x.üretim != null)
                    .Select(x => x.üretim).Cast<BaseEntity>().ToList();

                if (!depobll.Insert(düşülecekMalzemeler) & !üretimbll.Insert(üretimdüşülecekmalzemeler))
                    Msg.HataMesajı("Bu işemrinin Reçetedeki Malzemeleri Malzeme Depodan Düşülemedi");
                else
                {
                    Listele();

                    Tablo_FocusedRowChanged(null, null);
                    tablo.RowFocus("Id", entity.Id);

                }
            }
        }
    }
}