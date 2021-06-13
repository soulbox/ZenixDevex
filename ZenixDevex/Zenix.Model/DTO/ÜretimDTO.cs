using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Zenix.Model.Entities.Base.Interfaces;
using Zenix.Common.Enums;
namespace Zenix.Model.DTO
{
    [NotMapped]

    public class ÜretimL : Üretim, IBaseÜrünTanıtım, IRevizyon,  IBaseRevizyon,Iİşemri//,IBaseHaraketEntity
    {
        public string Açıklama { get; set; }
        public long ÜrünId { get; set; }
        public string ÜrünAdı { get; set; }
        public string MamülAdı { get; set; }
        public string FirmaAdi { get; set; }
        public string MarkaAdı { get; set; }
        public string GTIN { get; set; }
        public DateTime işemriTarih { get; set; }
        public int ŞarjNo { get; set; }
        public long ReçeteId { get; set; }
        public long KullaniciId { get; set; }
        public int ŞarjMiktarı { get; set; }
        public DateTime SKT { get => işemriTarih.AddYears(5); }
        public string EXP { get => $"EXP:{SKT:MMyyyy}"; }
        public string işemriNo { get => $"{işemriTarih:ddMM}{ŞarjNo:00}{işemriTarih:yy}"; }
        public string MarkaÜrünRev => $"{MarkaAdı}-{ÜrünAdı}-{GTIN}-{RevKodu}";
        public string işemriNoveMarkalıÜrün { get => $"{işemriNo}-{MarkaÜrünRev}"; }     
        public DateTime RevizyonTarihi { get; set; }
        public string BaseRevKod { get; set; }     
        public string RevKodu { get => BaseRevizyon.GetRevKodu(BaseRevKod, RevizyonTarihi); }



    }
}
