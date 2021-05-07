﻿namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    partial class SatınAlmaMalzemeleriTable
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
            this.colReçeteBirimi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colTermin = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colMiktar = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoSpin = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repoCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repoimgaecomboBirim = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colTeslimat = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimgaecomboBirim)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpdNavigator
            // 
            this.insUpdNavigator.Location = new System.Drawing.Point(0, 340);
            this.insUpdNavigator.Size = new System.Drawing.Size(617, 24);
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
            this.repoimgaecomboBirim,
            this.repositoryItemDateEdit1});
            this.myGridControl1.Size = new System.Drawing.Size(617, 340);
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
            this.colMalzemeAdı,
            this.colReçeteBirimi,
            this.colTermin,
            this.colMiktar,
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
            this.colMiktar.VisibleIndex = 3;
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
            // repoCheck
            // 
            this.repoCheck.AutoHeight = false;
            this.repoCheck.Name = "repoCheck";
            this.repoCheck.ValueChecked = ((byte)(1));
            this.repoCheck.ValueGrayed = ((byte)(2));
            this.repoCheck.ValueUnchecked = ((byte)(0));
            // 
            // repoimgaecomboBirim
            // 
            this.repoimgaecomboBirim.AutoHeight = false;
            this.repoimgaecomboBirim.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoimgaecomboBirim.Name = "repoimgaecomboBirim";
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
            this.colTeslimat.VisibleIndex = 4;
            // 
            // SatınAlmaMalzemeleriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myGridControl1);
            this.Name = "SatınAlmaMalzemeleriTable";
            this.Size = new System.Drawing.Size(617, 364);
            this.Controls.SetChildIndex(this.insUpdNavigator, 0);
            this.Controls.SetChildIndex(this.myGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoimgaecomboBirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.myGridControl myGridControl1;
        public Grid.myGridview tablo;
        private Grid.MyGridColumn colId;
        private Grid.MyGridColumn colMalzemeAdı;
        private Grid.MyGridColumn colMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repoSpin;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoimgaecomboBirim;
        private Grid.MyGridColumn colReçeteBirimi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheck;
        private Grid.MyGridColumn colTermin;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private Grid.MyGridColumn colTeslimat;
    }
}
