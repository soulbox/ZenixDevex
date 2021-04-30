using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Enums
{
    public enum RaporuKagidaSigdirmaTuru : byte
    {
        [Description("Sütunları Daraltarak Sığdır")]
        SutunlariDaraltarakSigdir = 1,
        [Description("Yazı Boyutunu Küçülterek Sığdır")]
        YaziBoyutunuKuculterekSigdir = 2,
        [Description("İşlem Yapma")]
        islemYapma = 3
    }
}
