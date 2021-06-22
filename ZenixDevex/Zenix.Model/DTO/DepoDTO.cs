using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.DTO
{
    [NotMapped]

    public class MalzemeDepoL : Depo, Iİşemri, IBaseRevizyon,IYarıMamülAdı
    {
        public string MamülAdı { get; set; }
        public string SatınAlma { get; set; }
        public string KayıtDurum { get; set; }
        public DateTime SatınAlmaTarihi { get; set; }
        public string SiparişNo { get; set; }

        public string işemriNo { get => $"{işemriTarih:ddMMyy}-{ Revizyon.GetRevNo(BaseRevKod):00}/{ŞarjNo:00}"; }
        public long ReçeteId { get; set; }
        public long KullaniciId { get; set; }
        public int ŞarjMiktarı { get; set; }
        public int ŞarjNo { get; set; }
        public string Açıklama { get; set; }
        public DateTime işemriTarih { get; set; }
        public string ÜrünAdı { get => $"{FirmaAdi} - {MarkaAdı } - {MamülAdı }"; }
        public string FirmaAdi { get; set; }
        public string MarkaAdı { get; set; }
        public string GTIN { get; set; }
        public string SiparişÜrünAdı { get => $"{SiparişFirmaAdi} - {SiparişMarkaAdı } - {MamülAdı }"; }
        public string SiparişFirmaAdi { get; set; }
        public string SiparişMarkaAdı { get; set; }
        public string Ad { get => İşemriId != null ? ÜrünAdı : SiparişÜrünAdı; }


        public string BaseRevKod { get; set; }
        public string RevKodu => BaseRevizyon.GetRevKodu(BaseRevKod, RevizyonTarihi);

        public DateTime RevizyonTarihi { get; set; }
        public string YarıMamülAdı { get ; set ; }
    }
}
