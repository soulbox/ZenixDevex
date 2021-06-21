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
    public class Üretim : BaseEntity
    {
        [Index(name: "IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        public long İşemriId { get; set; }
        public İşemri İşemri { get; set; }
        public Mamül Mamül { get; set; }
        public long MamülId { get; set; }
        public float Miktar { get; set; }
        public AşamaTipi AşamaTipi { get; set; }
        public DateTime KayıtTarihi { get; set; } = DateTime.Now;
        public int? YarıMamülId { get; set; }
        public YarıMamül YarıMamül { get; set; }


    }
}
