using Zenix.Model.Attributes;
using Zenix.Model.Entities.Base;
using Zenix.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Zenix.Model.Entities
{
    public class Malzeme : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(30), ZorunluAlan("Adı", "txtAdı")]
        public string Adı { get; set; }
        public MalzemeTipi MalzemeTipi { get; set; }
        public BirimTipi MalzemeBirimi { get; set; }
        public int Hacim { get; set; }
        public BirimTipi HacimBirimi { get; set; }
        public AmbalajTipi AmbalajTipi { get; set; }
        public AmbalajMaddeTipi AmbalajMaddeTipi { get; set; }

    }


}
