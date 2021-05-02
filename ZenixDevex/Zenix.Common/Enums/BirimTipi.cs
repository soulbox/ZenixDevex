using System.ComponentModel;

namespace Zenix.Common.Enums
{
    public enum BirimTipi : byte
    {
        [Description("yok")]
        yok=0,
        [Description("kg")]
        kg=1,
        [Description("mL")]
        mL=2,
        [Description("Etiket")]
        Etiket=3,
        [Description("Kapak")]
        Kapak=4,
        [Description("Sarf")]
        Sarf=5,
        [Description("Şişe")]
        Şişe=6,
        [Description("Koli")]
        Koli=7,
        [Description("Kutu")]
        Kutu=8,
        [Description("cm")]
        cm = 9,
        [Description("mm")]
        mm = 10,
    }
}
