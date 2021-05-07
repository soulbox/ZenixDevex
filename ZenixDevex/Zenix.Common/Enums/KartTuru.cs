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
        [Description("Ürün Kartı")]
        Ürün = 7,
        [Description("Revizyon Kartı")]
        Revizyon = 8,
        [Description("Şarj Kartı")]
        Şarj = 9,
        [Description("Paket Kartı")]
        Paketleme = 10,
        [Description("Sipariş Kartı")]
        Sipariş = 11,
        [Description("Mamül Kartı")]
        Mamül = 12,
        [Description("Reçete Kartı")]
        Reçete = 13,
        [Description("Kazan Kartı")]
        Kazan = 14,
        [Description("İşemri Kartı")]
        İşemri = 15,
        [Description("Marka Kartı")]
        Markalar = 16,
        [Description("Ambalaj Kartı")]
        AmbalajTipi = 17,
        [Description("Ambalaj Madde Kartı")]
        AmbalajMaddeTipi = 18,
        [Description("Firma Tipi Kartı")]
        FirmaTipi = 19,
        [Description("Satın Alma  Kartı")]
        SatınAlma = 20,

    }
}
