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
    public class Depo : BaseEntity
    {
        [Index(name: "IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        public Mamül Mamül { get; set; }
        [Required, ZorunluAlan("Malzeme", "txtMamül")]
        public long MamülId { get; set; }
        public DepoTipi DepoTipi { get; set; }
        public İşemri İşemri { get; set; }
        public long? İşemriId { get; set; }
        public Satınalma Satınalma { get; set; }
        public long? SatınalmaId { get; set; }
        public Ürün Ürün { get; set; }
        public long? ÜrünId { get; set; }
        public Sipariş Sipariş { get; set; }
        public long? SiparişId { get; set; }
        public float DepoMiktar { get; set; }
        public DateTime KayıtTarihi { get; set; } = DateTime.Now;

    }

    public enum DepoTipi : byte
    {
        [Description("Satın Alındı")]
        Satınalma = 0,//+
        [Description("Üretime Gitti")]
        ÜKullanıldı = 10,//-
        [Description("Üretildi")]
        Üretildi = 20,//+
        [Description("Sevkiyat")]
        Sevkiyat = 30,//-

    }
}
