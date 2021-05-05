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
using Zenix.Model.Entities.Base.Interfaces;

namespace Zenix.Model.Entities
{
    public interface IMarka
    {
        string MarkaAdı { get; set; }
    }
    public class Markalar : BaseEntityDurum, IMarka
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [ZorunluAlan("Marka Adı", "txtMarkaAdı")]
        public string MarkaAdı { get; set; }

    }
}
