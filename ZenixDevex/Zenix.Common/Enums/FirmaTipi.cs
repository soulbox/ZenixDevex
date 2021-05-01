using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Enums
{
  public   enum FirmaTipi
    {
        [Description("Merkez")]
        Merkez,
        [Description("Müşteri")]
        Müşteri,
        [Description("Taşeron")]
        Taşeron,
    }
}
