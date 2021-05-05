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
    public class İşemri : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        [ZorunluAlan("Reçete", "txtReçete")]
        public long ReçeteId { get; set; }
        public Reçete Reçete { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
        public long KullanıcıId { get; set; }
        public Kullanici Kullanici { get; set; }
        public int ŞarzMiktarı { get; set; }
        public long KazanId { get; set; }
        public Kazan Kazan { get; set; }



    }
}
