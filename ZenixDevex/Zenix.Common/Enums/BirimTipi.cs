using System.ComponentModel;

namespace Zenix.Common.Enums
{
    public enum BirimTipi : byte
    {
        [Description("Yok")]
        yok = 0,
        [Description("gr")]
        gr,
        [Description("kg")]
        kg,
        [Description("ton")]
        ton,
        [Description("mL")]
        mL,
        [Description("Lt")]
        Lt,
        [Description("ad")]   
        ad,
        [Description("mm")]
        mm,
        [Description("cm")]
        cm,
        [Description("dm")]
        dm,
        [Description("m")]
        m,
        [Description("cm²")]
        cm2,
        [Description("m²")]
        m2,
        [Description("cm³")]
        cm3,
        [Description("m³")]
        m3,
    }
}
