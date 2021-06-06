
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
    public interface IMamülAdı
    {
        string MamülAdı { get; set; }
    }
    public interface IHacim
    {

        int Hacim { get; set; }
    }

    public interface IMamül : IBaseMamül, IMamülAdı
    {
        BirimTipi MalzemeBirimi { get; set; }
        MalzemeTipi MalzemeTipi { get; set; }
        long PaketŞekliId { get; set; }
        long AmbalajMaddeTipiId { get; set; }
        [StringLength(50)]
        string AmbalajTipi { get; set; }
        [StringLength(20)]
        string Renk { get; set; }
    }
    public interface IBaseMamül : IHacim
    {
        float AğızÖlçüsü { get; set; }
        float Uzunluk { get; set; }
        float En { get; set; }
        float Boy { get; set; }
        string BirimAğırlık { get; }
        //[StringLength(100)]
        string Ticariİsim { get; set; }
        BirimTipi BirimAuEbY { get; set; }
        float Alan { get; set; }
        BirimTipi AlanınBirimi { get; set; }
        float Ağırlık { get; set; }
        BirimTipi AğırlığınBirimi { get; set; }
        [NotMapped, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        string BirimAğızÖlçüsü { get; }
        [NotMapped, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        string BirimUzunluk { get; }
        [NotMapped, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        string BirimEn { get; }
        [NotMapped, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        string BirimBoy { get; }
        [NotMapped, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        string BirimYükseklik { get; }
        [NotMapped, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        string BirimAlan { get; }

    }


    public class BaseMamül : BaseEntityDurum, IBaseMamül
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        public int Hacim { get; set; }
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
        public static string GetStr(BirimTipi birm, float value) => birm == BirimTipi.yok ? $"{value:n2}" : $"{value:n1} {birm.ToName()}";
        public string GetStr(float value) => GetStr(BirimAuEbY, value);
        public string BirimAlan { get => GetStr(AlanınBirimi, Alan); }
        public string BirimAğırlık { get => GetStr(AğırlığınBirimi, Ağırlık); }
        public string BirimAğızÖlçüsü { get => GetStr(AğızÖlçüsü); }
        public string BirimUzunluk { get => GetStr(Uzunluk); }
        public string BirimEn { get => GetStr(En); }
        public string BirimBoy { get => GetStr(Boy); }
        public string BirimYükseklik { get => GetStr(Yükseklik); }
        public string Ticariİsim { get; set; }
    }


    public class Mamül : BaseMamül, IMamül
    {
        [ZorunluAlan("Mamül Adı", "txtMamülAdı")]
        public string MamülAdı { get; set; }
        public BirimTipi MalzemeBirimi { get; set; }
        public MalzemeTipi MalzemeTipi { get; set; }
        [Required(), ZorunluAlan("Ambalaj Tipi", "txtAmbalajTipi")]
        public long PaketŞekliId { get; set; }
        public AmbalajTipi PaketŞekli { get; set; }
        [Required(), ZorunluAlan("Ambalaj Maddesinin Tipi", "txtAmbalajMaddesi")]
        public long AmbalajMaddeTipiId { get; set; }
        public AmbalajMaddeTipi AmbalajMaddeTipi { get; set; }
        public ICollection<Depo> Depo { get; set; }
        public string AmbalajTipi { get ; set ; }
        public string Renk { get ; set ; }
    }
}
