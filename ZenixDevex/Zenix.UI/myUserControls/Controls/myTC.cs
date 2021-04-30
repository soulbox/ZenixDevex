using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.WinUI.myUserControls.Controls
{
    
    [ToolboxItem(true)]
    public   class myTC:myTextEdit
    {
        public myTC()
        {
            Properties.Appearance.BackColor = Color.PaleTurquoise;
            Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            Properties.Mask.UseMaskAsDisplayFormat = true;
            StatusBarAciklama = "11 Haneli TC No Giriniz.";

        }
    }
}
