using System.ComponentModel;


namespace Zenix.Common.Enums
{
    public enum AşamaTipi : byte
    {
        [Description("Yok")]
        yok=0,
        [Description("Etiket/İnkjet")]
        Etiketveinkjet,
        [Description("Kapak/Dolum")]
        kapakvedolum,
        [Description("Kutu")]
        kutu,
        [Description("Stand")]
        stand,
        [Description("Fırça")]
        fırça,
        [Description("Sarf")]
        sarf,
        [Description("Koli")]
        koli,
        [Description("Palet")]
        palet,
        [Description("Kapak")]
        kapak,
        [Description("Sergrafi")]
        sergrafi,
        [Description("inkjet")]
        inkjet,
        [Description("Dolum")]
        dolum,
        [Description("Etiket")]
        etiket,
        [Description("Şarj")]
        Şarj,

    }
}
