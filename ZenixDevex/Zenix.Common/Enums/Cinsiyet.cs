using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Enums
{
    public enum Cinsiyet:byte
    {
        [Description("Erkek")]
        Erkek = 1,
        [Description("Bayan")]
        Bayan = 2,
        [Description("None")]
        None = 3,
    }


}
