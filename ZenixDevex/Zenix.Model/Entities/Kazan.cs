
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.Attributes;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{
    public class Kazan : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Index(IsUnique = true)]
        public byte No { get; set; }
        public string Açıklama { get; set; }
    }
}
