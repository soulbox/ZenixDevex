using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.DTO
{
    [NotMapped]

    public class MalzemeDepoL:Depo
    {
        public string MamülAdı { get; set; }
        public string  SatınAlma { get; set; }
        public DateTime SatınAlmaTarihi { get; set; } 


    }
}
