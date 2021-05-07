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
    public interface ISatınAlmaMalzeme
    {
        bool GelenMiktar { get; set; }       
        bool EksikFazla { get; set; }
    }
    public class SatınAlmaMalzemeler : BaseEntityHaraket,ISatınAlmaMalzeme
    {
        public Satınalma Satınalma { get; set; }
        public long SatınalmaId { get; set; }
        public Mamül Mamül { get; set; }
        public long MamülId { get; set; }
        public int Miktar { get; set; }
        [Column(TypeName = "Date")]
        public DateTime TerminTarihi { get; set; } = DateTime.Now;      
        public bool Teslimat { get; set; }
        [NotMapped]
        public bool GelenMiktar { get; set; }
        [NotMapped]
        public bool EksikFazla { get; set; }


    }
}
