﻿using System;
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
    public class Firma : BaseEntityDurum
    {
        [Index(name: "IX_Kod")] //, IsUnique = true)]
        public override string Kod { get; set; }
        [Column(), Required(), MaxLength(50), ZorunluAlan("Firma Adı", "txtFirmaAdi")]
        public string FirmaAdi { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
        public string VergiDairesi { get; set; }
        [Column(Order = 12), StringLength(10), RegularExpression(@"^\d{10}$", ErrorMessage = "{0} Alanına 10 Haneli Sayı Giriniz.")]
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public FirmaTipi FirmaTipi { get; set; }
        public ICollection<Ürün> Ürün { get; set; }
        public Ülke Ülke { get; set; }
        [Required(), ZorunluAlan("Ülke", "txtÜlke")]
        public long ÜlkeId { get; set; }

    }
}
