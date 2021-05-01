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
    public class Ürün : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        [Required, StringLength(30), ZorunluAlan("Adı", "txtAdı")]
        public string Adı { get; set; }
        [Required, StringLength(14), ZorunluAlan("Adı", "txtGTIN")]
        public string GTIN { get; set; }
        public Firma Firma { get; set; }
        public long FirmaId { get; set; }
        public string Marka { get; set; }


    }

}
