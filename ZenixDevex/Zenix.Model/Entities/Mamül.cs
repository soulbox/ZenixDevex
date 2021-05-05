
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Common.Function;
using Zenix.Model.Attributes;
using Zenix.Model.Entities.Base;


namespace Zenix.Model.Entities
{

  
    public interface IBaseMamül
    {
       
        string BirimAlan { get; }
        [NotMapped]
        string BirimAğırlık { get; }
        [NotMapped]
        string BirimAğızÖlçüsü { get; }
        [NotMapped]
        string BirimUzunluk { get; }
        [NotMapped]
        string BirimEn { get; }
        [NotMapped]
        string BirimBoy { get; }
        [NotMapped]
        string BirimYükseklik { get; }
    }

    public class BaseMamül : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        public float AğızÖlçüsü { get; set; }
        public float Uzunluk { get; set; }
        public float En { get; set; }
        public float Boy { get; set; }
        public float Yükseklik { get; set; }
        public BirimTipi BirimAuEbY { get; set; }

        public float Alan { get; set; }
        public BirimTipi AlanınBirimi { get; set; }
        public float Ağırlık { get; set; }
        public BirimTipi AğırlığınBirimi { get; set; }

        [NotMapped]
        public string BirimAlan { get => $"{Alan:n1} {AlanınBirimi.ToName()}"; }
        [NotMapped]
        public string BirimAğırlık { get => $"{Ağırlık:n1} {AğırlığınBirimi.ToName()}"; }
        [NotMapped]
        public string BirimAğızÖlçüsü { get => $"{BirimAğızÖlçüsü:n1} {BirimAuEbY.ToName()}"; }
        [NotMapped]

        public string BirimUzunluk { get => $"{Uzunluk:n1} {BirimAuEbY.ToName()}"; }

        [NotMapped]

        public string BirimEn { get => $"{En:n1} {BirimAuEbY.ToName()}"; }

        [NotMapped]

        public string BirimBoy { get => $"{Boy:n1} {BirimAuEbY.ToName()}"; }

        [NotMapped]

        public string BirimYükseklik { get => $"{Yükseklik:n1} {BirimAuEbY.ToName()}"; }

    }
    public class Mamül : BaseMamül
    {
        [ZorunluAlan("Adı", "txtAdı")]
        public string Adı { get; set; }
        public SarfTipi SarfTipi { get; set; }
        public BirimTipi MalzemeBirimi { get; set; }
        public MalzemeTipi MalzemeTipi { get; set; }
        public int Hacim { get; set; }
        public long AmbalajTipiId { get; set; }
        public AmbalajTipi AmbalajTipi { get; set; }
        public long AmbalajMaddeTipiId { get; set; }
        public AmbalajMaddeTipi AmbalajMaddeTipi { get; set; }
    }
}
