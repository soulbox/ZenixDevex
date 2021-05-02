using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Attributes;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{
    public class Reçete : BaseEntity
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        public Revizyon Revizyon { get; set; }
        [ZorunluAlan("Revizyon","txtRevizyon")]
        public long RevizyonId { get; set; }
        public string AFazıHazırlanış { get; set; }
        public string BFazıHazırlanış { get; set; }
        public string CFazıHazırlanış { get; set; }

        public ICollection<ReçeteMalzemeler> ReçeteMalzemeler { get; set; }
    }
}
