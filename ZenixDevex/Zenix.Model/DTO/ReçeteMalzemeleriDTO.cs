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

namespace Zenix.Model.DTO
{




    [NotMapped]

    public class ReçeteMalzemeleriL : ReçeteMalzemeler, IBaseHaraketEntity, IMamül,IPaket
    {
        public int Hacim { get ; set ; }
        public int Kutu { get; set; }
        public int Stand { get; set; }
        public int Koli { get; set; }      

        public string MamülAdı { get ; set ; }
        public SarfTipi SarfTipi { get ; set ; }
        public BirimTipi MalzemeBirimi { get ; set ; }
        public MalzemeTipi MalzemeTipi { get ; set ; }
        public long AmbalajTipiId { get ; set ; }
        public long AmbalajMaddeTipiId { get ; set ; }
        public float AğızÖlçüsü { get ; set ; }
        public float Uzunluk { get ; set ; }
        public float En { get ; set ; }
        public float Boy { get ; set ; }
        public BirimTipi BirimAuEbY { get ; set ; }
        public float Alan { get ; set ; }
        public BirimTipi AlanınBirimi { get ; set ; }
        public float Ağırlık { get ; set ; }
        public BirimTipi AğırlığınBirimi { get ; set ; }
        public string BirimAğırlık { get; }
        public string BirimAğızÖlçüsü { get; }
        public string BirimUzunluk { get; }
        public string BirimEn { get; }
        public string BirimBoy { get; }
        public string BirimYükseklik { get; }
        public string BirimAlan { get; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }

    }

}
