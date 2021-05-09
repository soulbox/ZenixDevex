namespace Zenix.WinUI.Forms.İşemriFormu
{
    partial class İşemriListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İşemriListForm));
            this.myBandedGridControl1 = new Zenix.WinUI.myUserControls.Grid.myBandedGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myBandedGridview();
            this.aaaa = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colId = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colİşemriNo = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colŞarj = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colŞarjMiktarı = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMarka = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colFirma = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMalzeme = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colGTIN = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colEXP = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colRevizyonKodu = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
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
            this.ribbonControl.Size = new System.Drawing.Size(1122, 109);
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
            this.myBandedGridControl1.Size = new System.Drawing.Size(1122, 433);
            this.myBandedGridControl1.TabIndex = 12;
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
            this.colİşemriNo,
            this.colKod,
            this.colMarka,
            this.colFirma,
            this.colMalzeme,
            this.colGTIN,
            this.colRevizyonKodu,
            this.colŞarj,
            this.colEXP,
            this.colŞarjMiktarı});
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
            this.Tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.Tablo.OptionsView.RowAutoHeight = true;
            this.Tablo.OptionsView.ShowAutoFilterRow = true;
            this.Tablo.OptionsView.ShowBands = false;
            this.Tablo.OptionsView.ShowGroupPanel = false;
            this.Tablo.OptionsView.ShowViewCaption = true;
            this.Tablo.StatusBarAciklama = null;
            this.Tablo.StatusBarKisayol = null;
            this.Tablo.StatusBarKisayolAciklama = null;
            // 
            // aaaa
            // 
            this.aaaa.Caption = "Ürün Tanımı";
            this.aaaa.Columns.Add(this.colId);
            this.aaaa.Columns.Add(this.colKod);
            this.aaaa.Columns.Add(this.colİşemriNo);
            this.aaaa.Columns.Add(this.colŞarj);
            this.aaaa.Columns.Add(this.colŞarjMiktarı);
            this.aaaa.Columns.Add(this.colMarka);
            this.aaaa.Columns.Add(this.colFirma);
            this.aaaa.Columns.Add(this.colMalzeme);
            this.aaaa.Columns.Add(this.colGTIN);
            this.aaaa.Columns.Add(this.colEXP);
            this.aaaa.Name = "aaaa";
            this.aaaa.VisibleIndex = 0;
            this.aaaa.Width = 1090;
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
            // colİşemriNo
            // 
            this.colİşemriNo.Caption = "İş Emri No";
            this.colİşemriNo.FieldName = "işemriNo";
            this.colİşemriNo.Name = "colİşemriNo";
            this.colİşemriNo.OptionsColumn.AllowEdit = false;
            this.colİşemriNo.StatusBarAciklama = null;
            this.colİşemriNo.StatusBarKisayol = null;
            this.colİşemriNo.StatusBarKisayolAciklama = null;
            this.colİşemriNo.Visible = true;
            // 
            // colŞarj
            // 
            this.colŞarj.Caption = "Şarj No";
            this.colŞarj.FieldName = "ŞarjNo";
            this.colŞarj.Name = "colŞarj";
            this.colŞarj.OptionsColumn.AllowEdit = false;
            this.colŞarj.StatusBarAciklama = null;
            this.colŞarj.StatusBarKisayol = null;
            this.colŞarj.StatusBarKisayolAciklama = null;
            this.colŞarj.Visible = true;
            // 
            // colŞarjMiktarı
            // 
            this.colŞarjMiktarı.Caption = "Şarj";
            this.colŞarjMiktarı.FieldName = "ŞarjMiktarı";
            this.colŞarjMiktarı.Name = "colŞarjMiktarı";
            this.colŞarjMiktarı.OptionsColumn.AllowEdit = false;
            this.colŞarjMiktarı.StatusBarAciklama = null;
            this.colŞarjMiktarı.StatusBarKisayol = null;
            this.colŞarjMiktarı.StatusBarKisayolAciklama = null;
            this.colŞarjMiktarı.Visible = true;
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
            // colEXP
            // 
            this.colEXP.Caption = "SKT";
            this.colEXP.FieldName = "EXP";
            this.colEXP.Name = "colEXP";
            this.colEXP.OptionsColumn.AllowEdit = false;
            this.colEXP.StatusBarAciklama = null;
            this.colEXP.StatusBarKisayol = null;
            this.colEXP.StatusBarKisayolAciklama = null;
            this.colEXP.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Reçete Bilgileri";
            this.gridBand1.Columns.Add(this.colRevizyonKodu);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 1;
            this.gridBand1.Width = 75;
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
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 542);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1122, 24);
            this.longNavigator.TabIndex = 11;
            // 
            // İşemriListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 590);
            this.Controls.Add(this.myBandedGridControl1);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "İşemriListForm";
            this.Text = "İşemriListForm";
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
        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Grid.myBandedGridColumn colİşemriNo;
        private myUserControls.Grid.myBandedGridColumn colŞarj;
        private myUserControls.Grid.myBandedGridColumn colEXP;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand aaaa;
        private myUserControls.Grid.myBandedGridColumn colŞarjMiktarı;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    }
}