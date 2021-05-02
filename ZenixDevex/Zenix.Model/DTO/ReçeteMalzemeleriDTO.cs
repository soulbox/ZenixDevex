using Zenix.Common.Enums;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.DTO
{
    [NotMapped]

    public class ReçeteMalzemeleriS : BaseEntity
    {

        public string Adı { get; set; }
    }



    [NotMapped]

    public class ReçeteMalzemeleriL : ReçeteMalzemeler, IBaseHaraketEntity
    {
        public string MalzemeAdı { get; set; }
        public BirimTipi Birim { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }

    }

}
