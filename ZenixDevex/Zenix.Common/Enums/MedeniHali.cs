using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Enums
{
    public enum MedeniHali:byte
    {
        [Description("Bekar") ]
        Bekar=1,
        [Description("Evli")]
        Evli = 2,
        [Description("Dul")]
        Dul = 3,
        [Description("Boşanmış")]
        Bosanmis = 4,
        [Description("None")]
        None = 5,
    }
}
