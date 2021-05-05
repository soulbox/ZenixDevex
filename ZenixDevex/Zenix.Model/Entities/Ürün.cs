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
    public interface IÜrün
    {
        string GTIN { get; set; }
        long MarkaId { get; set; }
        long? FirmaId { get; set; }
        long MamülId { get; set; }
        int Kutu { get; set; }
        int Stand { get; set; }
        int Koli { get; set; }

    }
    public class Ürün : BaseEntityDurum, IÜrün
    {
        [Index(name: "IX_Kod")] //, IsUnique = true)]
        public override string Kod { get; set; }
        [Column(), StringLength(14), RegularExpression(@"^\d{14}$", ErrorMessage = "{0} Alanına 14 haneli Sayı Giriniz.")]
        public string GTIN { get; set; }
        public int Kutu { get; set; } = 0;
        public int Stand { get; set; } = 0;
        public int Koli { get; set; } = 0;
        [Required, ZorunluAlan("Marka", "txtMarka")]
        public long MarkaId { get; set; }
        //[Required,ZorunluAlan("Firma","txtFirma")]
        public long? FirmaId { get; set; }
        [Required, ZorunluAlan("Mamül", "txtÜrün")]
        public long MamülId { get; set; }
        public Markalar Marka { get; set; }
        public Firma Firma { get; set; }
        public Mamül Mamül { get; set; }

    }
}
