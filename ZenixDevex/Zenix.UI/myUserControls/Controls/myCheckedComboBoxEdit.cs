using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]
    public class myCheckedComboBoxEdit : CheckedComboBoxEdit, IStatusBarAciklama
    {
        public myCheckedComboBoxEdit()
        {
            Properties.Appearance.BackColor = Color.LightCyan;

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; }
    }
}
