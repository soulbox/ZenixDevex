using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Enums
{
    public enum ParaBirimi : byte
    {
        [Description("₺")]
        TL = 0,
        [Description("$")]
        Dolar,
        [Description("€")]
        Euro,

    }
}
