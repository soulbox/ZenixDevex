using System.ComponentModel;
using System.Drawing;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]
    public class myKodText : myTextEdit
    {
        public myKodText()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            Properties.MaxLength = 20;
            StatusBarAciklama = "Kod Giriniz";
        }
    }
}
