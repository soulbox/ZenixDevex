using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Enums
{
    public enum KrediKartTipi:byte
    {
        [Description("Visa")]
        Visa=1,
        [Description("Master Card")]
        MasterCard=2

    }
}
