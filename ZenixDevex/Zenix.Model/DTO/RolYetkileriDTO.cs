using Zenix.Common.Enums;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Model.DTO
{
    [NotMapped ]
    public class RolYetkileriL : RolYetkileri, IBaseHaraketEntity
    {

        //public KartTuru KartTuru  { get; set; }

        public bool Insert { get; set; }
        public bool Update { get ; set ; }
        public bool Delete { get ; set ; }
    }
}
