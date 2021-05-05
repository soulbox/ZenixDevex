using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Model.DTO
{
    [NotMapped]
    public class MamülL : Mamül
    {
        public string AmbalajTipiAdı { get; set; }
        public string AmbalajMaddeAdı { get; set; }

    }

}
