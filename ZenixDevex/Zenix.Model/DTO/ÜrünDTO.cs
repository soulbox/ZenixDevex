using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.Entities;

namespace Zenix.Model.DTO
{


    [NotMapped]
    public class ÜrünS : Ürün
    {
        public string MamülAdı { get; set; }
        public string FirmaAdi { get; set; }
        public string MarkaAdı { get; set; }
    }

        [NotMapped]
    public class ÜrünL : BaseMamül, IÜrün, IMamülDTO, IFirma, IMarka
    {
       
        public string AmbalajTipiAdı { get; set; }
        public string AmbalajMaddeAdı { get; set; }       
        public string MamülAdı { get; set; }
        public string FirmaAdi { get; set; }
        public string MarkaAdı { get; set; }
        public SarfTipi SarfTipi { get; set; }
        public BirimTipi MalzemeBirimi { get; set; }
        public MalzemeTipi MalzemeTipi { get; set; }
        public int Hacim { get; set; }
        public long AmbalajTipiId { get; set; }
        public long AmbalajMaddeTipiId { get; set; }
        public string GTIN { get; set; }
        public long MarkaId { get; set; }
        public long? FirmaId { get; set; }
        public long MamülId { get; set; }
        public int Kutu { get; set; }
        public int Stand { get; set; }
        public int Koli { get; set; }

    }
}
