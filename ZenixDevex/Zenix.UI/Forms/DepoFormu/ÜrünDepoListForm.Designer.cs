namespace Zenix.WinUI.Forms.DepoFormu
{
    partial class ÜrünDepoListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜrünDepoListForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
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
            this.TabloSipariş = new Zenix.WinUI.myUserControls.Grid.myGridview();
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
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.popupMenuSatınalma = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnTümüSevk = new DevExpress.XtraBars.BarButtonItem();
            this.btnSevk = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubSevkItem = new DevExpress.XtraBars.BarSubItem();
            this.barbirkısmıSevk = new DevExpress.XtraBars.BarEditItem();
            this.txtBirKısımSevk = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnSevkOnayla = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoYarıMamülLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabloSipariş)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatınalma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirKısımSevk)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTümüSevk,
            this.btnSevk,
            this.btnSubSevkItem,
            this.barbirkısmıSevk,
            this.btnSevkOnayla});
            this.ribbonControl.MaxItemId = 73;
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtBirKısımSevk});
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(1013, 109);
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
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.myGridControl1);
            this.myDataLayoutControl1.Controls.Add(this.myGridControl2);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(1013, 517);
            this.myDataLayoutControl1.TabIndex = 5;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(12, 12);
            this.myGridControl1.MainView = this.Tablo;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(592, 493);
            this.myGridControl1.TabIndex = 7;
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
            this.Tablo.OptionsView.ShowViewCaption = true;
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
            this.colMamülAdı.FieldName = "Ad";
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
            this.myGridControl2.Location = new System.Drawing.Point(608, 12);
            this.myGridControl2.MainView = this.TabloSipariş;
            this.myGridControl2.MenuManager = this.ribbonControl;
            this.myGridControl2.Name = "myGridControl2";
            this.myGridControl2.Size = new System.Drawing.Size(393, 493);
            this.myGridControl2.TabIndex = 5;
            this.myGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TabloSipariş});
            // 
            // TabloSipariş
            // 
            this.TabloSipariş.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabloSipariş.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.TabloSipariş.Appearance.FooterPanel.Options.UseFont = true;
            this.TabloSipariş.Appearance.FooterPanel.Options.UseForeColor = true;
            this.TabloSipariş.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.TabloSipariş.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.TabloSipariş.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.TabloSipariş.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TabloSipariş.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.TabloSipariş.Appearance.ViewCaption.Options.UseForeColor = true;
            this.TabloSipariş.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.TabloSipariş.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TabloSipariş.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colSatınAlmaKod,
            this.colMamül,
            this.colSiparişMiktarı,
            this.coGelen,
            this.colEksikFazla,
            this.colStok});
            this.TabloSipariş.GridControl = this.myGridControl2;
            this.TabloSipariş.GroupCount = 1;
            this.TabloSipariş.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", this.colSiparişMiktarı, "Toplam {0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gelen", this.coGelen, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EksikFazla", this.colEksikFazla, "{0:n0}")});
            this.TabloSipariş.Name = "TabloSipariş";
            this.TabloSipariş.OptionsBehavior.AutoExpandAllGroups = true;
            this.TabloSipariş.OptionsFind.AlwaysVisible = true;
            this.TabloSipariş.OptionsFind.FindDelay = 100;
            this.TabloSipariş.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.TabloSipariş.OptionsFind.FindNullPrompt = "Ara";
            this.TabloSipariş.OptionsFind.ShowFindButton = false;
            this.TabloSipariş.OptionsMenu.EnableColumnMenu = false;
            this.TabloSipariş.OptionsMenu.EnableFooterMenu = false;
            this.TabloSipariş.OptionsMenu.EnableGroupPanelMenu = false;
            this.TabloSipariş.OptionsNavigation.EnterMoveNextColumn = true;
            this.TabloSipariş.OptionsPrint.AutoWidth = false;
            this.TabloSipariş.OptionsPrint.PrintGroupFooter = false;
            this.TabloSipariş.OptionsView.ColumnAutoWidth = false;
            this.TabloSipariş.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.TabloSipariş.OptionsView.RowAutoHeight = true;
            this.TabloSipariş.OptionsView.ShowGroupPanel = false;
            this.TabloSipariş.OptionsView.ShowViewCaption = true;
            this.TabloSipariş.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSatınAlmaKod, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.TabloSipariş.StatusBarAciklama = null;
            this.TabloSipariş.StatusBarKisayol = null;
            this.TabloSipariş.StatusBarKisayolAciklama = null;
            this.TabloSipariş.ViewCaption = "Siparişler";
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
            this.colSatınAlmaKod.Caption = "Sipariş";
            this.colSatınAlmaKod.FieldName = "SiparişKodFirma";
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
            this.colMamül.Caption = "Ürün";
            this.colMamül.FieldName = "ÜrünAdı";
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
            this.coGelen.Caption = "Sevk";
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
            this.Root.Size = new System.Drawing.Size(1013, 517);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.myGridControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(596, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(397, 497);
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
            this.layoutControlItem1.Size = new System.Drawing.Size(596, 497);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 626);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1013, 24);
            this.longNavigator.TabIndex = 6;
            // 
            // popupMenuSatınalma
            // 
            this.popupMenuSatınalma.ItemLinks.Add(this.btnTümüSevk);
            this.popupMenuSatınalma.ItemLinks.Add(this.btnSevk);
            this.popupMenuSatınalma.ItemLinks.Add(this.btnSubSevkItem);
            this.popupMenuSatınalma.Name = "popupMenuSatınalma";
            this.popupMenuSatınalma.Ribbon = this.ribbonControl;
            // 
            // btnTümüSevk
            // 
            this.btnTümüSevk.Caption = "Tümünü Sevk Et";
            this.btnTümüSevk.Id = 68;
            this.btnTümüSevk.ImageOptions.SvgImage = global::Zenix.WinUI.Properties.Resources.shipmenttransit;
            this.btnTümüSevk.Name = "btnTümüSevk";
            // 
            // btnSevk
            // 
            this.btnSevk.Caption = "Sevk Et";
            this.btnSevk.Id = 69;
            this.btnSevk.ImageOptions.SvgImage = global::Zenix.WinUI.Properties.Resources.productquickshippments;
            this.btnSevk.Name = "btnSevk";
            // 
            // btnSubSevkItem
            // 
            this.btnSubSevkItem.Caption = "Bir Kısmını Sevk Et";
            this.btnSubSevkItem.Id = 70;
            this.btnSubSevkItem.ImageOptions.SvgImage = global::Zenix.WinUI.Properties.Resources.productquickshippments;
            this.btnSubSevkItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barbirkısmıSevk),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSevkOnayla)});
            this.btnSubSevkItem.Name = "btnSubSevkItem";
            // 
            // barbirkısmıSevk
            // 
            this.barbirkısmıSevk.Caption = "Sevk Miktarı";
            this.barbirkısmıSevk.Edit = this.txtBirKısımSevk;
            this.barbirkısmıSevk.EditWidth = 150;
            this.barbirkısmıSevk.Id = 71;
            this.barbirkısmıSevk.ImageOptions.SvgImage = global::Zenix.WinUI.Properties.Resources.productquickshippments;
            this.barbirkısmıSevk.Name = "barbirkısmıSevk";
            // 
            // txtBirKısımSevk
            // 
            this.txtBirKısımSevk.AutoHeight = false;
            this.txtBirKısımSevk.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirKısımSevk.DisplayFormat.FormatString = "{0:n1}";
            this.txtBirKısımSevk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBirKısımSevk.EditFormat.FormatString = "{0:n1}";
            this.txtBirKısımSevk.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBirKısımSevk.Mask.EditMask = "n1";
            this.txtBirKısımSevk.Name = "txtBirKısımSevk";
            // 
            // btnSevkOnayla
            // 
            this.btnSevkOnayla.Caption = "Sevk Onayla";
            this.btnSevkOnayla.Id = 72;
            this.btnSevkOnayla.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.apply_16x164;
            this.btnSevkOnayla.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.apply_32x324;
            this.btnSevkOnayla.Name = "btnSevkOnayla";
            // 
            // ÜrünDepoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 674);
            this.Controls.Add(this.myDataLayoutControl1);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "ÜrünDepoListForm";
            this.Text = "ÜrünDepo";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoYarıMamülLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabloSipariş)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuSatınalma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirKısımSevk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl1;
        private myUserControls.Grid.myGridControl myGridControl2;
        private myUserControls.Grid.myGridview TabloSipariş;
        private myUserControls.Grid.MyGridColumn colId1;
        private myUserControls.Grid.MyGridColumn colSatınAlmaKod;
        private myUserControls.Grid.MyGridColumn colMamül;
        private myUserControls.Grid.MyGridColumn colSiparişMiktarı;
        private myUserControls.Grid.MyGridColumn coGelen;
        private myUserControls.Grid.MyGridColumn colEksikFazla;
        private myUserControls.Grid.MyGridColumn colStok;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Grid.myGridControl myGridControl1;
        public myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colId;
        private myUserControls.Grid.MyGridColumn colMamülAdı;
        private myUserControls.Grid.MyGridColumn colKayıtDUrum;
        private myUserControls.Grid.MyGridColumn colMiktar;
        private myUserControls.Grid.MyGridColumn colTarih;
        private myUserControls.Grid.MyGridColumn colTip;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.PopupMenu popupMenuSatınalma;
        private DevExpress.XtraBars.BarButtonItem btnTümüSevk;
        private DevExpress.XtraBars.BarButtonItem btnSevk;
        private DevExpress.XtraBars.BarSubItem btnSubSevkItem;
        private DevExpress.XtraBars.BarEditItem barbirkısmıSevk;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit txtBirKısımSevk;
        private DevExpress.XtraBars.BarButtonItem btnSevkOnayla;
    }
}