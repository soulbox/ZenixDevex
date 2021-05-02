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
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMalzemeAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMiktar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoSpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colBirim = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colFazTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repoCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repoimagecombo = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimagecombo)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpdNavigator
            // 
            this.insUpdNavigator.Location = new System.Drawing.Point(0, 330);
            this.insUpdNavigator.Size = new System.Drawing.Size(493, 24);
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
            this.repoimagecombo});
            this.myGridControl1.Size = new System.Drawing.Size(493, 330);
            this.myGridControl1.TabIndex = 6;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
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
            this.colMiktar,
            this.colBirim});
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
            this.colMalzemeAdı.FieldName = "MalzemeAdı";
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
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.ColumnEdit = this.repoSpin;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsFilter.AllowAutoFilter = false;
            this.colMiktar.OptionsFilter.AllowFilter = false;
            this.colMiktar.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colMiktar.StatusBarAciklama = null;
            this.colMiktar.StatusBarKisayol = null;
            this.colMiktar.StatusBarKisayolAciklama = null;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 2;
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
            // colBirim
            // 
            this.colBirim.Caption = "Birim";
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.OptionsFilter.AllowAutoFilter = false;
            this.colBirim.OptionsFilter.AllowFilter = false;
            this.colBirim.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colBirim.StatusBarAciklama = null;
            this.colBirim.StatusBarKisayol = null;
            this.colBirim.StatusBarKisayolAciklama = null;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 3;
            // 
            // colFazTipi
            // 
            this.colFazTipi.Caption = "Faz Tipi";
            this.colFazTipi.ColumnEdit = this.repoimagecombo;
            this.colFazTipi.FieldName = "FazTipi";
            this.colFazTipi.Name = "colFazTipi";
            this.colFazTipi.OptionsFilter.AllowAutoFilter = false;
            this.colFazTipi.OptionsFilter.AllowFilter = false;
            this.colFazTipi.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colFazTipi.StatusBarAciklama = "Faz Tipini Seçiniz";
            this.colFazTipi.StatusBarKisayol = null;
            this.colFazTipi.StatusBarKisayolAciklama = null;
            this.colFazTipi.Visible = true;
            this.colFazTipi.VisibleIndex = 1;
            // 
            // repoCombo
            // 
            this.repoCombo.AutoHeight = false;
            this.repoCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCombo.Name = "repoCombo";
            this.repoCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repoCheck
            // 
            this.repoCheck.AutoHeight = false;
            this.repoCheck.Name = "repoCheck";
            this.repoCheck.ValueChecked = ((byte)(1));
            this.repoCheck.ValueGrayed = ((byte)(2));
            this.repoCheck.ValueUnchecked = ((byte)(0));
            // 
            // repoimagecombo
            // 
            this.repoimagecombo.AutoHeight = false;
            this.repoimagecombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoimagecombo.CaseSensitiveSearch = true;
            this.repoimagecombo.Name = "repoimagecombo";
            // 
            // ReçeteMalzemeleriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myGridControl1);
            this.Name = "ReçeteMalzemeleriTable";
            this.Size = new System.Drawing.Size(493, 354);
            this.Controls.SetChildIndex(this.insUpdNavigator, 0);
            this.Controls.SetChildIndex(this.myGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimagecombo)).EndInit();
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
        private Grid.MyGridColumn colBirim;
        private Grid.MyGridColumn colFazTipi;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repoSpin;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repoCombo;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoimagecombo;
    }
}
