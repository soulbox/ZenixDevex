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
        public Ürün Ürün { get; set; }
        [Required(),ZorunluAlan("Ürün","txtÜrün")]
        public long ÜrünId { get; set; }
        public Kullanici Kullanıcı { get; set; }
        public long KullanıcıId { get; set; }
        public int Miktar { get; set; }
        public BirimTipi BirimTipi { get; set; }
        public DateTime Tarih { get; set; }
        public string Açıklama { get; set; }



    }
}
