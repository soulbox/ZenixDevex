namespace Zenix.WinUI.Forms.MarkalarFormu
{
    partial class MarkalarListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkalarListForm));
            this.Grid = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colmarkaadı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colÜrünAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colFirma = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colGTN = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAçıklama = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 109);
            this.Grid.MainView = this.Tablo;
            this.Grid.MenuManager = this.ribbonControl;
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(952, 357);
            this.Grid.TabIndex = 5;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKod,
            this.colmarkaadı,
            this.colÜrünAdı,
            this.colFirma,
            this.colMTipi,
            this.colGTN,
            this.colAçıklama});
            this.Tablo.GridControl = this.Grid;
            this.Tablo.GroupCount = 1;
            this.Tablo.Name = "Tablo";
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
            this.Tablo.OptionsView.ShowViewCaption = true;
            this.Tablo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colmarkaadı, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisayol = null;
            this.colKod.StatusBarKisayolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 108;
            // 
            // colmarkaadı
            // 
            this.colmarkaadı.Caption = "Marka Adı";
            this.colmarkaadı.FieldName = "Adı";
            this.colmarkaadı.Name = "colmarkaadı";
            this.colmarkaadı.OptionsColumn.AllowEdit = false;
            this.colmarkaadı.StatusBarAciklama = null;
            this.colmarkaadı.StatusBarKisayol = null;
            this.colmarkaadı.StatusBarKisayolAciklama = null;
            this.colmarkaadı.Visible = true;
            this.colmarkaadı.VisibleIndex = 1;
            this.colmarkaadı.Width = 267;
            // 
            // colÜrünAdı
            // 
            this.colÜrünAdı.Caption = "Ürün";
            this.colÜrünAdı.FieldName = "ÜrünAdı";
            this.colÜrünAdı.Name = "colÜrünAdı";
            this.colÜrünAdı.OptionsColumn.AllowEdit = false;
            this.colÜrünAdı.StatusBarAciklama = null;
            this.colÜrünAdı.StatusBarKisayol = null;
            this.colÜrünAdı.StatusBarKisayolAciklama = null;
            this.colÜrünAdı.Visible = true;
            this.colÜrünAdı.VisibleIndex = 1;
            this.colÜrünAdı.Width = 260;
            // 
            // colFirma
            // 
            this.colFirma.Caption = "Firma";
            this.colFirma.FieldName = "FirmaAdı";
            this.colFirma.Name = "colFirma";
            this.colFirma.OptionsColumn.AllowEdit = false;
            this.colFirma.StatusBarAciklama = null;
            this.colFirma.StatusBarKisayol = null;
            this.colFirma.StatusBarKisayolAciklama = null;
            this.colFirma.Visible = true;
            this.colFirma.VisibleIndex = 2;
            this.colFirma.Width = 260;
            // 
            // colGTN
            // 
            this.colGTN.Caption = "GTIN(barcode)";
            this.colGTN.FieldName = "GTIN";
            this.colGTN.Name = "colGTN";
            this.colGTN.OptionsColumn.AllowEdit = false;
            this.colGTN.StatusBarAciklama = null;
            this.colGTN.StatusBarKisayol = null;
            this.colGTN.StatusBarKisayolAciklama = null;
            this.colGTN.Visible = true;
            this.colGTN.VisibleIndex = 4;
            this.colGTN.Width = 150;
            // 
            // colAçıklama
            // 
            this.colAçıklama.Caption = "Açıklama";
            this.colAçıklama.FieldName = "Açıklama";
            this.colAçıklama.Name = "colAçıklama";
            this.colAçıklama.OptionsColumn.AllowEdit = false;
            this.colAçıklama.StatusBarAciklama = null;
            this.colAçıklama.StatusBarKisayol = null;
            this.colAçıklama.StatusBarKisayolAciklama = null;
            this.colAçıklama.Visible = true;
            this.colAçıklama.VisibleIndex = 5;
            this.colAçıklama.Width = 260;
            // 
            // colMTipi
            // 
            this.colMTipi.Caption = "Firma Tipi";
            this.colMTipi.FieldName = "FirmaTipi";
            this.colMTipi.Name = "colMTipi";
            this.colMTipi.OptionsColumn.AllowEdit = false;
            this.colMTipi.StatusBarAciklama = null;
            this.colMTipi.StatusBarKisayol = null;
            this.colMTipi.StatusBarKisayolAciklama = null;
            this.colMTipi.Visible = true;
            this.colMTipi.VisibleIndex = 3;
            this.colMTipi.Width = 150;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 466);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(952, 24);
            this.longNavigator.TabIndex = 4;
            // 
            // MarkalarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 514);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "MarkalarListForm";
            this.Text = "MarkalarListForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.Grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Grid.myGridControl Grid;
        private myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colId;
        private myUserControls.Grid.MyGridColumn colKod;
        protected myUserControls.Grid.MyGridColumn colmarkaadı;
        protected myUserControls.Grid.MyGridColumn colÜrünAdı;
        protected myUserControls.Grid.MyGridColumn colFirma;
        protected myUserControls.Grid.MyGridColumn colGTN;
        protected myUserControls.Grid.MyGridColumn colAçıklama;
        private myUserControls.Grid.MyGridColumn colMTipi;
        private myUserControls.Navigator.LongNavigator longNavigator;
    }
}