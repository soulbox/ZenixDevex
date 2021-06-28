using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.Model.DTO;
using Zenix.BLL.General;
using Zenix.WinUI.Functions;
using Zenix.Common.Messages;
using Zenix.Model.Entities;
using Zenix.Common.Enums;
using Zenix.Model.Entities.Base;

namespace Zenix.WinUI.Forms.ÜretimFormu
{
    public partial class YarıMamüldenÜretimEditForm : BaseEditForm
    {
        public İşemriL İşemri { get; set; }
        public List<ReçeteMalzemeleriL> Reçetelistesi { get; set; }
        public YarıMamüldenÜretimEditForm(İşemriL işemri, List<ReçeteMalzemeleriL> reçetelist)
        {
            InitializeComponent();
            İşemri = işemri;
            Reçetelistesi = reçetelist;
            this.DataLayoutControl = myDataLayoutControl1;
            this.KartTuru = Common.Enums.KartTuru.Üretim;
            OldEntity = new Model.Entities.Base.BaseEntity() { Id = 1 };
            CurrentEntity = new Model.Entities.Base.BaseEntity { Id = 2 };
            EventsLoad();
            ShowHideButtons(false, btnYeni, btnGeriAl, btnSil);
        }

        protected internal override void Yukle()
        {
            var hacimlimalzeme = Reçetelistesi.FirstOrDefault();
            Tablo.ViewCaption = hacimlimalzeme == null ? "Reçetesi" : $"Reçete-{hacimlimalzeme.HacimliMalzemeAdı}-Hacim:{hacimlimalzeme.Hacim}";

            var yarımamüllist = Reçetelistesi.Where(x => x.YarıMamülId != null)
                .Where(x => !x.YarıMamülAdı.Equals("Şarj"))
                .GroupBy(x => x.YarıMamülId)
                .Select(x => x.FirstOrDefault())
                .Select(x => new YarıMamülÜretim()
                {
                    MamülId = x.MamülId,
                    MamülAdı = x.MamülAdı,
                    Stok = x.Stok,
                    YarıMamülAdı = x.YarıMamülAdı,
                    YarıMamülStok = x.YarıMamülStok,
                    YarıMamülId = x.YarıMamülId,
                }).ToList();

            var sarflist = Reçetelistesi.Where(x => x.YarıMamülId == null)
                .Select(x => new YarıMamülÜretim()
                {
                    MamülId = x.MamülId,
                    MamülAdı = x.MamülAdı,
                    Stok = x.Stok,
                    YarıMamülAdı = x.YarıMamülAdı,
                    YarıMamülStok = x.YarıMamülStok,
                    YarıMamülId = x.YarıMamülId,
                }).ToList();
            yarımamüllist.AddRange(sarflist);
            yarımamüllist.Add(new YarıMamülÜretim
            {
                MamülId = İşemri.MamülId,
                ÜrünId = İşemri.ÜrünId,
                MamülAdı = İşemri.ReçeteAdı
            });
            using (var depobll = new DepoBll())
            {
                var depostoklist = depobll.StokVer(yarımamüllist.Select(x => x.MamülId).ToList(), İşemri.Id);

                yarımamüllist = yarımamüllist.Select(x =>
                  {
                      x.ÜretimStok = depostoklist.FirstOrDefault(a => a.Item1  == x.MamülId).Item2 ;
                      return x;
                  }).ToList();
            }
            Tablo.GridControl.DataSource = yarımamüllist.ToBindingList();


        }
        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }
        protected override bool Kaydet(bool kapanis)
        {
            var list = Tablo.DataController.ListSource.Cast<YarıMamülÜretim>().ToList();
            var ürünmiktar = txtÜrünMiktar.EditValue.ConvertTo<float>();
            if (ürünmiktar < 1)
            {
                Msg.HataMesajı("Ürün Miktarı 0 olamaz");
                return false;
            }
            if (list.Any(a => a.Stok < a.Miktar))
            {
                Msg.HataMesajı("Yetersiz Stok");
                return false;
            }
            if (Msg.HayirSeciliEvetHayir("Tablodaki Verilere Göre Stok işlemleri Yapılacak. Onaylıyormusunuz?", "Onay") != DialogResult.Yes) return false;

            using (var depobll = new DepoBll())
            using (var üretimbll = new ÜretimBll())
            {

                (List<Depo> depo, Üretim üretim) KayıtGetir(YarıMamülÜretim yarmam)
                {
                    List<Depo> resultdepo = new List<Depo>();
                    var depoId = IslemTuru.EntityInsert.IdOlustur(null);
                    var kod = depobll.YeniKodVer();
                    var isürün = yarmam.isÜrün;
                    //Üretimden Yarımamül Düş Yada Üretim Ekle

                    var üretim = isürün | yarmam.isYarıMamül ? new Üretim
                    {
                        Id = depoId,
                        Kod = kod,
                        Miktar = (isürün ? 1 : -1) * yarmam.Miktar,
                        AşamaTipi = isürün ? AşamaTipi.Üretim : AşamaTipi.YarımamülÜretim,
                        MamülId = yarmam.MamülId,
                        İşemriId = İşemri.Id,
                        YarıMamülId = !isürün ? yarmam.YarıMamülId : default,


                    } : null;
                    //Depo Sarf Düş yada Ürün Ekle
                    var depo = isürün | !yarmam.isYarıMamül ? new Depo
                    {
                        Id = depoId,
                        Kod = kod,
                        DepoMiktar = (isürün ? 1 : -1) * yarmam.Miktar,
                        DepoTipi = isürün ? DepoTipi.Üretildi : DepoTipi.ÜKullanıldı,
                        MamülId = yarmam.MamülId,
                        İşemriId = İşemri.Id,
                        ÜrünId = isürün ? İşemri.ÜrünId : default
                    } : null;


                    //Depo YarıMamül Düş
                    var yarımamül = !isürün & yarmam.isYarıMamül ? new Depo
                    {
                        Id = depoId + 1,
                        Kod = kod,
                        DepoMiktar = -1 * yarmam.Miktar,
                        DepoTipi = DepoTipi.ÜKullanıldı,
                        MamülId = yarmam.MamülId,
                        İşemriId = İşemri.Id,
                        YarıMamülId = yarmam.YarıMamülId,
                    } : null;



                    if (depo != null)
                        resultdepo.Add(depo);
                    if (yarımamül != null)
                        resultdepo.Add(yarımamül);
                    return (resultdepo, üretim);
                }
                bool isşarj(string deger) => !string.IsNullOrEmpty(deger) && deger.Equals("Şarj");

                var listmerge = Reçetelistesi
                    .Where(x => !isşarj(x.YarıMamülAdı))
                    .Select(x => new
                    {
                        Reçete = new YarıMamülÜretim()
                        {
                            MamülId = x.MamülId,
                            MamülAdı = x.MamülAdı,
                            Stok = x.Stok,
                            YarıMamülAdı = x.YarıMamülAdı,
                            YarıMamülStok = x.YarıMamülStok,
                            YarıMamülId = x.YarıMamülId,
                            Miktar = list.FirstOrDefault(a => a.YarıMamülId.HasValue ? a.YarıMamülId == x.YarıMamülId : a.MamülId == x.MamülId).Miktar
                        }
                    }
                ).ToList();
                var AksiyonListesi = listmerge
                    .Where(x => x.Reçete.Miktar > 0)
                    .Select(x => KayıtGetir(x.Reçete)).ToList();
                var düşülecekMalzemeler = AksiyonListesi.Where(x => x.depo != null)
                    .SelectMany(x => x.depo).Cast<BaseEntity>().ToList();
                var üretimdüşülecekmalzemeler = AksiyonListesi.Where(x => x.üretim != null)
                    .Select(x => x.üretim).Cast<BaseEntity>().ToList();


                if (!depobll.Insert(düşülecekMalzemeler) & !üretimbll.Insert(üretimdüşülecekmalzemeler))
                {
                    Msg.HataMesajı("Bu işemrinin Reçetedeki Malzemeleri Malzeme Depodan Düşülemedi");
                    return false;

                }
                else
                {
                    Close();
                    return true;
                }

            }
        }

        protected override void EditValueChanged(object sender, EventArgs e)
        {
            if (sender == txtKoli | sender == txtKoliiçi)
                txtÜrünMiktar.EditValue = txtKoli.EditValue.ConvertTo<float>() * txtKoliiçi.EditValue.ConvertTo<float>();

        }
    }
}