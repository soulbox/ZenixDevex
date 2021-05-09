using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Zenix.Common.Enums;

namespace Zenix.Model.DTO
{

    public interface IReçeteAdı
    {
         string ReçeteAdı { get;  }
    }
    [NotMapped]
    public class İşemriS : BaseRevizyon, IBaseÜrünTanıtım, IMamül, IRevizyon, IPersonel, Iİşemri, IBaseReçete,IReçeteAdı
    {

        public string ReçeteAdı => $"{MarkaAdı}-{MamülAdı}-{GTIN}-{RevKodu}";

        public string Açıklama { get; set; }
        public long ÜrünId { get; set; }
        public string MamülAdı { get; set; }
        public string FirmaAdi { get; set; }
        public string MarkaAdı { get; set; }
        public string GTIN { get; set; }
        public SarfTipi SarfTipi { get; set; }
        public BirimTipi MalzemeBirimi { get; set; }
        public MalzemeTipi MalzemeTipi { get; set; }
        public long AmbalajTipiId { get; set; }
        public long AmbalajMaddeTipiId { get; set; }
        public float AğızÖlçüsü { get; set; }
        public float Uzunluk { get; set; }
        public float En { get; set; }
        public float Boy { get; set; }
        public BirimTipi BirimAuEbY { get; set; }
        public float Alan { get; set; }
        public BirimTipi AlanınBirimi { get; set; }
        public float Ağırlık { get; set; }
        public BirimTipi AğırlığınBirimi { get; set; }
        public string BirimAğırlık { get; }
        public string BirimAğızÖlçüsü { get; }
        public string BirimUzunluk { get; }
        public string BirimEn { get; }
        public string BirimBoy { get; }
        public string BirimYükseklik { get; }
        public string BirimAlan { get; }
        public int Hacim { get; set; }
        public string AdSoyad { get; set; }
        public long ReçeteId { get; set; }
        public long KullanıcıId { get; set; }
        public int ŞarjMiktarı { get; set; }
        public int ŞarjNo { get; set; }
        public DateTime işemriTarih { get; set; }
        public string Personel { get => AdSoyad.ToUpper(); }
        public long RevizyonId { get; set; }
        public string AFazıHazırlanış { get; set; }
        public string BFazıHazırlanış { get; set; }
        public string CFazıHazırlanış { get; set; }
        public string DFazıHazırlanış { get; set; }

    }
    [NotMapped]
    public class İşemriL : İşemriS
    {

        [NotMapped]
        public DateTime SKT { get => işemriTarih.AddYears(5); }
        [NotMapped]
        public string EXP { get => $"EXP:{SKT:MMyyyy}"; }
        [NotMapped]
        public string işemriNo { get => $"{işemriTarih:ddMM}{ŞarjNo:00}{işemriTarih:yy}"; }
    }

}
