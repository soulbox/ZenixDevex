namespace Zenix.WinUI.Forms.YarımamülFormu
{
    partial class YarıMamülEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.myDataLayoutControl1 = new Zenix.WinUI.myUserControls.Controls.myDataLayoutControl();
            this.Grid = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colFirmaAdi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colTarih = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colÜlke = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colPersonel = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMiktar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.TabloSatınalma = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.myGridColumn1 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMalzemeAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colReçeteBirimi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colTermin = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.myGridColumn2 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoSpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTeslimat = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repoimgaecomboBirim = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabloSatınalma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimgaecomboBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(927, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 543);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(927, 24);
            this.longNavigator.TabIndex = 5;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.Grid);
            this.myDataLayoutControl1.Controls.Add(this.myGridControl1);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(927, 434);
            this.myDataLayoutControl1.TabIndex = 7;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // Grid
            // 
            this.Grid.Location = new System.Drawing.Point(12, 12);
            this.Grid.MainView = this.Tablo;
            this.Grid.MenuManager = this.ribbonControl;
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(540, 410);
            this.Grid.TabIndex = 9;
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
            this.colFirmaAdi,
            this.colTarih,
            this.colMTipi,
            this.colÜlke,
            this.colPersonel,
            this.colMiktar});
            this.Tablo.GridControl = this.Grid;
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
            // colFirmaAdi
            // 
            this.colFirmaAdi.Caption = "Firma Adı";
            this.colFirmaAdi.FieldName = "FirmaAdi";
            this.colFirmaAdi.Name = "colFirmaAdi";
            this.colFirmaAdi.OptionsColumn.AllowEdit = false;
            this.colFirmaAdi.StatusBarAciklama = null;
            this.colFirmaAdi.StatusBarKisayol = null;
            this.colFirmaAdi.StatusBarKisayolAciklama = null;
            this.colFirmaAdi.Visible = true;
            this.colFirmaAdi.VisibleIndex = 1;
            this.colFirmaAdi.Width = 267;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Kayıt Tarihi";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.StatusBarAciklama = null;
            this.colTarih.StatusBarKisayol = null;
            this.colTarih.StatusBarKisayolAciklama = null;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 4;
            this.colTarih.Width = 103;
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
            this.colMTipi.Width = 93;
            // 
            // colÜlke
            // 
            this.colÜlke.Caption = "Ülke";
            this.colÜlke.FieldName = "Ülke";
            this.colÜlke.Name = "colÜlke";
            this.colÜlke.OptionsColumn.AllowEdit = false;
            this.colÜlke.StatusBarAciklama = null;
            this.colÜlke.StatusBarKisayol = null;
            this.colÜlke.StatusBarKisayolAciklama = null;
            this.colÜlke.Visible = true;
            this.colÜlke.VisibleIndex = 2;
            this.colÜlke.Width = 100;
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
            this.colPersonel.VisibleIndex = 5;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Kayıt";
            this.colMiktar.FieldName = "SatınAlmaMiktarı";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.StatusBarAciklama = null;
            this.colMiktar.StatusBarKisayol = null;
            this.colMiktar.StatusBarKisayolAciklama = null;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 6;
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(556, 12);
            this.myGridControl1.MainView = this.TabloSatınalma;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheck,
            this.repoSpin,
            this.repoimgaecomboBirim,
            this.repositoryItemDateEdit1});
            this.myGridControl1.Size = new System.Drawing.Size(359, 410);
            this.myGridControl1.TabIndex = 8;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TabloSatınalma});
            // 
            // TabloSatınalma
            // 
            this.TabloSatınalma.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TabloSatınalma.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.TabloSatınalma.Appearance.FooterPanel.Options.UseFont = true;
            this.TabloSatınalma.Appearance.FooterPanel.Options.UseForeColor = true;
            this.TabloSatınalma.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.TabloSatınalma.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.TabloSatınalma.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.TabloSatınalma.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TabloSatınalma.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.TabloSatınalma.Appearance.ViewCaption.Options.UseForeColor = true;
            this.TabloSatınalma.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.TabloSatınalma.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TabloSatınalma.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.myGridColumn1,
            this.colMalzemeAdı,
            this.colReçeteBirimi,
            this.colTermin,
            this.myGridColumn2,
            this.colTeslimat});
            this.TabloSatınalma.GridControl = this.myGridControl1;
            this.TabloSatınalma.Name = "TabloSatınalma";
            this.TabloSatınalma.OptionsFind.FindDelay = 100;
            this.TabloSatınalma.OptionsFind.FindNullPrompt = "Ara";
            this.TabloSatınalma.OptionsFind.ShowFindButton = false;
            this.TabloSatınalma.OptionsMenu.EnableColumnMenu = false;
            this.TabloSatınalma.OptionsMenu.EnableFooterMenu = false;
            this.TabloSatınalma.OptionsMenu.EnableGroupPanelMenu = false;
            this.TabloSatınalma.OptionsNavigation.EnterMoveNextColumn = true;
            this.TabloSatınalma.OptionsPrint.AutoWidth = false;
            this.TabloSatınalma.OptionsPrint.PrintGroupFooter = false;
            this.TabloSatınalma.OptionsView.ColumnAutoWidth = false;
            this.TabloSatınalma.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.TabloSatınalma.OptionsView.RowAutoHeight = true;
            this.TabloSatınalma.OptionsView.ShowGroupPanel = false;
            this.TabloSatınalma.OptionsView.ShowViewCaption = true;
            this.TabloSatınalma.StatusBarAciklama = "Malzeme Kartları";
            this.TabloSatınalma.StatusBarKisayol = "Shift+Insert";
            this.TabloSatınalma.StatusBarKisayolAciklama = "Malzeme Kartı Ekle";
            this.TabloSatınalma.ViewCaption = "Malzemeler";
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
            // colMalzemeAdı
            // 
            this.colMalzemeAdı.Caption = "Malzeme";
            this.colMalzemeAdı.FieldName = "MamülAdı";
            this.colMalzemeAdı.Name = "colMalzemeAdı";
            this.colMalzemeAdı.OptionsColumn.AllowEdit = false;
            this.colMalzemeAdı.OptionsFilter.AllowAutoFilter = false;
            this.colMalzemeAdı.OptionsFilter.AllowFilter = false;
            this.colMalzemeAdı.StatusBarAciklama = null;
            this.colMalzemeAdı.StatusBarKisayol = null;
            this.colMalzemeAdı.StatusBarKisayolAciklama = null;
            this.colMalzemeAdı.Visible = true;
            this.colMalzemeAdı.VisibleIndex = 0;
            this.colMalzemeAdı.Width = 261;
            // 
            // colReçeteBirimi
            // 
            this.colReçeteBirimi.Caption = "Birim";
            this.colReçeteBirimi.FieldName = "MalzemeBirimi";
            this.colReçeteBirimi.Name = "colReçeteBirimi";
            this.colReçeteBirimi.OptionsColumn.AllowEdit = false;
            this.colReçeteBirimi.OptionsFilter.AllowAutoFilter = false;
            this.colReçeteBirimi.OptionsFilter.AllowFilter = false;
            this.colReçeteBirimi.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colReçeteBirimi.StatusBarAciklama = null;
            this.colReçeteBirimi.StatusBarKisayol = null;
            this.colReçeteBirimi.StatusBarKisayolAciklama = null;
            this.colReçeteBirimi.Visible = true;
            this.colReçeteBirimi.VisibleIndex = 1;
            // 
            // colTermin
            // 
            this.colTermin.AppearanceCell.Options.UseTextOptions = true;
            this.colTermin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTermin.Caption = "TerminTarihi";
            this.colTermin.ColumnEdit = this.repositoryItemDateEdit1;
            this.colTermin.FieldName = "TerminTarihi";
            this.colTermin.Name = "colTermin";
            this.colTermin.OptionsColumn.AllowEdit = false;
            this.colTermin.StatusBarAciklama = null;
            this.colTermin.StatusBarKisayol = null;
            this.colTermin.StatusBarKisayolAciklama = null;
            this.colTermin.Visible = true;
            this.colTermin.VisibleIndex = 2;
            this.colTermin.Width = 99;
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
            // myGridColumn2
            // 
            this.myGridColumn2.Caption = "Miktar";
            this.myGridColumn2.ColumnEdit = this.repoSpin;
            this.myGridColumn2.DisplayFormat.FormatString = "{0:n2}";
            this.myGridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.myGridColumn2.FieldName = "Miktar";
            this.myGridColumn2.Name = "myGridColumn2";
            this.myGridColumn2.OptionsColumn.AllowEdit = false;
            this.myGridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.myGridColumn2.OptionsFilter.AllowFilter = false;
            this.myGridColumn2.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.myGridColumn2.StatusBarAciklama = null;
            this.myGridColumn2.StatusBarKisayol = null;
            this.myGridColumn2.StatusBarKisayolAciklama = null;
            this.myGridColumn2.Visible = true;
            this.myGridColumn2.VisibleIndex = 3;
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
            this.colTeslimat.VisibleIndex = 4;
            // 
            // repoCheck
            // 
            this.repoCheck.AutoHeight = false;
            this.repoCheck.Name = "repoCheck";
            // 
            // repoimgaecomboBirim
            // 
            this.repoimgaecomboBirim.AutoHeight = false;
            this.repoimgaecomboBirim.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoimgaecomboBirim.Name = "repoimgaecomboBirim";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
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
            this.Root.Size = new System.Drawing.Size(927, 434);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.myGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(544, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(363, 414);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.Grid;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(544, 414);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // YarıMamülEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 591);
            this.Controls.Add(this.myDataLayoutControl1);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "YarıMamülEditForm";
            this.Text = "YarıMamülEditForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabloSatınalma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimgaecomboBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl1;
        private myUserControls.Grid.myGridControl Grid;
        private myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colId;
        private myUserControls.Grid.MyGridColumn colKod;
        protected myUserControls.Grid.MyGridColumn colFirmaAdi;
        protected myUserControls.Grid.MyGridColumn colTarih;
        private myUserControls.Grid.MyGridColumn colMTipi;
        private myUserControls.Grid.MyGridColumn colÜlke;
        private myUserControls.Grid.MyGridColumn colPersonel;
        private myUserControls.Grid.MyGridColumn colMiktar;
        private myUserControls.Grid.myGridControl myGridControl1;
        public myUserControls.Grid.myGridview TabloSatınalma;
        private myUserControls.Grid.MyGridColumn myGridColumn1;
        private myUserControls.Grid.MyGridColumn colMalzemeAdı;
        private myUserControls.Grid.MyGridColumn colReçeteBirimi;
        private myUserControls.Grid.MyGridColumn colTermin;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private myUserControls.Grid.MyGridColumn myGridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repoSpin;
        private myUserControls.Grid.MyGridColumn colTeslimat;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoimgaecomboBirim;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}