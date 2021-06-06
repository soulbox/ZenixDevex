namespace Zenix.WinUI.Forms.MamülFormu
{
    partial class MamülListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MamülListForm));
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.myBandedGridControl1 = new Zenix.WinUI.myUserControls.Grid.myBandedGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myBandedGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMalzeme = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colTicariİsim = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colHacim = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMalzemeBirimi = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colMalzemeTipi = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colPketŞekli = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAmbalajMaddes = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAğızÖlçüsü = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colUzunluk = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colEn = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colboy = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colYükseklik = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAlan = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAğırlık = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colRenk = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.colAmbalajTipi = new Zenix.WinUI.myUserControls.Grid.myBandedGridColumn();
            this.aaaa = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
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
            this.ribbonControl.Size = new System.Drawing.Size(1027, 109);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 466);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1027, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // myBandedGridControl1
            // 
            this.myBandedGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myBandedGridControl1.Location = new System.Drawing.Point(0, 109);
            this.myBandedGridControl1.MainView = this.Tablo;
            this.myBandedGridControl1.MenuManager = this.ribbonControl;
            this.myBandedGridControl1.Name = "myBandedGridControl1";
            this.myBandedGridControl1.Size = new System.Drawing.Size(1027, 357);
            this.myBandedGridControl1.TabIndex = 4;
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
            this.gridBand3,
            this.gridBand4});
            this.Tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colMalzeme,
            this.colMalzemeBirimi,
            this.colMalzemeTipi,
            this.colPketŞekli,
            this.colAmbalajMaddes,
            this.colHacim,
            this.colAğızÖlçüsü,
            this.colUzunluk,
            this.colEn,
            this.colboy,
            this.colYükseklik,
            this.colAlan,
            this.colAğırlık,
            this.colTicariİsim,
            this.colRenk,
            this.colAmbalajTipi});
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
            // colMalzeme
            // 
            this.colMalzeme.Caption = "Malzeme";
            this.colMalzeme.FieldName = "MamülAdı";
            this.colMalzeme.Name = "colMalzeme";
            this.colMalzeme.OptionsColumn.AllowEdit = false;
            this.colMalzeme.StatusBarAciklama = null;
            this.colMalzeme.StatusBarKisayol = null;
            this.colMalzeme.StatusBarKisayolAciklama = null;
            this.colMalzeme.Visible = true;
            this.colMalzeme.Width = 150;
            // 
            // colTicariİsim
            // 
            this.colTicariİsim.Caption = "Ticariİsim";
            this.colTicariİsim.FieldName = "Ticariİsim";
            this.colTicariİsim.Name = "colTicariİsim";
            this.colTicariİsim.OptionsColumn.AllowEdit = false;
            this.colTicariİsim.StatusBarAciklama = null;
            this.colTicariİsim.StatusBarKisayol = null;
            this.colTicariİsim.StatusBarKisayolAciklama = null;
            this.colTicariİsim.Visible = true;
            this.colTicariİsim.Width = 94;
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
            // colPketŞekli
            // 
            this.colPketŞekli.Caption = "Paket Şekli";
            this.colPketŞekli.FieldName = "AmbalajTipiAdı";
            this.colPketŞekli.Name = "colPketŞekli";
            this.colPketŞekli.OptionsColumn.AllowEdit = false;
            this.colPketŞekli.StatusBarAciklama = null;
            this.colPketŞekli.StatusBarKisayol = null;
            this.colPketŞekli.StatusBarKisayolAciklama = null;
            this.colPketŞekli.Visible = true;
            // 
            // colAmbalajMaddes
            // 
            this.colAmbalajMaddes.Caption = "Paket Malzemesi";
            this.colAmbalajMaddes.FieldName = "AmbalajMaddeAdı";
            this.colAmbalajMaddes.Name = "colAmbalajMaddes";
            this.colAmbalajMaddes.OptionsColumn.AllowEdit = false;
            this.colAmbalajMaddes.StatusBarAciklama = null;
            this.colAmbalajMaddes.StatusBarKisayol = null;
            this.colAmbalajMaddes.StatusBarKisayolAciklama = null;
            this.colAmbalajMaddes.Visible = true;
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
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = -1;
            // 
            // colRenk
            // 
            this.colRenk.Caption = "Renk";
            this.colRenk.FieldName = "Renk";
            this.colRenk.Name = "colRenk";
            this.colRenk.OptionsColumn.AllowEdit = false;
            this.colRenk.StatusBarAciklama = null;
            this.colRenk.StatusBarKisayol = null;
            this.colRenk.StatusBarKisayolAciklama = null;
            this.colRenk.Visible = true;
            // 
            // colAmbalajTipi
            // 
            this.colAmbalajTipi.Caption = "AmbalajTipi";
            this.colAmbalajTipi.FieldName = "AmbalajTipi";
            this.colAmbalajTipi.Name = "colAmbalajTipi";
            this.colAmbalajTipi.OptionsColumn.AllowEdit = false;
            this.colAmbalajTipi.StatusBarAciklama = null;
            this.colAmbalajTipi.StatusBarKisayol = null;
            this.colAmbalajTipi.StatusBarKisayolAciklama = null;
            this.colAmbalajTipi.Visible = true;
            // 
            // aaaa
            // 
            this.aaaa.Caption = "Malzeme";
            this.aaaa.Columns.Add(this.colId);
            this.aaaa.Columns.Add(this.colKod);
            this.aaaa.Columns.Add(this.colMalzeme);
            this.aaaa.Columns.Add(this.colTicariİsim);
            this.aaaa.Columns.Add(this.colRenk);
            this.aaaa.Columns.Add(this.colMalzemeTipi);
            this.aaaa.Columns.Add(this.colPketŞekli);
            this.aaaa.Columns.Add(this.colHacim);
            this.aaaa.Columns.Add(this.colMalzemeBirimi);
            this.aaaa.Name = "aaaa";
            this.aaaa.VisibleIndex = 0;
            this.aaaa.Width = 644;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Tipi";
            this.gridBand3.Columns.Add(this.colAmbalajMaddes);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 1;
            this.gridBand3.Width = 75;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Teknik Özellikler";
            this.gridBand4.Columns.Add(this.colAmbalajTipi);
            this.gridBand4.Columns.Add(this.colAğızÖlçüsü);
            this.gridBand4.Columns.Add(this.colUzunluk);
            this.gridBand4.Columns.Add(this.colEn);
            this.gridBand4.Columns.Add(this.colboy);
            this.gridBand4.Columns.Add(this.colYükseklik);
            this.gridBand4.Columns.Add(this.colAlan);
            this.gridBand4.Columns.Add(this.colAğırlık);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 2;
            this.gridBand4.Width = 500;
            // 
            // MamülListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 514);
            this.Controls.Add(this.myBandedGridControl1);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "MamülListForm";
            this.Text = "MamülListForm";
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
        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Grid.myBandedGridControl myBandedGridControl1;
        private myUserControls.Grid.myBandedGridview Tablo;
        private myUserControls.Grid.myBandedGridColumn colId;
        private myUserControls.Grid.myBandedGridColumn colKod;
        private myUserControls.Grid.myBandedGridColumn colMalzeme;
        private myUserControls.Grid.myBandedGridColumn colHacim;
        private myUserControls.Grid.myBandedGridColumn colMalzemeBirimi;
        private myUserControls.Grid.myBandedGridColumn colMalzemeTipi;
        private myUserControls.Grid.myBandedGridColumn colPketŞekli;
        private myUserControls.Grid.myBandedGridColumn colAmbalajMaddes;
        private myUserControls.Grid.myBandedGridColumn colAğızÖlçüsü;
        private myUserControls.Grid.myBandedGridColumn colUzunluk;
        private myUserControls.Grid.myBandedGridColumn colEn;
        private myUserControls.Grid.myBandedGridColumn colboy;
        private myUserControls.Grid.myBandedGridColumn colYükseklik;
        private myUserControls.Grid.myBandedGridColumn colAlan;
        private myUserControls.Grid.myBandedGridColumn colAğırlık;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private myUserControls.Grid.myBandedGridColumn colTicariİsim;
        private myUserControls.Grid.myBandedGridColumn colRenk;
        private myUserControls.Grid.myBandedGridColumn colAmbalajTipi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand aaaa;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}