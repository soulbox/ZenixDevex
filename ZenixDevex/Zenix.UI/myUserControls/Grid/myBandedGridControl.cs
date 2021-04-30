using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Zenix.WinUI.Interfaces;

namespace Zenix.WinUI.myUserControls.Grid
{


    [ToolboxItem(true)]

    public class myBandedGridControl : GridControl
    {

        protected override BaseView CreateDefaultView()
        {
            var view = (myBandedGridview)CreateView("myBandedGridview");

            view.Appearance.BandPanel.ForeColor = Color.DarkBlue;
            view.Appearance.BandPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            view.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            view.BandPanelRowHeight = 40;

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

            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;

            view.OptionsFind.AlwaysVisible = true;
            view.OptionsFind.FindNullPrompt = "Ara";
            view.OptionsFind.FindDelay = 50;
            view.OptionsFind.ShowFindButton = false;
            view.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;

            var columns = new[]
            {
                new myBandedGridColumn()
                {
                    Caption = "Id",
                    FieldName = "Id",
                    OptionsColumn =
                    {
                        AllowEdit = false,
                        ShowInCustomizationForm = false
                    }
                },
                new myBandedGridColumn()
                {
                    Caption = "Kod",
                    FieldName = "Kod",
                    Visible=true ,
                    OptionsColumn = {AllowEdit = false},
                    AppearanceCell = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center },Options={UseTextOptions=true}}
                },
            };
            var band = new GridBand() { Caption = "myband" };
            columns.ToList().ForEach(x => band.Columns.Add(x));
            view.Bands.Clear();
            view.Bands.AddRange(new[] { band });
            view.Columns.AddRange(columns);
            return view;
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new myBandedGridInfoRegistrator());
        }

        private class myBandedGridInfoRegistrator : BandedGridInfoRegistrator
        {
            public override string ViewName => "myBandedGridview";
            public override BaseView CreateView(GridControl grid) => new myBandedGridview(grid);


        }
    }
    public class myBandedGridview : BandedGridView, IStatusBarKisayol
    {
        public myBandedGridview() { }

        public myBandedGridview(GridControl ownerGrid) : base(ownerGrid)
        {
        }

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
        protected override GridColumnCollection CreateColumnCollection() => new myBandedGridColumnCollection(this);

        private class myBandedGridColumnCollection : BandedGridColumnCollection
        {

            public myBandedGridColumnCollection(ColumnView view) : base(view) { }
            protected override GridColumn CreateColumn() => new myBandedGridColumn { OptionsColumn = { AllowEdit = false } };
        }

        private class myGridColumnCollection : GridColumnCollection
        {
            public myGridColumnCollection(ColumnView view) : base(view) { }
            protected override GridColumn CreateColumn() => new myBandedGridColumn { OptionsColumn = { AllowEdit = false } };

        }
    }




    public class myBandedGridColumn : BandedGridColumn, IStatusBarKisayol
    {

        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}
