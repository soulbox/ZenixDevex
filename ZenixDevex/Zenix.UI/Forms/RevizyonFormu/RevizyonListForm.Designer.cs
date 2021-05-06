namespace Zenix.WinUI.Forms.RevizyonFormu
{
    partial class RevizyonListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevizyonListForm));
            this.myBandedGridControl1 = new Zenix.WinUI.myUserControls.Grid.myBandedGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myBandedGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMarka = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colFirma = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMalzeme = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colGTIN = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.colRevizyonKodu = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colRevTarihi = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAçıklama = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.aaaa = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBandedGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
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
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // myBandedGridControl1
            // 
            this.myBandedGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myBandedGridControl1.Location = new System.Drawing.Point(0, 109);
            this.myBandedGridControl1.MainView = this.Tablo;
            this.myBandedGridControl1.MenuManager = this.ribbonControl;
            this.myBandedGridControl1.Name = "myBandedGridControl1";
            this.myBandedGridControl1.Size = new System.Drawing.Size(952, 357);
            this.myBandedGridControl1.TabIndex = 8;
            this.myBandedGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Tablo});
            // 
            // Tablo
            // 
            this.Tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.Tablo.Appearance.BandPanel.Options.UseFont = true;
            this.Tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.Tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.Tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.Tablo.BandPanelRowHeight = 28;
            this.Tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.aaaa,
            this.gridBand1});
            this.Tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colMarka,
            this.colFirma,
            this.colMalzeme,
            this.colGTIN,
            this.colRevizyonKodu,
            this.colRevTarihi,
            this.colAçıklama});
            this.Tablo.GridControl = this.myBandedGridControl1;
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
            this.Tablo.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.Tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
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
            // 
            // colMarka
            // 
            this.colMarka.Caption = "Marka";
            this.colMarka.FieldName = "MarkaAdı";
            this.colMarka.Name = "colMarka";
            this.colMarka.OptionsColumn.AllowEdit = false;
            this.colMarka.StatusBarAciklama = null;
            this.colMarka.StatusBarKisayol = null;
            this.colMarka.StatusBarKisayolAciklama = null;
            this.colMarka.Visible = true;
            this.colMarka.Width = 200;
            // 
            // colFirma
            // 
            this.colFirma.Caption = "Firma";
            this.colFirma.FieldName = "FirmaAdi";
            this.colFirma.Name = "colFirma";
            this.colFirma.OptionsColumn.AllowEdit = false;
            this.colFirma.StatusBarAciklama = null;
            this.colFirma.StatusBarKisayol = null;
            this.colFirma.StatusBarKisayolAciklama = null;
            this.colFirma.Visible = true;
            this.colFirma.Width = 200;
            // 
            // colMalzeme
            // 
            this.colMalzeme.Caption = "Ürün";
            this.colMalzeme.FieldName = "MamülAdı";
            this.colMalzeme.Name = "colMalzeme";
            this.colMalzeme.OptionsColumn.AllowEdit = false;
            this.colMalzeme.StatusBarAciklama = null;
            this.colMalzeme.StatusBarKisayol = null;
            this.colMalzeme.StatusBarKisayolAciklama = null;
            this.colMalzeme.Visible = true;
            this.colMalzeme.Width = 200;
            // 
            // colGTIN
            // 
            this.colGTIN.Caption = "GTIN";
            this.colGTIN.FieldName = "GTIN";
            this.colGTIN.Name = "colGTIN";
            this.colGTIN.OptionsColumn.AllowEdit = false;
            this.colGTIN.StatusBarAciklama = null;
            this.colGTIN.StatusBarKisayol = null;
            this.colGTIN.StatusBarKisayolAciklama = null;
            this.colGTIN.Visible = true;
            this.colGTIN.Width = 115;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 466);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(952, 24);
            this.longNavigator.TabIndex = 7;
            // 
            // colRevizyonKodu
            // 
            this.colRevizyonKodu.Caption = "Revizyon Kodu";
            this.colRevizyonKodu.FieldName = "RevKodu";
            this.colRevizyonKodu.Name = "colRevizyonKodu";
            this.colRevizyonKodu.OptionsColumn.AllowEdit = false;
            this.colRevizyonKodu.StatusBarAciklama = null;
            this.colRevizyonKodu.StatusBarKisayol = null;
            this.colRevizyonKodu.StatusBarKisayolAciklama = null;
            this.colRevizyonKodu.Visible = true;
            // 
            // colRevTarihi
            // 
            this.colRevTarihi.Caption = "Revizyon Tarihi";
            this.colRevTarihi.FieldName = "RevizyonTarihi";
            this.colRevTarihi.Name = "colRevTarihi";
            this.colRevTarihi.OptionsColumn.AllowEdit = false;
            this.colRevTarihi.StatusBarAciklama = null;
            this.colRevTarihi.StatusBarKisayol = null;
            this.colRevTarihi.StatusBarKisayolAciklama = null;
            this.colRevTarihi.Visible = true;
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
            this.colAçıklama.Width = 150;
            // 
            // aaaa
            // 
            this.aaaa.Caption = "Ürün Tanımı";
            this.aaaa.Columns.Add(this.colId);
            this.aaaa.Columns.Add(this.colKod);
            this.aaaa.Columns.Add(this.colMarka);
            this.aaaa.Columns.Add(this.colFirma);
            this.aaaa.Columns.Add(this.colMalzeme);
            this.aaaa.Columns.Add(this.colGTIN);
            this.aaaa.Name = "aaaa";
            this.aaaa.VisibleIndex = 0;
            this.aaaa.Width = 790;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Revizyon Bilgileri";
            this.gridBand1.Columns.Add(this.colRevizyonKodu);
            this.gridBand1.Columns.Add(this.colRevTarihi);
            this.gridBand1.Columns.Add(this.colAçıklama);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 1;
            this.gridBand1.Width = 300;
            // 
            // ReziyonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 514);
            this.Controls.Add(this.myBandedGridControl1);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "ReziyonListForm";
            this.Text = "ReziyonListForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.myBandedGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBandedGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Grid.myBandedGridControl myBandedGridControl1;
        private myUserControls.Grid.myBandedGridview Tablo;
        private myUserControls.Grid.myBandedGridColumn colId;
        private myUserControls.Grid.myBandedGridColumn colKod;
        private myUserControls.Grid.myBandedGridColumn colMarka;
        private myUserControls.Grid.myBandedGridColumn colFirma;
        private myUserControls.Grid.myBandedGridColumn colMalzeme;
        private myUserControls.Grid.myBandedGridColumn colGTIN;
        private myUserControls.Grid.myBandedGridColumn colRevizyonKodu;
        private myUserControls.Grid.myBandedGridColumn colRevTarihi;
        private myUserControls.Navigator.LongNavigator longNavigator;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand aaaa;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private myUserControls.Grid.myBandedGridColumn colAçıklama;
    }
}