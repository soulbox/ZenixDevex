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
            this.colkoliadedi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoSpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colKoli = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMiktar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colBirim = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoimagecomboBirim = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colTeslimat = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colStok = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAçıklama = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colParaBirim = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoParabirimi = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colBirimFiyat = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colTutar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimagecomboBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoParabirimi)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpdNavigator
            // 
            this.insUpdNavigator.Location = new System.Drawing.Point(0, 493);
            this.insUpdNavigator.Size = new System.Drawing.Size(1206, 24);
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
            this.repoimagecomboBirim,
            this.repositoryItemTextEdit1,
            this.repoParabirimi});
            this.myGridControl1.Size = new System.Drawing.Size(1206, 493);
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
            this.colkoliadedi,
            this.colKoli,
            this.colMiktar,
            this.colBirim,
            this.colTeslimat,
            this.colStok,
            this.colAçıklama,
            this.colParaBirim,
            this.colBirimFiyat,
            this.colTutar});
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
            // colkoliadedi
            // 
            this.colkoliadedi.Caption = "Koli Adedi";
            this.colkoliadedi.ColumnEdit = this.repoSpin;
            this.colkoliadedi.FieldName = "KoliAdedi";
            this.colkoliadedi.Name = "colkoliadedi";
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
            // colAçıklama
            // 
            this.colAçıklama.Caption = "Açıklama";
            this.colAçıklama.ColumnEdit = this.repositoryItemTextEdit1;
            this.colAçıklama.FieldName = "Açıklama";
            this.colAçıklama.Name = "colAçıklama";
            this.colAçıklama.StatusBarAciklama = null;
            this.colAçıklama.StatusBarKisayol = null;
            this.colAçıklama.StatusBarKisayolAciklama = null;
            this.colAçıklama.Visible = true;
            this.colAçıklama.VisibleIndex = 7;
            this.colAçıklama.Width = 100;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colParaBirim
            // 
            this.colParaBirim.Caption = "ParaBirim";
            this.colParaBirim.ColumnEdit = this.repoParabirimi;
            this.colParaBirim.FieldName = "ParaBirimi";
            this.colParaBirim.Name = "colParaBirim";
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
            // SiparişÜrünleriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myGridControl1);
            this.Name = "SiparişÜrünleriTable";
            this.Size = new System.Drawing.Size(1206, 517);
            this.Controls.SetChildIndex(this.insUpdNavigator, 0);
            this.Controls.SetChildIndex(this.myGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimagecomboBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoParabirimi)).EndInit();
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
        private Grid.MyGridColumn colkoliadedi;
        private Grid.MyGridColumn colKoli;
        private Grid.MyGridColumn colTeslimat;
        private Grid.MyGridColumn colStok;
        private Grid.MyGridColumn colAçıklama;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private Grid.MyGridColumn colParaBirim;
        private Grid.MyGridColumn colBirimFiyat;
        private Grid.MyGridColumn colTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoParabirimi;
    }
}
