using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Enums
{
  public  enum DosyaFormatları:byte
    {
        [Description(".pdf")]
        pdf,
        [Description(".jpg")]
        jpg,
        [Description(".jpeg")]
        jpeg,
        [Description(".png")]
        png,
        [Description(".bmp")]
        bmp,
        [Description(".gif")]
        gif,

    }
}
