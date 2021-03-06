namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    partial class ReçeteMalzemeleriTable
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMalzemeAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colFazTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoimagecomboFaz = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colMalzemeİçiÜrün = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoSpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colMiktar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAşamaTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoimgaecomboAşama = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colReçeteBirimi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMalzemeTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colStok = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colYarıMamül = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYarıId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYarıMamülAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repoCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colYarıMamülStok = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimagecomboFaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimgaecomboAşama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpdNavigator
            // 
            this.insUpdNavigator.Location = new System.Drawing.Point(0, 325);
            this.insUpdNavigator.Size = new System.Drawing.Size(849, 24);
            // 
            // myGridControl1
            // 
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.tablo;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheck,
            this.repoSpin,
            this.repoCombo,
            this.repoimagecomboFaz,
            this.repoimgaecomboAşama,
            this.repositoryItemGridLookUpEdit1});
            this.myGridControl1.Size = new System.Drawing.Size(849, 325);
            this.myGridControl1.TabIndex = 6;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            this.myGridControl1.Click += new System.EventHandler(this.myGridControl1_Click);
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.tablo.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMalzemeAdı,
            this.colFazTipi,
            this.colMalzemeİçiÜrün,
            this.colMiktar,
            this.colAşamaTipi,
            this.colReçeteBirimi,
            this.colMalzemeTipi,
            this.colStok,
            this.colYarıMamül,
            this.colYarıMamülStok});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Kimyasal Renkler";
            formatConditionRuleExpression1.Expression = "Contains([MalzemeTipi], \'madde\') Or Contains([MalzemeTipi], \'sans\')";
            formatConditionRuleExpression1.PredefinedName = "Green Fill";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.tablo.FormatRules.Add(gridFormatRule1);
            this.tablo.GridControl = this.myGridControl1;
            this.tablo.Name = "tablo";
            this.tablo.OptionsFind.FindDelay = 100;
            this.tablo.OptionsFind.FindNullPrompt = "Ara";
            this.tablo.OptionsFind.ShowFindButton = false;
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Malzeme Kartları";
            this.tablo.StatusBarKisayol = "Shift+Insert";
            this.tablo.StatusBarKisayolAciklama = "Malzeme Kartı Ekle";
            this.tablo.ViewCaption = "Malzemeleri";
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
            this.colMalzemeAdı.Width = 233;
            // 
            // colFazTipi
            // 
            this.colFazTipi.Caption = "Faz Tipi";
            this.colFazTipi.ColumnEdit = this.repoimagecomboFaz;
            this.colFazTipi.FieldName = "FazTipi";
            this.colFazTipi.Name = "colFazTipi";
            this.colFazTipi.OptionsFilter.AllowAutoFilter = false;
            this.colFazTipi.OptionsFilter.AllowFilter = false;
            this.colFazTipi.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colFazTipi.StatusBarAciklama = "Faz Tipini Seçiniz";
            this.colFazTipi.StatusBarKisayol = null;
            this.colFazTipi.StatusBarKisayolAciklama = null;
            this.colFazTipi.Visible = true;
            this.colFazTipi.VisibleIndex = 2;
            // 
            // repoimagecomboFaz
            // 
            this.repoimagecomboFaz.AutoHeight = false;
            this.repoimagecomboFaz.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoimagecomboFaz.CaseSensitiveSearch = true;
            this.repoimagecomboFaz.Name = "repoimagecomboFaz";
            // 
            // colMalzemeİçiÜrün
            // 
            this.colMalzemeİçiÜrün.Caption = "MalzemeMiktarı";
            this.colMalzemeİçiÜrün.ColumnEdit = this.repoSpin;
            this.colMalzemeİçiÜrün.FieldName = "MalzemeİçiÜrün";
            this.colMalzemeİçiÜrün.Name = "colMalzemeİçiÜrün";
            this.colMalzemeİçiÜrün.StatusBarAciklama = "Ürün içi Malzeme Miktarını Giriniz.";
            this.colMalzemeİçiÜrün.StatusBarKisayol = null;
            this.colMalzemeİçiÜrün.StatusBarKisayolAciklama = null;
            this.colMalzemeİçiÜrün.Visible = true;
            this.colMalzemeİçiÜrün.VisibleIndex = 4;
            this.colMalzemeİçiÜrün.Width = 94;
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
            // colMiktar
            // 
            this.colMiktar.Caption = "%Miktar(100kg)";
            this.colMiktar.ColumnEdit = this.repoSpin;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsFilter.AllowAutoFilter = false;
            this.colMiktar.OptionsFilter.AllowFilter = false;
            this.colMiktar.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colMiktar.StatusBarAciklama = "Kimyasal Oranını Giriniz.";
            this.colMiktar.StatusBarKisayol = null;
            this.colMiktar.StatusBarKisayolAciklama = null;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 3;
            this.colMiktar.Width = 89;
            // 
            // colAşamaTipi
            // 
            this.colAşamaTipi.Caption = "Aşama Tipi";
            this.colAşamaTipi.ColumnEdit = this.repoimgaecomboAşama;
            this.colAşamaTipi.FieldName = "AşamaTipi";
            this.colAşamaTipi.Name = "colAşamaTipi";
            this.colAşamaTipi.StatusBarAciklama = "Malzemelerin Aşamalarını Seçiniz";
            this.colAşamaTipi.StatusBarKisayol = null;
            this.colAşamaTipi.StatusBarKisayolAciklama = null;
            this.colAşamaTipi.Width = 106;
            // 
            // repoimgaecomboAşama
            // 
            this.repoimgaecomboAşama.AutoHeight = false;
            this.repoimgaecomboAşama.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoimgaecomboAşama.Name = "repoimgaecomboAşama";
            // 
            // colReçeteBirimi
            // 
            this.colReçeteBirimi.Caption = "Birim";
            this.colReçeteBirimi.FieldName = "ReçeteBirimi";
            this.colReçeteBirimi.Name = "colReçeteBirimi";
            this.colReçeteBirimi.OptionsFilter.AllowAutoFilter = false;
            this.colReçeteBirimi.OptionsFilter.AllowFilter = false;
            this.colReçeteBirimi.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colReçeteBirimi.StatusBarAciklama = "Birim Seçiniz.";
            this.colReçeteBirimi.StatusBarKisayol = null;
            this.colReçeteBirimi.StatusBarKisayolAciklama = null;
            this.colReçeteBirimi.Visible = true;
            this.colReçeteBirimi.VisibleIndex = 6;
            // 
            // colMalzemeTipi
            // 
            this.colMalzemeTipi.Caption = "Malzeme Tipi";
            this.colMalzemeTipi.FieldName = "MalzemeTipi";
            this.colMalzemeTipi.Name = "colMalzemeTipi";
            this.colMalzemeTipi.OptionsColumn.AllowEdit = false;
            this.colMalzemeTipi.StatusBarAciklama = null;
            this.colMalzemeTipi.StatusBarKisayol = null;
            this.colMalzemeTipi.StatusBarKisayolAciklama = null;
            this.colMalzemeTipi.Visible = true;
            this.colMalzemeTipi.VisibleIndex = 1;
            // 
            // colStok
            // 
            this.colStok.Caption = "Stok";
            this.colStok.DisplayFormat.FormatString = "{0:n0}";
            this.colStok.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colStok.FieldName = "Stok";
            this.colStok.Name = "colStok";
            this.colStok.OptionsColumn.AllowEdit = false;
            this.colStok.StatusBarAciklama = null;
            this.colStok.StatusBarKisayol = null;
            this.colStok.StatusBarKisayolAciklama = null;
            this.colStok.Visible = true;
            this.colStok.VisibleIndex = 7;
            // 
            // colYarıMamül
            // 
            this.colYarıMamül.Caption = "Yarı Mamül";
            this.colYarıMamül.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colYarıMamül.FieldName = "YarıMamülId";
            this.colYarıMamül.Name = "colYarıMamül";
            this.colYarıMamül.StatusBarAciklama = null;
            this.colYarıMamül.StatusBarKisayol = null;
            this.colYarıMamül.StatusBarKisayolAciklama = null;
            this.colYarıMamül.Visible = true;
            this.colYarıMamül.VisibleIndex = 5;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "YarıMamülAdı";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "Id";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYarıId,
            this.colYarıMamülAdı});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colYarıId
            // 
            this.colYarıId.Caption = "Id";
            this.colYarıId.FieldName = "Id";
            this.colYarıId.Name = "colYarıId";
            // 
            // colYarıMamülAdı
            // 
            this.colYarıMamülAdı.Caption = "Yarı Mamül";
            this.colYarıMamülAdı.FieldName = "YarıMamülAdı";
            this.colYarıMamülAdı.Name = "colYarıMamülAdı";
            this.colYarıMamülAdı.OptionsColumn.AllowEdit = false;
            this.colYarıMamülAdı.Visible = true;
            this.colYarıMamülAdı.VisibleIndex = 0;
            // 
            // repoCheck
            // 
            this.repoCheck.AutoHeight = false;
            this.repoCheck.Name = "repoCheck";
            this.repoCheck.ValueChecked = ((byte)(1));
            this.repoCheck.ValueGrayed = ((byte)(2));
            this.repoCheck.ValueUnchecked = ((byte)(0));
            // 
            // repoCombo
            // 
            this.repoCombo.AutoHeight = false;
            this.repoCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCombo.Name = "repoCombo";
            this.repoCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colYarıMamülStok
            // 
            this.colYarıMamülStok.Caption = "Y.M. Stok";
            this.colYarıMamülStok.FieldName = "YarıMamülStok";
            this.colYarıMamülStok.Name = "colYarıMamülStok";
            this.colYarıMamülStok.OptionsColumn.AllowEdit = false;
            this.colYarıMamülStok.StatusBarAciklama = null;
            this.colYarıMamülStok.StatusBarKisayol = null;
            this.colYarıMamülStok.StatusBarKisayolAciklama = null;
            this.colYarıMamülStok.Visible = true;
            this.colYarıMamülStok.VisibleIndex = 8;
            // 
            // ReçeteMalzemeleriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myGridControl1);
            this.Name = "ReçeteMalzemeleriTable";
            this.Size = new System.Drawing.Size(849, 349);
            this.Controls.SetChildIndex(this.insUpdNavigator, 0);
            this.Controls.SetChildIndex(this.myGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimagecomboFaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimgaecomboAşama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCombo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.myGridControl myGridControl1;
        public Grid.myGridview tablo;
        private Grid.MyGridColumn colId;
        private Grid.MyGridColumn colMalzemeAdı;
        private Grid.MyGridColumn colMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheck;
        private Grid.MyGridColumn colReçeteBirimi;
        private Grid.MyGridColumn colFazTipi;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repoSpin;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repoCombo;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoimagecomboFaz;
        private Grid.MyGridColumn colAşamaTipi;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoimgaecomboAşama;
        private Grid.MyGridColumn colMalzemeİçiÜrün;
        private Grid.MyGridColumn colMalzemeTipi;
        private Grid.MyGridColumn colStok;
        private Grid.MyGridColumn colYarıMamül;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colYarıId;
        private DevExpress.XtraGrid.Columns.GridColumn colYarıMamülAdı;
        private Grid.MyGridColumn colYarıMamülStok;
    }
}
