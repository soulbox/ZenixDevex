using System.ComponentModel;
namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]

    public class myTelNo : myTextEdit
    {
        public myTelNo()
        {
            Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            Properties.Mask.EditMask = @"(\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d?";
            Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            Properties.Mask.UseMaskAsDisplayFormat = true;
            StatusBarAciklama = "Telefon No Giriniz";
            //Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom ;
            //Properties.DisplayFormat.FormatString = "{0:(###)###-####}";
        }
    }
}
