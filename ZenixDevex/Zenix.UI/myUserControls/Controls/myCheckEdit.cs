using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]

    public class myCheckEdit : CheckEdit, IStatusBarAciklama
    {
        public myCheckEdit()
        {
            Properties.Appearance.ForeColor  = Color.Maroon ;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}
