namespace Zenix.WinUI.Forms.DepoFormu
{
    partial class MalzemeDepoListform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalzemeDepoListform));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.myDataLayoutControl1 = new Zenix.WinUI.myUserControls.Controls.myDataLayoutControl();
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMamülAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKayıtDUrum = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMiktar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colTarih = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colTip = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.myGridControl2 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
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
            this.popupMenuSatınalma = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnHepsiniAL = new DevExpress.XtraBars.BarButtonItem();
            this.btnAL = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemMiktar = new DevExpress.XtraBars.BarSubItem();
            this.barBirMiktar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEditMiktar = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnMiktarOnayla = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabloSatınAlma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatınalma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnHepsiniAL,
            this.barMdiChildrenListItem1,
            this.barListItem1,
            this.btnAL,
            this.barButtonItem3,
            this.barSubItemMiktar,
            this.barBirMiktar,
            this.btnMiktarOnayla});
            this.ribbonControl.MaxItemId = 71;
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEditMiktar});
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(1020, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // btnAşamalar
            // 
            this.btnAşamalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAşamalar.ImageOptions.Image")));
            this.btnAşamalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAşamalar.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 588);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1020, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.myGridControl1);
            this.myDataLayoutControl1.Controls.Add(this.myGridControl2);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(1020, 479);
            this.myDataLayoutControl1.TabIndex = 4;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(12, 12);
            this.myGridControl1.MainView = this.Tablo;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(596, 455);
            this.myGridControl1.TabIndex = 6;
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
            this.colKayıtDUrum,
            this.colMiktar,
            this.colTarih,
            this.colTip});
            this.Tablo.GridControl = this.myGridControl1;
            this.Tablo.GroupCount = 1;
            this.Tablo.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DepoMiktar", this.colMiktar, "Stok {0:n0}")});
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
            this.colMamülAdı.Caption = "    ";
            this.colMamülAdı.FieldName = "MamülAdı";
            this.colMamülAdı.Name = "colMamülAdı";
            this.colMamülAdı.OptionsColumn.AllowEdit = false;
            this.colMamülAdı.StatusBarAciklama = null;
            this.colMamülAdı.StatusBarKisayol = null;
            this.colMamülAdı.StatusBarKisayolAciklama = null;
            this.colMamülAdı.Visible = true;
            this.colMamülAdı.VisibleIndex = 1;
            // 
            // colKayıtDUrum
            // 
            this.colKayıtDUrum.Caption = "Durum";
            this.colKayıtDUrum.FieldName = "KayıtDurum";
            this.colKayıtDUrum.Name = "colKayıtDUrum";
            this.colKayıtDUrum.OptionsColumn.AllowEdit = false;
            this.colKayıtDUrum.StatusBarAciklama = null;
            this.colKayıtDUrum.StatusBarKisayol = null;
            this.colKayıtDUrum.StatusBarKisayolAciklama = null;
            this.colKayıtDUrum.Visible = true;
            this.colKayıtDUrum.VisibleIndex = 0;
            this.colKayıtDUrum.Width = 217;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.DisplayFormat.FormatString = "{0:n0}";
            this.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            // myGridControl2
            // 
            this.myGridControl2.Location = new System.Drawing.Point(612, 12);
            this.myGridControl2.MainView = this.TabloSatınAlma;
            this.myGridControl2.MenuManager = this.ribbonControl;
            this.myGridControl2.Name = "myGridControl2";
            this.myGridControl2.Size = new System.Drawing.Size(396, 455);
            this.myGridControl2.TabIndex = 5;
            this.myGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.TabloSatınAlma.GridControl = this.myGridControl2;
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
            this.colSatınAlmaKod.Caption = "Durum";
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
            this.colMamül.Caption = " Malzeme";
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
            this.coGelen.Caption = "Alınan";
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
            this.colEksikFazla.Caption = "Kalan";
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
            this.Root.Size = new System.Drawing.Size(1020, 479);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.myGridControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(600, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(400, 459);
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
            this.layoutControlItem1.Size = new System.Drawing.Size(600, 459);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // popupMenuSatınalma
            // 
            this.popupMenuSatınalma.ItemLinks.Add(this.btnHepsiniAL);
            this.popupMenuSatınalma.ItemLinks.Add(this.btnAL);
            this.popupMenuSatınalma.ItemLinks.Add(this.barSubItemMiktar);
            this.popupMenuSatınalma.Name = "popupMenuSatınalma";
            this.popupMenuSatınalma.Ribbon = this.ribbonControl;
            // 
            // btnHepsiniAL
            // 
            this.btnHepsiniAL.Caption = "HepsiniAl";
            this.btnHepsiniAL.Id = 63;
            this.btnHepsiniAL.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.add_16x16;
            this.btnHepsiniAL.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.add_32x32;
            this.btnHepsiniAL.Name = "btnHepsiniAL";
            // 
            // btnAL
            // 
            this.btnAL.Caption = "Al";
            this.btnAL.Id = 66;
            this.btnAL.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.add_16x161;
            this.btnAL.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.add_32x321;
            this.btnAL.Name = "btnAL";
            // 
            // barSubItemMiktar
            // 
            this.barSubItemMiktar.Caption = "Bir Miktar Al\r\n";
            this.barSubItemMiktar.Id = 68;
            this.barSubItemMiktar.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.add_16x163;
            this.barSubItemMiktar.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.add_32x323;
            this.barSubItemMiktar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBirMiktar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMiktarOnayla)});
            this.barSubItemMiktar.Name = "barSubItemMiktar";
            // 
            // barBirMiktar
            // 
            this.barBirMiktar.Caption = "Miktar";
            this.barBirMiktar.Edit = this.repositoryItemSpinEditMiktar;
            this.barBirMiktar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.barBirMiktar.EditWidth = 100;
            this.barBirMiktar.Id = 69;
            this.barBirMiktar.Name = "barBirMiktar";
            // 
            // repositoryItemSpinEditMiktar
            // 
            this.repositoryItemSpinEditMiktar.AutoHeight = false;
            this.repositoryItemSpinEditMiktar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEditMiktar.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemSpinEditMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEditMiktar.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemSpinEditMiktar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEditMiktar.Mask.EditMask = "n2";
            this.repositoryItemSpinEditMiktar.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEditMiktar.Name = "repositoryItemSpinEditMiktar";
            // 
            // btnMiktarOnayla
            // 
            this.btnMiktarOnayla.Caption = "Onayla";
            this.btnMiktarOnayla.Id = 70;
            this.btnMiktarOnayla.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.apply_16x162;
            this.btnMiktarOnayla.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.apply_32x322;
            this.btnMiktarOnayla.Name = "btnMiktarOnayla";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Bir Miktar Al";
            this.barButtonItem3.Id = 67;
            this.barButtonItem3.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.add_16x162;
            this.barButtonItem3.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.add_32x322;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 64;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 65;
            this.barListItem1.Name = "barListItem1";
            // 
            // MalzemeDepoListform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 636);
            this.Controls.Add(this.myDataLayoutControl1);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "MalzemeDepoListform";
            this.Text = "MalzemeDepoListform";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabloSatınAlma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatınalma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl1;
        private myUserControls.Grid.myGridControl myGridControl2;
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
        private DevExpress.XtraBars.BarButtonItem btnHepsiniAL;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.PopupMenu popupMenuSatınalma;
        private DevExpress.XtraBars.BarButtonItem btnAL;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarSubItem barSubItemMiktar;
        private DevExpress.XtraBars.BarEditItem barBirMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditMiktar;
        private DevExpress.XtraBars.BarButtonItem btnMiktarOnayla;
        private myUserControls.Grid.myGridControl myGridControl1;
        public myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colId;
        private myUserControls.Grid.MyGridColumn colMamülAdı;
        private myUserControls.Grid.MyGridColumn colKayıtDUrum;
        private myUserControls.Grid.MyGridColumn colMiktar;
        private myUserControls.Grid.MyGridColumn colTarih;
        private myUserControls.Grid.MyGridColumn colTip;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}