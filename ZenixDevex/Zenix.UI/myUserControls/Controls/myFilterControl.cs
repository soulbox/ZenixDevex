using DevExpress.XtraEditors;
using System.ComponentModel;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]

    public class myFilterControl : FilterControl, IStatusBarAciklama
    {
        public myFilterControl()
        {
            ShowGroupCommandsIcon = true;

        }

        public string StatusBarAciklama { get; set; } = "Filitre Metni Giriniz.";
    }
}
