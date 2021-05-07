using Zenix.Model.Entities.Base;
using Zenix.Model.Entities.Base.Interfaces;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout.Resizing;
using DevExpress.XtraLayout.Tab;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zenix.WinUI.Functions
{
    public class SelectRowFunctions
    {
        private GridView tablo;
        private GridColumn column;
        private readonly IList<BaseEntity> SelectedRows;
        private RepositoryItemCheckEdit CheckEdit;
        public SelectRowFunctions(GridView table)
        {
            tablo = table;

            SelectedRows = new List<BaseEntity>();
            RemoveEvents();
            AddEvents(table);
        }
        public int SelectedRowCount() =>
             SelectedRows.Count;
        public BaseEntity GetSelectedRow(int index) => SelectedRows[index];
        public IList<BaseEntity> GetSelectedRows() => SelectedRows;
        public int GetSelectedRowIndex(BaseEntity row) => SelectedRows.IndexOf(row);
        public void SelectAll()
        {
            SelectedRows.Clear();
            for (int i = 0; i < tablo.DataRowCount; i++)
                SelectedRows.Add(tablo.GetRow<BaseEntity>(i));
            Update();
        }

        private void Update()
        {
            tablo.BeginUpdate();
            tablo.EndUpdate();
        }

        public void ClearSelection()
        {
            SelectedRows.Clear();
            Update();
        }

        void SelectRow(int rowhandle, bool select)
        {
            if (isRowSelected(rowhandle) == select) return;
            var row = tablo.GetRow<BaseEntity>(rowhandle);
            if (select)
                SelectedRows.Add(row);
            else
                SelectedRows.Remove(row);
            Update();
        }
        public void RowSelection(int rowhandle)
        {
            if (!tablo.IsDataRow(rowhandle)) return;
            SelectRow(rowhandle, !isRowSelected(rowhandle));

        }
        public bool isRowSelected(int rowhandle) => GetSelectedRowIndex(tablo.GetRow<BaseEntity>(rowhandle)) > -1;
        private void AddEvents(GridView table)
        {
            if (tablo == null) return;
            SelectedRows.Clear();
            tablo = table;
            CheckEdit = (RepositoryItemCheckEdit)tablo.GridControl.RepositoryItems.Add("CheckEdit");
            column = tablo.Columns.Add();
            column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            column.Visible = true;
            column.VisibleIndex = 0;
            column.FieldName = "Secim";
            column.Name = "Secim";
            column.Caption = "Seç";
            column.OptionsColumn.ShowCaption = false;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.AllowSize = false;
            column.OptionsColumn.FixedWidth = true;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            column.Width = 35;
            column.ColumnEdit = CheckEdit;
            tablo.FocusedColumn = column;

            //banded grid için
            if (tablo is BandedGridView view)
            {
                var band = view.Bands["BndSeçim"];
                if (band == null)
                {
                    view.Bands.Add(band = new GridBand() {Name= "BndSeçim", Caption = "Seç"});
                }
                band.Visible = true;
                band.VisibleIndex = 0;
                band.Columns.Add((BandedGridColumn)column);
                view.Bands.MoveTo(0, band);
            }
            tablo.Click += Tablo_Click;
            tablo.CustomDrawColumnHeader += Tablo_CustomDrawColumnHeader;
            tablo.CustomUnboundColumnData += Tablo_CustomUnboundColumnData;
            tablo.KeyDown += Tablo_KeyDown;
            tablo.RowStyle += Tablo_RowStyle;

        }
        private void RemoveEvents()
        {
            if (tablo == null) return;
            column?.Dispose();
            if (CheckEdit != null)
            {
                tablo.GridControl.RepositoryItems.Remove(CheckEdit);
                CheckEdit.Dispose();
            }
            tablo.Click -= Tablo_Click;
            tablo.CustomDrawColumnHeader -= Tablo_CustomDrawColumnHeader;
            tablo.CustomUnboundColumnData -= Tablo_CustomUnboundColumnData;
            tablo.KeyDown -= Tablo_KeyDown;
            tablo.RowStyle -= Tablo_RowStyle;
            //tablo = null;
        }
        private void Tablo_Click(object sender, EventArgs e)
        {
            var point = tablo.GridControl.PointToClient(Control.MousePosition);
            var info = tablo.CalcHitInfo(point);
            if (info.Column == column)
            {
                if (info.InColumn)
                {
                    if (SelectedRowCount() == tablo.DataRowCount)
                        ClearSelection();
                    else
                        SelectAll();
                }
                else if (info.InRowCell)
                    RowSelection(info.RowHandle);

            }
            else if (info.InRow)
                RowSelection(info.RowHandle);
        }
        private void Tablo_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != column) return;
            e.Info.InnerElements.Clear();
            e.Painter.DrawObject(e.Info);
            CheckBoxEkle(e.Cache, e.Bounds, SelectedRowCount() == tablo.DataRowCount);
            e.Handled = true;
        }

        private void CheckBoxEkle(GraphicsCache cache, Rectangle r, bool check)
        {
            var info = (CheckEditViewInfo)CheckEdit.CreateViewInfo();
            var painter = (CheckEditPainter)CheckEdit.CreatePainter();
            if (info == null) return;
            info.EditValue = check;
            info.Bounds = r;
            info.CalcViewInfo(cache.Graphics);
            var arg = new ControlGraphicsInfoArgs(info, cache, r);
            painter?.Draw(arg);
        }
        private void Tablo_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column != column) return;
            e.Value = isRowSelected(tablo.GetRowHandle(e.ListSourceRowIndex));
        }
        private void Tablo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;
            RowSelection(tablo.FocusedRowHandle);
        }
        private void Tablo_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (!isRowSelected(e.RowHandle)) return;
            e.Appearance.BackColor = SystemColors.Highlight;
            e.Appearance.ForeColor = SystemColors.HighlightText;


        }








    }
}
