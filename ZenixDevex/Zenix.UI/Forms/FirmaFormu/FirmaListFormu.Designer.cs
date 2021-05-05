namespace Zenix.WinUI.Forms.FirmaFormu
{
    partial class FirmaListFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaListFormu));
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.Grid = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colFirmaAdi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colTarih = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAdress = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colVergiDairesi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colVergiNo = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colÜlke = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(961, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 496);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(961, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 109);
            this.Grid.MainView = this.Tablo;
            this.Grid.MenuManager = this.ribbonControl;
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(961, 387);
            this.Grid.TabIndex = 3;
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
            this.colAdress,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colMTipi,
            this.colÜlke});
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
            this.colTarih.VisibleIndex = 7;
            this.colTarih.Width = 103;
            // 
            // colAdress
            // 
            this.colAdress.Caption = "Adres";
            this.colAdress.FieldName = "Adres";
            this.colAdress.Name = "colAdress";
            this.colAdress.OptionsColumn.AllowEdit = false;
            this.colAdress.StatusBarAciklama = null;
            this.colAdress.StatusBarKisayol = null;
            this.colAdress.StatusBarKisayolAciklama = null;
            this.colAdress.Visible = true;
            this.colAdress.VisibleIndex = 3;
            this.colAdress.Width = 609;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Caption = "Vergi Dairesi";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.OptionsColumn.AllowEdit = false;
            this.colVergiDairesi.StatusBarAciklama = null;
            this.colVergiDairesi.StatusBarKisayol = null;
            this.colVergiDairesi.StatusBarKisayolAciklama = null;
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 4;
            this.colVergiDairesi.Width = 169;
            // 
            // colVergiNo
            // 
            this.colVergiNo.Caption = "Vergi No";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.OptionsColumn.AllowEdit = false;
            this.colVergiNo.StatusBarAciklama = null;
            this.colVergiNo.StatusBarKisayol = null;
            this.colVergiNo.StatusBarKisayolAciklama = null;
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 5;
            this.colVergiNo.Width = 118;
            // 
            // colMTipi
            // 
            this.colMTipi.Caption = "Firma Tipi";
            this.colMTipi.FieldName = "FirmaTipiAdı";
            this.colMTipi.Name = "colMTipi";
            this.colMTipi.OptionsColumn.AllowEdit = false;
            this.colMTipi.StatusBarAciklama = null;
            this.colMTipi.StatusBarKisayol = null;
            this.colMTipi.StatusBarKisayolAciklama = null;
            this.colMTipi.Visible = true;
            this.colMTipi.VisibleIndex = 6;
            this.colMTipi.Width = 93;
            // 
            // colÜlke
            // 
            this.colÜlke.Caption = "Ülke";
            this.colÜlke.FieldName = "ÜlkeAdı";
            this.colÜlke.Name = "colÜlke";
            this.colÜlke.OptionsColumn.AllowEdit = false;
            this.colÜlke.StatusBarAciklama = null;
            this.colÜlke.StatusBarKisayol = null;
            this.colÜlke.StatusBarKisayolAciklama = null;
            this.colÜlke.Visible = true;
            this.colÜlke.VisibleIndex = 2;
            this.colÜlke.Width = 100;
            // 
            // FirmaListFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 544);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "FirmaListFormu";
            this.Text = "Firmalar";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.Grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Grid.myGridControl Grid;
        private myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colId;
        private myUserControls.Grid.MyGridColumn colKod;
        protected myUserControls.Grid.MyGridColumn colFirmaAdi;
        protected myUserControls.Grid.MyGridColumn colTarih;
        protected myUserControls.Grid.MyGridColumn colAdress;
        protected myUserControls.Grid.MyGridColumn colVergiDairesi;
        protected myUserControls.Grid.MyGridColumn colVergiNo;
        private myUserControls.Grid.MyGridColumn colMTipi;
        private myUserControls.Grid.MyGridColumn colÜlke;
    }
}