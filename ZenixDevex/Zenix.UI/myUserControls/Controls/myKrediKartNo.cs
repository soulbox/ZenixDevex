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
    public class myKrediKartNo:myTextEdit
    {
        public myKrediKartNo()
        {
            Properties.Appearance.BackColor = Color.SteelBlue  ;
            Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d?";
            Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            Properties.Mask.UseMaskAsDisplayFormat = true;
            StatusBarAciklama = "Kredi Kartı No Giriniz";
        }
    }
}
