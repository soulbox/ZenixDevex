namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    partial class DepoGridTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMamülAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colSatınalma = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMiktar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colTarih = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colTip = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridControl1
            // 
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.Tablo;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(627, 379);
            this.myGridControl1.TabIndex = 5;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Tablo});
            // 
            // Tablo
            // 
            this.Tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.Tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.Tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.Tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.Tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.Tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.Tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.Tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.Tablo.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.Tablo.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMamülAdı,
            this.colSatınalma,
            this.colMiktar,
            this.colTarih,
            this.colTip});
            this.Tablo.GridControl = this.myGridControl1;
            this.Tablo.GroupCount = 1;
            this.Tablo.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DepoMiktar", this.colMiktar, "Stok {0:n0}")});
            this.Tablo.Name = "Tablo";
            this.Tablo.OptionsBehavior.AutoExpandAllGroups = true;
            this.Tablo.OptionsFind.AlwaysVisible = true;
            this.Tablo.OptionsFind.FindDelay = 100;
            this.Tablo.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.Tablo.OptionsFind.FindNullPrompt = "Ara";
            this.Tablo.OptionsFind.ShowFindButton = false;
            this.Tablo.OptionsMenu.EnableColumnMenu = false;
            this.Tablo.OptionsMenu.EnableFooterMenu = false;
            this.Tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.Tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.Tablo.OptionsPrint.AutoWidth = false;
            this.Tablo.OptionsPrint.PrintGroupFooter = false;
            this.Tablo.OptionsView.ColumnAutoWidth = false;
            this.Tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.Tablo.OptionsView.RowAutoHeight = true;
            this.Tablo.OptionsView.ShowAutoFilterRow = true;
            this.Tablo.OptionsView.ShowGroupPanel = false;
            this.Tablo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMamülAdı, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.Tablo.StatusBarAciklama = null;
            this.Tablo.StatusBarKisayol = null;
            this.Tablo.StatusBarKisayolAciklama = null;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisayol = null;
            this.colId.StatusBarKisayolAciklama = null;
            // 
            // colMamülAdı
            // 
            this.colMamülAdı.Caption = "Malzeme";
            this.colMamülAdı.FieldName = "MamülAdı";
            this.colMamülAdı.Name = "colMamülAdı";
            this.colMamülAdı.OptionsColumn.AllowEdit = false;
            this.colMamülAdı.StatusBarAciklama = null;
            this.colMamülAdı.StatusBarKisayol = null;
            this.colMamülAdı.StatusBarKisayolAciklama = null;
            this.colMamülAdı.Visible = true;
            this.colMamülAdı.VisibleIndex = 1;
            // 
            // colSatınalma
            // 
            this.colSatınalma.Caption = "Satın Alma";
            this.colSatınalma.FieldName = "SatınAlma";
            this.colSatınalma.Name = "colSatınalma";
            this.colSatınalma.OptionsColumn.AllowEdit = false;
            this.colSatınalma.StatusBarAciklama = null;
            this.colSatınalma.StatusBarKisayol = null;
            this.colSatınalma.StatusBarKisayolAciklama = null;
            this.colSatınalma.Visible = true;
            this.colSatınalma.VisibleIndex = 0;
            this.colSatınalma.Width = 217;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.FieldName = "DepoMiktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.StatusBarAciklama = null;
            this.colMiktar.StatusBarKisayol = null;
            this.colMiktar.StatusBarKisayolAciklama = null;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 1;
            this.colMiktar.Width = 110;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "KayıtTarihi";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.StatusBarAciklama = null;
            this.colTarih.StatusBarKisayol = null;
            this.colTarih.StatusBarKisayolAciklama = null;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 2;
            this.colTarih.Width = 127;
            // 
            // colTip
            // 
            this.colTip.Caption = "Stok Tipi";
            this.colTip.FieldName = "DepoTipi";
            this.colTip.Name = "colTip";
            this.colTip.OptionsColumn.AllowEdit = false;
            this.colTip.StatusBarAciklama = null;
            this.colTip.StatusBarKisayol = null;
            this.colTip.StatusBarKisayolAciklama = null;
            this.colTip.Visible = true;
            this.colTip.VisibleIndex = 3;
            this.colTip.Width = 131;
            // 
            // DepoGridTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myGridControl1);
            this.Name = "DepoGridTable";
            this.Size = new System.Drawing.Size(627, 379);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Grid.myGridControl myGridControl1;
        private Grid.MyGridColumn colId;
        private Grid.MyGridColumn colMamülAdı;
        private Grid.MyGridColumn colSatınalma;
        private Grid.MyGridColumn colMiktar;
        private Grid.MyGridColumn colTarih;
        private Grid.MyGridColumn colTip;
        public Grid.myGridview Tablo;
    }
}
