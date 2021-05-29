using Zenix.Common.Enums;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Entities.Base;
using System.Text.RegularExpressions;

namespace Zenix.Model.DTO
{

    public interface IStok
    {
        float Gelen { get; set; }
        float Stok { get; set; }
        float EksikFazla { get; }
    }

    [NotMapped]
    public class SiparişÜrünleriL : SiparişÜrünleri, IBaseHaraketEntity, IÜrün, IBaseÜrünTanıtım, IHacim, IMamül, IStok
    {
        public float Gelen { get; set; }
        public float Stok { get; set; }
        public float EksikFazla { get => Gelen - Miktar; }
        public string Ticariİsim { get; set; }

        public string GTIN { get; set; }
        public long MarkaId { get; set; }
        public long? FirmaId { get; set; }
        public long MamülId { get; set; }
        public int Kutu { get; set; }
        public int Stand { get; set; }
        public int Koli { get; set; }
        public string MamülAdı { get; set; }
        public string FirmaAdi { get; set; }
        public string MarkaAdı { get; set; }
        public int Hacim { get; set; }
        public string AmbalajTipiAdı { get; set; }
        public string AmbalajMaddeAdı { get; set; }
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
        public string BirimAğızÖlçüsü { get; }
        public string BirimUzunluk { get; }
        public string BirimEn { get; }
        public string BirimBoy { get; }
        public string BirimYükseklik { get; }
        public string BirimAlan { get; }
        public string BirimAğırlık { get; }
        public string ÜrünAdı { get => $"{FirmaAdi} - {MarkaAdı } - {MamülAdı }"; }
        public string SiparişFirmaAdı { get; set; }
        public string SiparişKod { get; set; }
        public string SiparişKodFirma { get => $"{SiparişKod}-{ SiparişFirmaAdı?.ToUpper()}"; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
    [NotMapped]
    public class SiparişÜrünleriDepo : SiparişÜrünleri, IBaseÜrünTanıtım, IBaseRevizyon
    {


        public string MarkaAdı { get; set; }
        public string FirmaAdi { get; set; }
        public string MamülAdı { get; set; }
        public string GTIN { get; set; }
        public string Revkodu { get; set; }
        public string SiparişKod { get; set; }
        public DateTime RevizyonTarihi { get; set; }
        public string BaseRevKod { get; set; }
        public float Giden { get; set; }
        public float Stok { get; set; }
        public string ÜrünAdı { get => $"{MarkaAdı }-{MamülAdı }-{Revkodu}"; }
        public string SiparişKodFirma { get => $"{SiparişKod}-{FirmaAdi.ToUpper()}"; }
        public float EksikFazla { get => Giden - Miktar; }
        public string RevKodu { get => BaseRevizyon.GetRevKodu(BaseRevKod, RevizyonTarihi); }
    }
}
