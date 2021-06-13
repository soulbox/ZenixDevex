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
    public interface Iİşemri
    {
        long ReçeteId { get; set; }
        long KullaniciId { get; set; }
        int ŞarjMiktarı { get; set; }
        int ŞarjNo { get; set; }
        string Açıklama { get; set; }
        DateTime işemriTarih { get; set; }

    }
    public class İşemri : BaseEntityDurum,Iİşemri
    {
        [Index(name: "IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        [ZorunluAlan("Reçete", "txtReçete")]
        public long ReçeteId { get; set; }
        public Reçete Reçete { get; set; }
        public DateTime işemriTarih { get; set; } = DateTime.Now;
        public long KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public int ŞarjMiktarı { get; set; }
        public int ŞarjNo { get; set; }
        public string Açıklama { get; set; }

    }
}
