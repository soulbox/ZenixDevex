using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]

    public class mySimpleButton : SimpleButton, IStatusBarAciklama
    {
        public mySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;

        }

        public string StatusBarAciklama { get; set; }
    }
}
