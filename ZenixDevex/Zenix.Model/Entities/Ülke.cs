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
    public class Ülke : BaseEntity
    {
        [Index(name: "IX_Kod")] //, IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(30), ZorunluAlan("Adı", "txtAdı")]
        public string Adı { get; set; }

    }
}
