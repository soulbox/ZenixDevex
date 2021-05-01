using System.ComponentModel;

namespace Zenix.Common.Enums
{
    public enum KartTuru : byte
    {

        [Description("Filitre Kartı")]
        Filtre = 1,
        [Description("Kullanıcı Kartı")]
        Kullanıcı = 2,     
        [Description("Rol Kartı")]
        Rol = 3,
        [Description("Yetki Kartı")]
        Yetki = 4,
        [Description("Firma Kartı")]
        Firma = 5,
        [Description("Ülke Kartı")]
        Ülke = 6,

    }
}
