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
    public class SatınAlmaMalzemeleriL : SatınAlmaMalzemeler, IMamül, IBaseHaraketEntity
    {
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public string MamülAdı { get; set; }
        public SarfTipi SarfTipi { get; set; }
        public BirimTipi MalzemeBirimi { get; set; }
        public MalzemeTipi MalzemeTipi { get; set; }
        public long AmbalajTipiId { get; set; }
        public long AmbalajMaddeTipiId { get; set; }
        public float AğızÖlçüsü { get; set; }
        public float Uzunluk { get; set; }
        public float En { get; set; }
        public float Boy { get; set; }
        public int Hacim { get; set; }
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
    }
    [NotMapped]
    public class SatınAlmaMalzemeleriDepo : SatınAlmaMalzemeler, IMamülAdı, IFirma
    {
        public string SatınAlmaKod { get; set; }
        public string MamülAdı { get; set; }
        public string FirmaAdi { get; set; }
        public string SatınAlmaKodFirma { get => $"{SatınAlmaKod}-{FirmaAdi.ToUpper()}"; }
        public float Gelen { get; set; }
        public float Stok { get; set; }
        public float EksikFazla { get => Gelen- Miktar  ; }

    }
}
