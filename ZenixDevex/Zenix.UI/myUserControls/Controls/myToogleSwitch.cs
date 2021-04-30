using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]
    public class myToogleSwitch : ToggleSwitch, IStatusBarAciklama
    {
        public myToogleSwitch()
        {
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = "Kaydın Kullanım Durumunu Seçiniz.";
    }
}
