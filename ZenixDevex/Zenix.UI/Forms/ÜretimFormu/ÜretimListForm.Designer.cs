namespace Zenix.WinUI.Forms.ÜretimFormu
{
    partial class ÜretimListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜretimListForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colişemri = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colmalzeme = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMiktar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAşamaTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.myDataLayoutControl1 = new Zenix.WinUI.myUserControls.Controls.myDataLayoutControl();
            this.myGridControl3 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.TabloSatınAlma = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId1 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colSatınAlmaKod = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMamül = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colSiparişMiktarı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.coGelen = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colEksikFazla = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colStok = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabloSatınAlma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(869, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 569);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(869, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(12, 12);
            this.myGridControl1.MainView = this.Tablo;
            this.myGridControl1.MenuManager = this.ribbonControl;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(505, 436);
            this.myGridControl1.TabIndex = 3;
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
            this.colişemri,
            this.colmalzeme,
            this.colMiktar,
            this.colAşamaTipi});
            this.Tablo.GridControl = this.myGridControl1;
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
            this.Tablo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colişemri, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // colişemri
            // 
            this.colişemri.Caption = "İşemri";
            this.colişemri.FieldName = "işemriNoveMarkalıÜrün";
            this.colişemri.Name = "colişemri";
            this.colişemri.OptionsColumn.AllowEdit = false;
            this.colişemri.StatusBarAciklama = null;
            this.colişemri.StatusBarKisayol = null;
            this.colişemri.StatusBarKisayolAciklama = null;
            this.colişemri.Visible = true;
            this.colişemri.VisibleIndex = 0;
            // 
            // colmalzeme
            // 
            this.colmalzeme.Caption = "Malzeme";
            this.colmalzeme.FieldName = "MalzemeAdı";
            this.colmalzeme.Name = "colmalzeme";
            this.colmalzeme.OptionsColumn.AllowEdit = false;
            this.colmalzeme.StatusBarAciklama = null;
            this.colmalzeme.StatusBarKisayol = null;
            this.colmalzeme.StatusBarKisayolAciklama = null;
            this.colmalzeme.Visible = true;
            this.colmalzeme.VisibleIndex = 0;
            this.colmalzeme.Width = 227;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.DisplayFormat.FormatString = "{0:n2}";
            this.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.StatusBarAciklama = null;
            this.colMiktar.StatusBarKisayol = null;
            this.colMiktar.StatusBarKisayolAciklama = null;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 1;
            this.colMiktar.Width = 91;
            // 
            // colAşamaTipi
            // 
            this.colAşamaTipi.Caption = "Aşama";
            this.colAşamaTipi.FieldName = "AşamaTipi";
            this.colAşamaTipi.Name = "colAşamaTipi";
            this.colAşamaTipi.OptionsColumn.AllowEdit = false;
            this.colAşamaTipi.StatusBarAciklama = null;
            this.colAşamaTipi.StatusBarKisayol = null;
            this.colAşamaTipi.StatusBarKisayolAciklama = null;
            this.colAşamaTipi.Visible = true;
            this.colAşamaTipi.VisibleIndex = 2;
            this.colAşamaTipi.Width = 142;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.myGridControl1);
            this.myDataLayoutControl1.Controls.Add(this.myGridControl3);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(869, 460);
            this.myDataLayoutControl1.TabIndex = 5;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // myGridControl3
            // 
            this.myGridControl3.Location = new System.Drawing.Point(521, 12);
            this.myGridControl3.MainView = this.TabloSatınAlma;
            this.myGridControl3.MenuManager = this.ribbonControl;
            this.myGridControl3.Name = "myGridControl3";
            this.myGridControl3.Size = new System.Drawing.Size(336, 436);
            this.myGridControl3.TabIndex = 5;
            this.myGridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TabloSatınAlma});
            // 
            // TabloSatınAlma
            // 
            this.TabloSatınAlma.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabloSatınAlma.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.TabloSatınAlma.Appearance.FooterPanel.Options.UseFont = true;
            this.TabloSatınAlma.Appearance.FooterPanel.Options.UseForeColor = true;
            this.TabloSatınAlma.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.TabloSatınAlma.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.TabloSatınAlma.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.TabloSatınAlma.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TabloSatınAlma.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.TabloSatınAlma.Appearance.ViewCaption.Options.UseForeColor = true;
            this.TabloSatınAlma.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.TabloSatınAlma.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TabloSatınAlma.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colSatınAlmaKod,
            this.colMamül,
            this.colSiparişMiktarı,
            this.coGelen,
            this.colEksikFazla,
            this.colStok});
            this.TabloSatınAlma.GridControl = this.myGridControl3;
            this.TabloSatınAlma.GroupCount = 1;
            this.TabloSatınAlma.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", this.colSiparişMiktarı, "Toplam {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gelen", this.coGelen, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EksikFazla", this.colEksikFazla, "{0:n0}")});
            this.TabloSatınAlma.Name = "TabloSatınAlma";
            this.TabloSatınAlma.OptionsBehavior.AutoExpandAllGroups = true;
            this.TabloSatınAlma.OptionsFind.AlwaysVisible = true;
            this.TabloSatınAlma.OptionsFind.FindDelay = 100;
            this.TabloSatınAlma.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.TabloSatınAlma.OptionsFind.FindNullPrompt = "Ara";
            this.TabloSatınAlma.OptionsFind.ShowFindButton = false;
            this.TabloSatınAlma.OptionsMenu.EnableColumnMenu = false;
            this.TabloSatınAlma.OptionsMenu.EnableFooterMenu = false;
            this.TabloSatınAlma.OptionsMenu.EnableGroupPanelMenu = false;
            this.TabloSatınAlma.OptionsNavigation.EnterMoveNextColumn = true;
            this.TabloSatınAlma.OptionsPrint.AutoWidth = false;
            this.TabloSatınAlma.OptionsPrint.PrintGroupFooter = false;
            this.TabloSatınAlma.OptionsView.ColumnAutoWidth = false;
            this.TabloSatınAlma.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.TabloSatınAlma.OptionsView.RowAutoHeight = true;
            this.TabloSatınAlma.OptionsView.ShowGroupPanel = false;
            this.TabloSatınAlma.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSatınAlmaKod, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.TabloSatınAlma.StatusBarAciklama = null;
            this.TabloSatınAlma.StatusBarKisayol = null;
            this.TabloSatınAlma.StatusBarKisayolAciklama = null;
            // 
            // colId1
            // 
            this.colId1.Caption = "Id";
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.OptionsColumn.AllowEdit = false;
            this.colId1.OptionsColumn.ShowInCustomizationForm = false;
            this.colId1.StatusBarAciklama = null;
            this.colId1.StatusBarKisayol = null;
            this.colId1.StatusBarKisayolAciklama = null;
            // 
            // colSatınAlmaKod
            // 
            this.colSatınAlmaKod.Caption = "Satın Alma";
            this.colSatınAlmaKod.FieldName = "SatınAlmaKodFirma";
            this.colSatınAlmaKod.Name = "colSatınAlmaKod";
            this.colSatınAlmaKod.OptionsColumn.AllowEdit = false;
            this.colSatınAlmaKod.StatusBarAciklama = null;
            this.colSatınAlmaKod.StatusBarKisayol = null;
            this.colSatınAlmaKod.StatusBarKisayolAciklama = null;
            this.colSatınAlmaKod.Visible = true;
            this.colSatınAlmaKod.VisibleIndex = 1;
            // 
            // colMamül
            // 
            this.colMamül.Caption = "Malzeme";
            this.colMamül.FieldName = "MamülAdı";
            this.colMamül.Name = "colMamül";
            this.colMamül.OptionsColumn.AllowEdit = false;
            this.colMamül.StatusBarAciklama = null;
            this.colMamül.StatusBarKisayol = null;
            this.colMamül.StatusBarKisayolAciklama = null;
            this.colMamül.Visible = true;
            this.colMamül.VisibleIndex = 0;
            // 
            // colSiparişMiktarı
            // 
            this.colSiparişMiktarı.Caption = "Sipariş";
            this.colSiparişMiktarı.FieldName = "Miktar";
            this.colSiparişMiktarı.Name = "colSiparişMiktarı";
            this.colSiparişMiktarı.OptionsColumn.AllowEdit = false;
            this.colSiparişMiktarı.StatusBarAciklama = null;
            this.colSiparişMiktarı.StatusBarKisayol = null;
            this.colSiparişMiktarı.StatusBarKisayolAciklama = null;
            this.colSiparişMiktarı.Visible = true;
            this.colSiparişMiktarı.VisibleIndex = 1;
            // 
            // coGelen
            // 
            this.coGelen.Caption = "Gelen";
            this.coGelen.FieldName = "Gelen";
            this.coGelen.Name = "coGelen";
            this.coGelen.OptionsColumn.AllowEdit = false;
            this.coGelen.StatusBarAciklama = null;
            this.coGelen.StatusBarKisayol = null;
            this.coGelen.StatusBarKisayolAciklama = null;
            this.coGelen.Visible = true;
            this.coGelen.VisibleIndex = 2;
            // 
            // colEksikFazla
            // 
            this.colEksikFazla.Caption = "Eksik Fazla";
            this.colEksikFazla.FieldName = "EksikFazla";
            this.colEksikFazla.Name = "colEksikFazla";
            this.colEksikFazla.OptionsColumn.AllowEdit = false;
            this.colEksikFazla.StatusBarAciklama = null;
            this.colEksikFazla.StatusBarKisayol = null;
            this.colEksikFazla.StatusBarKisayolAciklama = null;
            this.colEksikFazla.Visible = true;
            this.colEksikFazla.VisibleIndex = 3;
            // 
            // colStok
            // 
            this.colStok.Caption = "Stok";
            this.colStok.FieldName = "Stok";
            this.colStok.Name = "colStok";
            this.colStok.OptionsColumn.AllowEdit = false;
            this.colStok.StatusBarAciklama = null;
            this.colStok.StatusBarKisayol = null;
            this.colStok.StatusBarKisayolAciklama = null;
            this.colStok.Visible = true;
            this.colStok.VisibleIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 60D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 40D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.Root.Size = new System.Drawing.Size(869, 460);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.myGridControl3;
            this.layoutControlItem2.Location = new System.Drawing.Point(509, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(340, 440);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.myGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(509, 440);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ÜretimListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 617);
            this.Controls.Add(this.myDataLayoutControl1);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "ÜretimListForm";
            this.Text = "ÜretimListForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabloSatınAlma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Grid.myGridControl myGridControl1;
        private myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colId;
        private myUserControls.Grid.MyGridColumn colişemri;
        private myUserControls.Grid.MyGridColumn colmalzeme;
        private myUserControls.Grid.MyGridColumn colMiktar;
        private myUserControls.Grid.MyGridColumn colAşamaTipi;
        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl1;
        private myUserControls.Grid.myGridControl myGridControl3;
        private myUserControls.Grid.myGridview TabloSatınAlma;
        private myUserControls.Grid.MyGridColumn colId1;
        private myUserControls.Grid.MyGridColumn colSatınAlmaKod;
        private myUserControls.Grid.MyGridColumn colMamül;
        private myUserControls.Grid.MyGridColumn colSiparişMiktarı;
        private myUserControls.Grid.MyGridColumn coGelen;
        private myUserControls.Grid.MyGridColumn colEksikFazla;
        private myUserControls.Grid.MyGridColumn colStok;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}