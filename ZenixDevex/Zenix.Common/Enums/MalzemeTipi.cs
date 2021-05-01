﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Enums
{
    public enum MalzemeTipi:byte
    {
        [Description("Kimyasal")]
        Kimyasal,
        [Description("Ambalaj")]
        Ambalaj,
        [Description("Etiket")]
        Etiket,
        [Description("Kapak")]
        Kapak,
        [Description("Sarf")]
        Sarf,
        [Description("Şişe")]
        Şişe,
        [Description("Koli")]
        Koli,
        [Description("Kutu")]
        Kutu,
    }
}