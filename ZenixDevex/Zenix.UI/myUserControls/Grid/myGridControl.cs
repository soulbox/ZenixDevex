using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Drawing;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Grid
{

    [ToolboxItem(true)]

    public class myGridControl : GridControl
    {


        protected override BaseView CreateDefaultView()
        {
            var view = (myGridview)CreateView("myGridview");

            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            view.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            view.OptionsPrint.PrintFooter = true;
            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;

            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = true;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;

            view.OptionsFind.AlwaysVisible = true;
            view.OptionsFind.FindNullPrompt = "Ara";
            view.OptionsFind.FindDelay = 50;
            view.OptionsFind.ShowFindButton = false;
            view.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;

            var columns = new[]
            {
                new MyGridColumn ()
                {
                    Caption = "Id",
                    FieldName = "Id",
                    OptionsColumn =
                    {
                        AllowEdit = false,
                        ShowInCustomizationForm = false
                    }
                },
                new MyGridColumn()
                {
                    Caption = "Kod",
                    FieldName = "Kod",
                    Visible=true ,
                    OptionsColumn = {AllowEdit = false},
                    AppearanceCell = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center },Options={UseTextOptions=true}}
                },
            };
            view.Columns.AddRange(columns);
            return view;
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new myGridInfoRegistrator());
        }

        private class myGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName => "myGridview";
            public override BaseView CreateView(GridControl grid) => new myGridview(grid);


        }
    }
    public class myGridview : GridView, IStatusBarKisayol
    {
        public myGridview() { }
        public myGridview(GridControl ownerGrid) : base(ownerGrid) { }

        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);
            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;

            }
        }
        protected override GridColumnCollection CreateColumnCollection()
        {

            return new MyGridColumnCollection(this) { };
        }

    }

    internal class MyGridColumnCollection : GridColumnCollection
    {
        public MyGridColumnCollection(ColumnView view) : base(view) { }
        protected override GridColumn CreateColumn()
        {
            var column = new MyGridColumn();
            column.OptionsColumn.AllowEdit = false;
            return column;
        }
    }

    public class MyGridColumn : GridColumn, IStatusBarKisayol
    {

        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}