using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]
    public class mySpinEdit : SpinEdit, IStatusBarAciklama
    {
        public mySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            Properties.EditMask = "d";
            

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}
