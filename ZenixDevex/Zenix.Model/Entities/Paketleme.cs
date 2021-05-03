using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{
    public class Paketleme : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        [Required]
        public AyarTipi AyarTipi { get; set; } = AyarTipi.Diğer;
        [Column(Order = 4)]//, Range(1, 626)]
        public int Kutu { get; set; }
        [Column(Order = 6)]//, Range(1, 100)]
        public int Stand { get; set; }
        [Column(Order = 7)]//, Range(1, 900)]
        public int Koli { get; set; }
        public Markalar Markalar { get; set; }
        public long MarkalarId { get; set; }

        public BirimTipi BirimTipi { get; set; }
        public string Açıklama { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int PalettekiUrun { get => PalettekiKoli * KolidekiShrink * ShrinktekiUrun; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int KolidekiUrun { get => KolidekiShrink * ShrinktekiUrun; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int PalettekiShrink { get => KolidekiShrink * PalettekiKoli; }




        public Paketleme Clone() => (Paketleme)this.MemberwiseClone();
    }

    public enum AyarTipi : byte
    {
        [Description("Normal")]
        Normal = 0,
        [Description("Yeni Tip Koli")]
        YeniTipKoli = 1,
        [Description("İhracat")]
        İhracat = 2,
        [Description("ihracat Yeni Tip Koli")]
        YeniTipİhracat = 3,
        [Description("Diğer")]
        Diğer = 100
    }
}
