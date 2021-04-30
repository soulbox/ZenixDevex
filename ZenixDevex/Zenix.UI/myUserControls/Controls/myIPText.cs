using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]
    public class myIPText : myTextEdit
    {
        public myIPText():base()
        {
            string byteMask = @"(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(25[0-5]))";
            string ipMask = byteMask + @"\." + byteMask + @"\." + byteMask + @"\." + byteMask;
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            Properties.Mask.EditMask = ipMask;
            StatusBarAciklama = "IP Adresi Giriniz.";
            Text = "127.0.0.1";
        }
    }
}
