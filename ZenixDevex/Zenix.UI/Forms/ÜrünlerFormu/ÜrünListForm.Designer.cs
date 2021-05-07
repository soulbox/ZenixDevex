namespace Zenix.WinUI.Forms.ÜrünlerFormu
{
    partial class ÜrünListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜrünListForm));
            this.myBandedGridControl1 = new Zenix.WinUI.myUserControls.Grid.myBandedGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myBandedGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMarka = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colFirma = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMalzeme = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colGTIN = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colkutu = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colStand = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colKoli = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colHacim = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMalzemeBirimi = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMalzemeTipi = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAmbalajTipi = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAmbalajMaddes = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colSarfTipi = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAğızÖlçüsü = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colUzunluk = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colEn = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colboy = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colYükseklik = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAlan = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAğırlık = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
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
            this.myBandedGridControl1.TabIndex = 6;
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
            this.gridBand11,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.Tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colMarka,
            this.colFirma,
            this.colMalzeme,
            this.colGTIN,
            this.colkutu,
            this.colStand,
            this.colKoli,
            this.colMalzemeBirimi,
            this.colMalzemeTipi,
            this.colAmbalajTipi,
            this.colAmbalajMaddes,
            this.colSarfTipi,
            this.colHacim,
            this.colAğızÖlçüsü,
            this.colUzunluk,
            this.colEn,
            this.colboy,
            this.colYükseklik,
            this.colAlan,
            this.colAğırlık});
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
            // 
            // colkutu
            // 
            this.colkutu.Caption = "Kutu";
            this.colkutu.FieldName = "Kutu";
            this.colkutu.Name = "colkutu";
            this.colkutu.OptionsColumn.AllowEdit = false;
            this.colkutu.StatusBarAciklama = null;
            this.colkutu.StatusBarKisayol = null;
            this.colkutu.StatusBarKisayolAciklama = null;
            this.colkutu.Visible = true;
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
            // 
            // colHacim
            // 
            this.colHacim.Caption = "Hacim";
            this.colHacim.FieldName = "Hacim";
            this.colHacim.Name = "colHacim";
            this.colHacim.OptionsColumn.AllowEdit = false;
            this.colHacim.StatusBarAciklama = null;
            this.colHacim.StatusBarKisayol = null;
            this.colHacim.StatusBarKisayolAciklama = null;
            this.colHacim.Visible = true;
            this.colHacim.Width = 50;
            // 
            // colMalzemeBirimi
            // 
            this.colMalzemeBirimi.Caption = "Birim";
            this.colMalzemeBirimi.FieldName = "MalzemeBirimi";
            this.colMalzemeBirimi.Name = "colMalzemeBirimi";
            this.colMalzemeBirimi.OptionsColumn.AllowEdit = false;
            this.colMalzemeBirimi.StatusBarAciklama = null;
            this.colMalzemeBirimi.StatusBarKisayol = null;
            this.colMalzemeBirimi.StatusBarKisayolAciklama = null;
            this.colMalzemeBirimi.Visible = true;
            this.colMalzemeBirimi.Width = 50;
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
            // 
            // colAmbalajTipi
            // 
            this.colAmbalajTipi.Caption = "Ambalaj Tipi";
            this.colAmbalajTipi.FieldName = "AmbalajTipiAdı";
            this.colAmbalajTipi.Name = "colAmbalajTipi";
            this.colAmbalajTipi.OptionsColumn.AllowEdit = false;
            this.colAmbalajTipi.StatusBarAciklama = null;
            this.colAmbalajTipi.StatusBarKisayol = null;
            this.colAmbalajTipi.StatusBarKisayolAciklama = null;
            this.colAmbalajTipi.Visible = true;
            // 
            // colAmbalajMaddes
            // 
            this.colAmbalajMaddes.Caption = "Ambalaj Maddesi";
            this.colAmbalajMaddes.FieldName = "AmbalajMaddeAdı";
            this.colAmbalajMaddes.Name = "colAmbalajMaddes";
            this.colAmbalajMaddes.OptionsColumn.AllowEdit = false;
            this.colAmbalajMaddes.StatusBarAciklama = null;
            this.colAmbalajMaddes.StatusBarKisayol = null;
            this.colAmbalajMaddes.StatusBarKisayolAciklama = null;
            this.colAmbalajMaddes.Visible = true;
            // 
            // colSarfTipi
            // 
            this.colSarfTipi.Caption = "Sarf Tipi";
            this.colSarfTipi.FieldName = "SarfTipi";
            this.colSarfTipi.Name = "colSarfTipi";
            this.colSarfTipi.OptionsColumn.AllowEdit = false;
            this.colSarfTipi.StatusBarAciklama = null;
            this.colSarfTipi.StatusBarKisayol = null;
            this.colSarfTipi.StatusBarKisayolAciklama = null;
            this.colSarfTipi.Visible = true;
            // 
            // colAğızÖlçüsü
            // 
            this.colAğızÖlçüsü.Caption = "Ağız Ölçüsü";
            this.colAğızÖlçüsü.FieldName = "BirimAğızÖlçüsü";
            this.colAğızÖlçüsü.Name = "colAğızÖlçüsü";
            this.colAğızÖlçüsü.OptionsColumn.AllowEdit = false;
            this.colAğızÖlçüsü.StatusBarAciklama = null;
            this.colAğızÖlçüsü.StatusBarKisayol = null;
            this.colAğızÖlçüsü.StatusBarKisayolAciklama = null;
            this.colAğızÖlçüsü.Visible = true;
            // 
            // colUzunluk
            // 
            this.colUzunluk.Caption = "Uzunluk";
            this.colUzunluk.FieldName = "BirimUzunluk";
            this.colUzunluk.Name = "colUzunluk";
            this.colUzunluk.OptionsColumn.AllowEdit = false;
            this.colUzunluk.StatusBarAciklama = null;
            this.colUzunluk.StatusBarKisayol = null;
            this.colUzunluk.StatusBarKisayolAciklama = null;
            this.colUzunluk.Visible = true;
            // 
            // colEn
            // 
            this.colEn.Caption = "En";
            this.colEn.FieldName = "BirimEn";
            this.colEn.Name = "colEn";
            this.colEn.OptionsColumn.AllowEdit = false;
            this.colEn.StatusBarAciklama = null;
            this.colEn.StatusBarKisayol = null;
            this.colEn.StatusBarKisayolAciklama = null;
            this.colEn.Visible = true;
            this.colEn.Width = 50;
            // 
            // colboy
            // 
            this.colboy.Caption = "Boy";
            this.colboy.FieldName = "BirimBoy";
            this.colboy.Name = "colboy";
            this.colboy.OptionsColumn.AllowEdit = false;
            this.colboy.StatusBarAciklama = null;
            this.colboy.StatusBarKisayol = null;
            this.colboy.StatusBarKisayolAciklama = null;
            this.colboy.Visible = true;
            this.colboy.Width = 50;
            // 
            // colYükseklik
            // 
            this.colYükseklik.Caption = "Yükseklik";
            this.colYükseklik.FieldName = "BirimYükseklik";
            this.colYükseklik.Name = "colYükseklik";
            this.colYükseklik.OptionsColumn.AllowEdit = false;
            this.colYükseklik.StatusBarAciklama = null;
            this.colYükseklik.StatusBarKisayol = null;
            this.colYükseklik.StatusBarKisayolAciklama = null;
            this.colYükseklik.Visible = true;
            // 
            // colAlan
            // 
            this.colAlan.Caption = "Alan";
            this.colAlan.FieldName = "BirimAlan";
            this.colAlan.Name = "colAlan";
            this.colAlan.OptionsColumn.AllowEdit = false;
            this.colAlan.StatusBarAciklama = null;
            this.colAlan.StatusBarKisayol = null;
            this.colAlan.StatusBarKisayolAciklama = null;
            this.colAlan.Visible = true;
            this.colAlan.Width = 50;
            // 
            // colAğırlık
            // 
            this.colAğırlık.Caption = "Ağırlık";
            this.colAğırlık.FieldName = "BirimAğırlık";
            this.colAğırlık.Name = "colAğırlık";
            this.colAğırlık.OptionsColumn.AllowEdit = false;
            this.colAğırlık.StatusBarAciklama = null;
            this.colAğırlık.StatusBarKisayol = null;
            this.colAğırlık.StatusBarKisayolAciklama = null;
            this.colAğırlık.Visible = true;
            this.colAğırlık.Width = 50;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 466);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(952, 24);
            this.longNavigator.TabIndex = 5;
            // 
            // gridBand11
            // 
            this.gridBand11.Caption = "Ürün Tanımı";
            this.gridBand11.Columns.Add(this.colId);
            this.gridBand11.Columns.Add(this.colKod);
            this.gridBand11.Columns.Add(this.colMarka);
            this.gridBand11.Columns.Add(this.colFirma);
            this.gridBand11.Columns.Add(this.colMalzeme);
            this.gridBand11.Columns.Add(this.colGTIN);
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.VisibleIndex = 0;
            this.gridBand11.Width = 750;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "İçerik";
            this.gridBand2.Columns.Add(this.colkutu);
            this.gridBand2.Columns.Add(this.colStand);
            this.gridBand2.Columns.Add(this.colKoli);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 225;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Tipi";
            this.gridBand3.Columns.Add(this.colHacim);
            this.gridBand3.Columns.Add(this.colMalzemeBirimi);
            this.gridBand3.Columns.Add(this.colMalzemeTipi);
            this.gridBand3.Columns.Add(this.colAmbalajTipi);
            this.gridBand3.Columns.Add(this.colAmbalajMaddes);
            this.gridBand3.Columns.Add(this.colSarfTipi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 400;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Teknik Özellikler";
            this.gridBand4.Columns.Add(this.colAğızÖlçüsü);
            this.gridBand4.Columns.Add(this.colUzunluk);
            this.gridBand4.Columns.Add(this.colEn);
            this.gridBand4.Columns.Add(this.colboy);
            this.gridBand4.Columns.Add(this.colYükseklik);
            this.gridBand4.Columns.Add(this.colAlan);
            this.gridBand4.Columns.Add(this.colAğırlık);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 425;
            // 
            // ÜrünListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 514);
            this.Controls.Add(this.myBandedGridControl1);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "ÜrünListForm";
            this.Text = "ÜrünTanıtımListForm";
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
        private myUserControls.Grid.myBandedGridColumn colMalzeme;
        private myUserControls.Grid.myBandedGridColumn colHacim;
        private myUserControls.Grid.myBandedGridColumn colMalzemeBirimi;
        private myUserControls.Grid.myBandedGridColumn colMalzemeTipi;
        private myUserControls.Grid.myBandedGridColumn colAmbalajTipi;
        private myUserControls.Grid.myBandedGridColumn colAmbalajMaddes;
        private myUserControls.Grid.myBandedGridColumn colSarfTipi;
        private myUserControls.Grid.myBandedGridColumn colAğızÖlçüsü;
        private myUserControls.Grid.myBandedGridColumn colUzunluk;
        private myUserControls.Grid.myBandedGridColumn colEn;
        private myUserControls.Grid.myBandedGridColumn colboy;
        private myUserControls.Grid.myBandedGridColumn colYükseklik;
        private myUserControls.Grid.myBandedGridColumn colAlan;
        private myUserControls.Grid.myBandedGridColumn colAğırlık;
        private myUserControls.Grid.myBandedGridColumn colMarka;
        private myUserControls.Grid.myBandedGridColumn colFirma;
        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Grid.myBandedGridColumn colGTIN;
        private myUserControls.Grid.myBandedGridColumn colkutu;
        private myUserControls.Grid.myBandedGridColumn colStand;
        private myUserControls.Grid.myBandedGridColumn colKoli;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}