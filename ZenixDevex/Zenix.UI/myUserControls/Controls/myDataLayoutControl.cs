using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using System.ComponentModel;
using System.Drawing;

namespace Zenix.WinUI.myUserControls.Controls
{
    [ToolboxItem(true)]

    public class myDataLayoutControl : DataLayoutControl
    {
        public myDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false;

        }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new myLayoutControlImplementor(this);
        }
    }

    internal class myLayoutControlImplementor : LayoutControlImplementor
    {
        public myLayoutControlImplementor(ILayoutControlOwner controlOwner) : base(controlOwner)
        {

        }
        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item = base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
            return item;
        }
        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var grp = base.CreateLayoutGroup(parent);
            grp.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;

            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = System.Windows.Forms.SizeType.Absolute;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;

            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = System.Windows.Forms.SizeType.Percent;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = System.Windows.Forms.SizeType.Absolute, Width = 90 });

            grp.OptionsTableLayoutGroup.RowDefinitions.Clear();
            for (int i = 0; i < 9; i++)
            {
                if (i + 1 == 9)
                {
                    grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition { Height = 100, SizeType = System.Windows.Forms.SizeType.Percent  });
                }
                else
                {
                    grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition { Height = 24, SizeType = System.Windows.Forms.SizeType.Absolute });
                }

            }

            return grp;
        }
    }
}
