using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{
    public class YarıMamül : BaseEntityHaraket
    {
        public YarıMamülGrup YarıMamülGrup { get; set; }
        public long YarıMamülGrupId { get; set; }
        public long ÜrünId { get; set; }
        public Ürün Ürün { get; set; }

    }
}
