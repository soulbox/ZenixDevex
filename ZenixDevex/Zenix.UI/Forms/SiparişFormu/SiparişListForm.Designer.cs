namespace Zenix.WinUI.Forms.SiparişFormu
{
    partial class SiparişListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparişListForm));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.myDataLayoutControl1 = new Zenix.WinUI.myUserControls.Controls.myDataLayoutControl();
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.SiparişTablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.myGridColumn1 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colÜrün = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKutu = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colkoliadedi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoSpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colKoli = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMiktar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colBirim = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoimagecomboBirim = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colTeslimat = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colStok = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.myGridColumn2 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colParaBirim = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoParabirimi = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colBirimFiyat = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colTutar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.Grid = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colFirmaAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colPersonel = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.coltarih = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colAçıklama = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.col = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiparişTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimagecomboBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoParabirimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1024, 109);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 540);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1024, 24);
            this.longNavigator.TabIndex = 8;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.myGridControl1);
            this.myDataLayoutControl1.Controls.Add(this.Grid);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(1024, 431);
            this.myDataLayoutControl1.TabIndex = 10;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(313, 12);
            this.myGridControl1.MainView = this.SiparişTablo;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheck,
            this.repoSpin,
            this.repoimagecomboBirim,
            this.repositoryItemTextEdit1,
            this.repoParabirimi});
            this.myGridControl1.Size = new System.Drawing.Size(699, 407);
            this.myGridControl1.TabIndex = 13;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SiparişTablo});
            // 
            // SiparişTablo
            // 
            this.SiparişTablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SiparişTablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.SiparişTablo.Appearance.FooterPanel.Options.UseFont = true;
            this.SiparişTablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.SiparişTablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.SiparişTablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.SiparişTablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.SiparişTablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiparişTablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.SiparişTablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.SiparişTablo.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.SiparişTablo.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SiparişTablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.myGridColumn1,
            this.colÜrün,
            this.colKutu,
            this.colkoliadedi,
            this.colKoli,
            this.colMiktar,
            this.colBirim,
            this.colTeslimat,
            this.colStok,
            this.myGridColumn2,
            this.colParaBirim,
            this.colBirimFiyat,
            this.colTutar});
            this.SiparişTablo.GridControl = this.myGridControl1;
            this.SiparişTablo.Name = "SiparişTablo";
            this.SiparişTablo.OptionsFind.FindDelay = 100;
            this.SiparişTablo.OptionsFind.FindNullPrompt = "Ara";
            this.SiparişTablo.OptionsFind.ShowFindButton = false;
            this.SiparişTablo.OptionsMenu.EnableColumnMenu = false;
            this.SiparişTablo.OptionsMenu.EnableFooterMenu = false;
            this.SiparişTablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.SiparişTablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.SiparişTablo.OptionsPrint.AutoWidth = false;
            this.SiparişTablo.OptionsPrint.PrintGroupFooter = false;
            this.SiparişTablo.OptionsView.ColumnAutoWidth = false;
            this.SiparişTablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.SiparişTablo.OptionsView.RowAutoHeight = true;
            this.SiparişTablo.OptionsView.ShowGroupPanel = false;
            this.SiparişTablo.StatusBarAciklama = "Malzeme Kartları";
            this.SiparişTablo.StatusBarKisayol = "Shift+Insert";
            this.SiparişTablo.StatusBarKisayolAciklama = "Malzeme Kartı Ekle";
            this.SiparişTablo.ViewCaption = "Ürünler";
            // 
            // myGridColumn1
            // 
            this.myGridColumn1.Caption = "Id";
            this.myGridColumn1.FieldName = "Id";
            this.myGridColumn1.Name = "myGridColumn1";
            this.myGridColumn1.OptionsColumn.AllowEdit = false;
            this.myGridColumn1.OptionsColumn.ShowInCustomizationForm = false;
            this.myGridColumn1.StatusBarAciklama = null;
            this.myGridColumn1.StatusBarKisayol = null;
            this.myGridColumn1.StatusBarKisayolAciklama = null;
            // 
            // colÜrün
            // 
            this.colÜrün.Caption = "Ürün";
            this.colÜrün.FieldName = "ÜrünAdı";
            this.colÜrün.Name = "colÜrün";
            this.colÜrün.OptionsColumn.AllowEdit = false;
            this.colÜrün.OptionsFilter.AllowAutoFilter = false;
            this.colÜrün.OptionsFilter.AllowFilter = false;
            this.colÜrün.StatusBarAciklama = null;
            this.colÜrün.StatusBarKisayol = null;
            this.colÜrün.StatusBarKisayolAciklama = null;
            this.colÜrün.Visible = true;
            this.colÜrün.VisibleIndex = 0;
            this.colÜrün.Width = 350;
            // 
            // colKutu
            // 
            this.colKutu.Caption = "Kutu";
            this.colKutu.FieldName = "Kutu";
            this.colKutu.Name = "colKutu";
            this.colKutu.OptionsColumn.AllowEdit = false;
            this.colKutu.StatusBarAciklama = null;
            this.colKutu.StatusBarKisayol = null;
            this.colKutu.StatusBarKisayolAciklama = null;
            this.colKutu.Visible = true;
            this.colKutu.VisibleIndex = 1;
            // 
            // colkoliadedi
            // 
            this.colkoliadedi.Caption = "Koli Adedi";
            this.colkoliadedi.ColumnEdit = this.repoSpin;
            this.colkoliadedi.FieldName = "KoliAdedi";
            this.colkoliadedi.Name = "colkoliadedi";
            this.colkoliadedi.OptionsColumn.AllowEdit = false;
            this.colkoliadedi.StatusBarAciklama = null;
            this.colkoliadedi.StatusBarKisayol = null;
            this.colkoliadedi.StatusBarKisayolAciklama = null;
            this.colkoliadedi.Visible = true;
            this.colkoliadedi.VisibleIndex = 3;
            // 
            // repoSpin
            // 
            this.repoSpin.AutoHeight = false;
            this.repoSpin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoSpin.DisplayFormat.FormatString = "{0:n1}";
            this.repoSpin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repoSpin.EditFormat.FormatString = "{0:n1}";
            this.repoSpin.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repoSpin.Mask.EditMask = "n1";
            this.repoSpin.Name = "repoSpin";
            // 
            // colKoli
            // 
            this.colKoli.Caption = "Koli içi Ürün";
            this.colKoli.FieldName = "Koli";
            this.colKoli.Name = "colKoli";
            this.colKoli.OptionsColumn.AllowEdit = false;
            this.colKoli.StatusBarAciklama = null;
            this.colKoli.StatusBarKisayol = null;
            this.colKoli.StatusBarKisayolAciklama = null;
            this.colKoli.Visible = true;
            this.colKoli.VisibleIndex = 2;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.ColumnEdit = this.repoSpin;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.OptionsFilter.AllowAutoFilter = false;
            this.colMiktar.OptionsFilter.AllowFilter = false;
            this.colMiktar.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colMiktar.StatusBarAciklama = null;
            this.colMiktar.StatusBarKisayol = null;
            this.colMiktar.StatusBarKisayolAciklama = null;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 4;
            // 
            // colBirim
            // 
            this.colBirim.Caption = "Birim";
            this.colBirim.ColumnEdit = this.repoimagecomboBirim;
            this.colBirim.FieldName = "BirimTipi";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.OptionsFilter.AllowAutoFilter = false;
            this.colBirim.OptionsFilter.AllowFilter = false;
            this.colBirim.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colBirim.StatusBarAciklama = null;
            this.colBirim.StatusBarKisayol = null;
            this.colBirim.StatusBarKisayolAciklama = null;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 5;
            // 
            // repoimagecomboBirim
            // 
            this.repoimagecomboBirim.AutoHeight = false;
            this.repoimagecomboBirim.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoimagecomboBirim.CaseSensitiveSearch = true;
            this.repoimagecomboBirim.Name = "repoimagecomboBirim";
            // 
            // colTeslimat
            // 
            this.colTeslimat.Caption = "Teslimat";
            this.colTeslimat.ColumnEdit = this.repoCheck;
            this.colTeslimat.FieldName = "Teslimat";
            this.colTeslimat.Name = "colTeslimat";
            this.colTeslimat.OptionsColumn.AllowEdit = false;
            this.colTeslimat.StatusBarAciklama = null;
            this.colTeslimat.StatusBarKisayol = null;
            this.colTeslimat.StatusBarKisayolAciklama = null;
            this.colTeslimat.Visible = true;
            this.colTeslimat.VisibleIndex = 8;
            this.colTeslimat.Width = 51;
            // 
            // repoCheck
            // 
            this.repoCheck.AutoHeight = false;
            this.repoCheck.Name = "repoCheck";
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
            this.colStok.VisibleIndex = 6;
            // 
            // myGridColumn2
            // 
            this.myGridColumn2.Caption = "Açıklama";
            this.myGridColumn2.ColumnEdit = this.repositoryItemTextEdit1;
            this.myGridColumn2.FieldName = "Açıklama";
            this.myGridColumn2.Name = "myGridColumn2";
            this.myGridColumn2.OptionsColumn.AllowEdit = false;
            this.myGridColumn2.StatusBarAciklama = null;
            this.myGridColumn2.StatusBarKisayol = null;
            this.myGridColumn2.StatusBarKisayolAciklama = null;
            this.myGridColumn2.Visible = true;
            this.myGridColumn2.VisibleIndex = 7;
            this.myGridColumn2.Width = 100;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colParaBirim
            // 
            this.colParaBirim.Caption = "ParaBirim";
            this.colParaBirim.FieldName = "ParaBirimi";
            this.colParaBirim.Name = "colParaBirim";
            this.colParaBirim.OptionsColumn.AllowEdit = false;
            this.colParaBirim.StatusBarAciklama = null;
            this.colParaBirim.StatusBarKisayol = null;
            this.colParaBirim.StatusBarKisayolAciklama = null;
            this.colParaBirim.Visible = true;
            this.colParaBirim.VisibleIndex = 10;
            // 
            // repoParabirimi
            // 
            this.repoParabirimi.AutoHeight = false;
            this.repoParabirimi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoParabirimi.Name = "repoParabirimi";
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.Caption = "BirimFiyat";
            this.colBirimFiyat.ColumnEdit = this.repoSpin;
            this.colBirimFiyat.FieldName = "BirimFiyat";
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.OptionsColumn.AllowEdit = false;
            this.colBirimFiyat.StatusBarAciklama = null;
            this.colBirimFiyat.StatusBarKisayol = null;
            this.colBirimFiyat.StatusBarKisayolAciklama = null;
            this.colBirimFiyat.Visible = true;
            this.colBirimFiyat.VisibleIndex = 9;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.DisplayFormat.FormatString = "{0:n2}";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.StatusBarAciklama = null;
            this.colTutar.StatusBarKisayol = null;
            this.colTutar.StatusBarKisayolAciklama = null;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 11;
            // 
            // Grid
            // 
            this.Grid.Location = new System.Drawing.Point(12, 12);
            this.Grid.MainView = this.Tablo;
            this.Grid.MenuManager = this.ribbonControl;
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.Grid.Size = new System.Drawing.Size(297, 407);
            this.Grid.TabIndex = 12;
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
            this.colFirmaAdı,
            this.colPersonel,
            this.coltarih,
            this.colAçıklama,
            this.col});
            this.Tablo.GridControl = this.Grid;
            this.Tablo.Name = "Tablo";
            this.Tablo.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
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
            this.Tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.Tablo.OptionsView.RowAutoHeight = true;
            this.Tablo.OptionsView.ShowAutoFilterRow = true;
            this.Tablo.OptionsView.ShowGroupPanel = false;
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
            // colFirmaAdı
            // 
            this.colFirmaAdı.AppearanceCell.Options.UseTextOptions = true;
            this.colFirmaAdı.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFirmaAdı.Caption = "Firma";
            this.colFirmaAdı.FieldName = "FirmaAdi";
            this.colFirmaAdı.Name = "colFirmaAdı";
            this.colFirmaAdı.OptionsColumn.AllowEdit = false;
            this.colFirmaAdı.StatusBarAciklama = null;
            this.colFirmaAdı.StatusBarKisayol = null;
            this.colFirmaAdı.StatusBarKisayolAciklama = null;
            this.colFirmaAdı.Visible = true;
            this.colFirmaAdı.VisibleIndex = 1;
            this.colFirmaAdı.Width = 200;
            // 
            // colPersonel
            // 
            this.colPersonel.Caption = "Personel";
            this.colPersonel.FieldName = "Personel";
            this.colPersonel.Name = "colPersonel";
            this.colPersonel.OptionsColumn.AllowEdit = false;
            this.colPersonel.StatusBarAciklama = null;
            this.colPersonel.StatusBarKisayol = null;
            this.colPersonel.StatusBarKisayolAciklama = null;
            this.colPersonel.Visible = true;
            this.colPersonel.VisibleIndex = 2;
            this.colPersonel.Width = 200;
            // 
            // coltarih
            // 
            this.coltarih.AppearanceCell.Options.UseTextOptions = true;
            this.coltarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltarih.Caption = "Tarih";
            this.coltarih.ColumnEdit = this.repositoryItemDateEdit1;
            this.coltarih.FieldName = "Tarih";
            this.coltarih.Name = "coltarih";
            this.coltarih.OptionsColumn.AllowEdit = false;
            this.coltarih.StatusBarAciklama = null;
            this.coltarih.StatusBarKisayol = null;
            this.coltarih.StatusBarKisayolAciklama = null;
            this.coltarih.Visible = true;
            this.coltarih.VisibleIndex = 3;
            this.coltarih.Width = 90;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
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
            this.colAçıklama.VisibleIndex = 4;
            this.colAçıklama.Width = 252;
            // 
            // col
            // 
            this.col.Caption = "Kayıt";
            this.col.FieldName = "ÜrünMiktarı";
            this.col.Name = "col";
            this.col.OptionsColumn.AllowEdit = false;
            this.col.StatusBarAciklama = null;
            this.col.StatusBarKisayol = null;
            this.col.StatusBarKisayolAciklama = null;
            this.col.Visible = true;
            this.col.VisibleIndex = 5;
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
            columnDefinition1.Width = 30D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 70D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.Root.Size = new System.Drawing.Size(1024, 431);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.Grid;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(301, 411);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.myGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(301, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(703, 411);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // SiparişListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 588);
            this.Controls.Add(this.myDataLayoutControl1);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "SiparişListForm";
            this.Text = "SiparişListForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiparişTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimagecomboBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoParabirimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private myUserControls.Grid.myGridControl Grid;
        private myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colId;
        private myUserControls.Grid.MyGridColumn colKod;
        protected myUserControls.Grid.MyGridColumn colFirmaAdı;
        private myUserControls.Grid.MyGridColumn colPersonel;
        private myUserControls.Grid.MyGridColumn coltarih;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private myUserControls.Grid.MyGridColumn colAçıklama;
        private myUserControls.Grid.MyGridColumn col;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private myUserControls.Grid.myGridControl myGridControl1;
        public myUserControls.Grid.myGridview SiparişTablo;
        private myUserControls.Grid.MyGridColumn myGridColumn1;
        private myUserControls.Grid.MyGridColumn colÜrün;
        private myUserControls.Grid.MyGridColumn colKutu;
        private myUserControls.Grid.MyGridColumn colkoliadedi;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repoSpin;
        private myUserControls.Grid.MyGridColumn colKoli;
        private myUserControls.Grid.MyGridColumn colMiktar;
        private myUserControls.Grid.MyGridColumn colBirim;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoimagecomboBirim;
        private myUserControls.Grid.MyGridColumn colTeslimat;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheck;
        private myUserControls.Grid.MyGridColumn colStok;
        private myUserControls.Grid.MyGridColumn myGridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private myUserControls.Grid.MyGridColumn colParaBirim;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoParabirimi;
        private myUserControls.Grid.MyGridColumn colBirimFiyat;
        private myUserControls.Grid.MyGridColumn colTutar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}