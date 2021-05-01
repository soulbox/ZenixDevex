using System.ComponentModel;

namespace Zenix.Common.Enums
{
    public enum AmbalajTipi : byte
    {
        [Description("Varil")]
        Varil,
        [Description("IBC")]
        IBC,
        [Description("Çuval")]
        Çuval,
        [Description("Paket")]
        Paket,
        [Description("Koli")]
        Koli,
        [Description("Palet")]
        Palet,
    }
}
