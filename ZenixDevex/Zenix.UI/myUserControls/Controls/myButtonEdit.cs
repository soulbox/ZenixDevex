//using DevExpress.XtraEditors;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]
    public class myButtonEdit : ButtonEdit, IStatusBarKisayol
    {

        public myButtonEdit()
        {
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;

        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisayol { get; set; } = "F4 :";
        public string StatusBarKisayolAciklama { get; set; } = "Seç";

        #region Events
        private long? _Id;
        [Browsable(false)]
        public long? Id
        {
            get => _Id;
            set
            {
                var oldValue = _Id;
                var newValue = value;
                if (newValue.HasValue && oldValue.HasValue && newValue == oldValue) return;
                _Id = value;
                IdChanged(this, new IdChangedEventArg(oldValue, newValue));
                EnabledChange(this, EventArgs.Empty);
            }
        }

        public event EventHandler<IdChangedEventArg> IdChanged = delegate { };
        public event EventHandler EnabledChange = delegate { };

        #endregion
    }
    public class IdChangedEventArg : EventArgs
    {
        public long? OldValue { get; }
        public long? NewValue { get; }

        public IdChangedEventArg(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
