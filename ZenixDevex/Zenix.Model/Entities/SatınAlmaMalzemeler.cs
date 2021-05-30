using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Common.Function;
using Zenix.Model.DTO;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{

    public class SatınAlmaMalzemeler : BaseEntityHaraket
    {
        public Satınalma Satınalma { get; set; }
        public long SatınalmaId { get; set; }
        public Mamül Mamül { get; set; }
        public long MamülId { get; set; }
        public int Miktar { get; set; }
        [Column(TypeName = "Date")]
        public DateTime TerminTarihi { get; set; } = DateTime.Now;
        public bool Teslimat { get; set; }
        public float BirimFiyat { get; set; }
        public ParaBirimi ParaBirimi { get; set; } = ParaBirimi.TL;
        [NotMapped]
        public string Tutar { get => string.Format("{0:n2}" + $"{ParaBirimi.ToName()}", Miktar * BirimFiyat); }


    }
}
