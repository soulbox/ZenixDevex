using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Entities;

namespace Zenix.Model.DTO
{
    [NotMapped]
    public class ÜrünL:Ürün
    {
        public string FirmaAdı { get; set; }
    }
}
