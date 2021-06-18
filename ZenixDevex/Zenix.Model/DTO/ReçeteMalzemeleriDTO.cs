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

    public class ReçeteMalzemeleriL : ReçeteMalzemeler, IBaseHaraketEntity, IMamül, IPaket,IBaseReçete ,IYarıMamülAdı
    {
        public string HacimliMalzemeAdı { get; set; }
        public BirimTipi HacimliMalzemeBirimi { get; set; }

        public float ihtiyaç { get => MalzemeTipi == MalzemeTipi.Esans | MalzemeTipi == MalzemeTipi.HamMadde ? Miktar * ŞarjMiktarı / KimyasalOran : ŞarjMiktarı / Hacim * 1000 / MalzemeİçiÜrün; }
        public float ReçeteMiktar { get => MalzemeTipi == MalzemeTipi.Esans | MalzemeTipi == MalzemeTipi.HamMadde ? Miktar : KimyasalOran / Hacim * 1000 / MalzemeİçiÜrün; }
        public float Stok { get; set; }
        //set et
        public float ŞarjMiktarı { get; set; }
        public int Hacim { get; set; }
        public float KimyasalOran { get; set; }
        //
        public string Açıklama { get; set; }
        public string Hazırlanış { get => FazTipi == FazTipi.AFazı ? AFazıHazırlanış : FazTipi == FazTipi.BFazı ? BFazıHazırlanış : FazTipi == FazTipi.CFazı ? CFazıHazırlanış : FazTipi == FazTipi.EFazı ? EFazıHazırlanış : default; }
        public string AFazıHazırlanış { get; set; }
        public string BFazıHazırlanış { get; set; }
        public string CFazıHazırlanış { get; set; }
        public string DFazıHazırlanış { get; set; }
        public string EFazıHazırlanış { get; set; }
        public long RevizyonId { get; set; }


        public int Kutu { get; set; }
        public int Stand { get; set; }
        public int Koli { get; set; }
        public string Ticariİsim { get; set; }

        public string MamülAdı { get; set; }
        public BirimTipi MalzemeBirimi { get; set; }
        public MalzemeTipi MalzemeTipi { get; set; }
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
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public long PaketŞekliId { get ; set ; }
        public string AmbalajTipi { get ; set ; }
        public string Renk { get ; set ; }
        public string YarıMamülAdı { get ; set; }
    }

}
