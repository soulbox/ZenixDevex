using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Controls
{
    public class myComboBoxEdit : ComboBoxEdit, IStatusBarKisayol 
    {
        [ToolboxItem(true)]

        public myComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; } = "Seç";

    }
}
