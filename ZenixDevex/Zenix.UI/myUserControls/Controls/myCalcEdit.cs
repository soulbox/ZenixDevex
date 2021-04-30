using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]
    public class myCalcEdit : CalcEdit, IStatusBarKisayol
    {
        public myCalcEdit()
        {
            Properties.Appearance.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            Properties.EditMask = "n2";
            Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            Properties.DisplayFormat.FormatString = "n2";


        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; } = "Hesap Makinesi";
    }
}
