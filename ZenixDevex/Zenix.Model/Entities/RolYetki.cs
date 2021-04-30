using Zenix.Common.Enums;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Model.Entities
{
    public class RolYetki : BaseEntity
    {
        public KartTuru KartTuru { get; set; }
    }
}
