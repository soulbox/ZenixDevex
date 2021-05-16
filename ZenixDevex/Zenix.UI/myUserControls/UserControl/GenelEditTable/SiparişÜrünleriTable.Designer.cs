namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    partial class SiparişÜrünleriTable
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
            this.colÜrün = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKutu = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colStand = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKoli = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMiktar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoSpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colBirim = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoimagecomboBirim = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repoCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colTeslimat = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimagecomboBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpdNavigator
            // 
            this.insUpdNavigator.Location = new System.Drawing.Point(0, 493);
            this.insUpdNavigator.Size = new System.Drawing.Size(831, 24);
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
            this.repoimagecomboBirim});
            this.myGridControl1.Size = new System.Drawing.Size(831, 493);
            this.myGridControl1.TabIndex = 7;
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
            this.colÜrün,
            this.colKutu,
            this.colStand,
            this.colKoli,
            this.colMiktar,
            this.colBirim,
            this.colTeslimat});
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
            this.tablo.ViewCaption = "Ürünler";
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
            // colStand
            // 
            this.colStand.Caption = "Stand";
            this.colStand.FieldName = "Stand";
            this.colStand.Name = "colStand";
            this.colStand.OptionsColumn.AllowEdit = false;
            this.colStand.StatusBarAciklama = null;
            this.colStand.StatusBarKisayol = null;
            this.colStand.StatusBarKisayolAciklama = null;
            this.colStand.Visible = true;
            this.colStand.VisibleIndex = 2;
            // 
            // colKoli
            // 
            this.colKoli.Caption = "Koli";
            this.colKoli.FieldName = "Koli";
            this.colKoli.Name = "colKoli";
            this.colKoli.OptionsColumn.AllowEdit = false;
            this.colKoli.StatusBarAciklama = null;
            this.colKoli.StatusBarKisayol = null;
            this.colKoli.StatusBarKisayolAciklama = null;
            this.colKoli.Visible = true;
            this.colKoli.VisibleIndex = 3;
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
            this.colMiktar.VisibleIndex = 4;
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
            this.colBirim.ColumnEdit = this.repoimagecomboBirim;
            this.colBirim.FieldName = "BirimTipi";
            this.colBirim.Name = "colBirim";
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
            // repoCheck
            // 
            this.repoCheck.AutoHeight = false;
            this.repoCheck.Name = "repoCheck";
            // 
            // colTeslimat
            // 
            this.colTeslimat.Caption = "Teslimat";
            this.colTeslimat.ColumnEdit = this.repoCheck;
            this.colTeslimat.FieldName = "Teslimat";
            this.colTeslimat.Name = "colTeslimat";
            this.colTeslimat.StatusBarAciklama = null;
            this.colTeslimat.StatusBarKisayol = null;
            this.colTeslimat.StatusBarKisayolAciklama = null;
            this.colTeslimat.Visible = true;
            this.colTeslimat.VisibleIndex = 6;
            // 
            // SiparişÜrünleriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myGridControl1);
            this.Name = "SiparişÜrünleriTable";
            this.Size = new System.Drawing.Size(831, 517);
            this.Controls.SetChildIndex(this.insUpdNavigator, 0);
            this.Controls.SetChildIndex(this.myGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimagecomboBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.myGridControl myGridControl1;
        public Grid.myGridview tablo;
        private Grid.MyGridColumn colId;
        private Grid.MyGridColumn colÜrün;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoimagecomboBirim;
        private Grid.MyGridColumn colMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repoSpin;
        private Grid.MyGridColumn colBirim;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheck;
        private Grid.MyGridColumn colKutu;
        private Grid.MyGridColumn colStand;
        private Grid.MyGridColumn colKoli;
        private Grid.MyGridColumn colTeslimat;
    }
}
