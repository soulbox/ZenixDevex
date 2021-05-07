using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class Satınalma : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        public Firma Firma { get; set; }
        [Required, ZorunluAlan("Firma", "txtFirma")]
        public long FirmaId { get; set; }
        public long KullanıcıId { get; set; }
        public Kullanici Kullanıcı { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Tarih { get; set; } = DateTime.Now;

        public ICollection<SatınAlmaMalzemeler > SatınAlmaMalzemeler { get; set; }

    }
}
