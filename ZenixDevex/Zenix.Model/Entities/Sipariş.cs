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
    public class Sipariş : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        public Firma Firma { get; set; }
        [Required ,ZorunluAlan("Firma","txtFirma")]
        public long FirmaId { get; set; }
        public Kullanici Kullanıcı { get; set; }
        public long KullanıcıId { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
        public string Açıklama { get; set; }
        public ICollection<SiparişÜrünleri > SiparişÜrünleri { get; set; }

    }
}
