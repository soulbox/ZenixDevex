namespace Zenix.WinUI.Forms.MalzemeFormu
{
    partial class MalzemeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalzemeListForm));
            this.Grid = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMalzemeTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colMalzemeBirim = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colHacim = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colHacimBirim = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAmbalajTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAmbalajMaddeTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
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
            this.ribbonControl.Size = new System.Drawing.Size(1122, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 109);
            this.Grid.MainView = this.Tablo;
            this.Grid.MenuManager = this.ribbonControl;
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1122, 383);
            this.Grid.TabIndex = 5;
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
            this.colAdı,
            this.colMalzemeTipi,
            this.colMalzemeBirim,
            this.colHacim,
            this.colHacimBirim,
            this.colAmbalajTipi,
            this.colAmbalajMaddeTipi});
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
            // colAdı
            // 
            this.colAdı.Caption = "Adı";
            this.colAdı.FieldName = "Adı";
            this.colAdı.Name = "colAdı";
            this.colAdı.OptionsColumn.AllowEdit = false;
            this.colAdı.StatusBarAciklama = null;
            this.colAdı.StatusBarKisayol = null;
            this.colAdı.StatusBarKisayolAciklama = null;
            this.colAdı.Visible = true;
            this.colAdı.VisibleIndex = 1;
            this.colAdı.Width = 267;
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
            this.colMalzemeTipi.VisibleIndex = 7;
            this.colMalzemeTipi.Width = 120;
            // 
            // colMalzemeBirim
            // 
            this.colMalzemeBirim.Caption = "Malzeme Birim";
            this.colMalzemeBirim.FieldName = "MalzemeBirimi";
            this.colMalzemeBirim.Name = "colMalzemeBirim";
            this.colMalzemeBirim.OptionsColumn.AllowEdit = false;
            this.colMalzemeBirim.StatusBarAciklama = null;
            this.colMalzemeBirim.StatusBarKisayol = null;
            this.colMalzemeBirim.StatusBarKisayolAciklama = null;
            this.colMalzemeBirim.Visible = true;
            this.colMalzemeBirim.VisibleIndex = 3;
            this.colMalzemeBirim.Width = 120;
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
            this.colHacim.VisibleIndex = 4;
            this.colHacim.Width = 120;
            // 
            // colHacimBirim
            // 
            this.colHacimBirim.Caption = "Hacim Birim";
            this.colHacimBirim.FieldName = "HacimBirimi";
            this.colHacimBirim.Name = "colHacimBirim";
            this.colHacimBirim.OptionsColumn.AllowEdit = false;
            this.colHacimBirim.StatusBarAciklama = null;
            this.colHacimBirim.StatusBarKisayol = null;
            this.colHacimBirim.StatusBarKisayolAciklama = null;
            this.colHacimBirim.Visible = true;
            this.colHacimBirim.VisibleIndex = 5;
            this.colHacimBirim.Width = 120;
            // 
            // colAmbalajTipi
            // 
            this.colAmbalajTipi.Caption = "Ambalaj Tipi";
            this.colAmbalajTipi.FieldName = "AmbalajTipi";
            this.colAmbalajTipi.Name = "colAmbalajTipi";
            this.colAmbalajTipi.OptionsColumn.AllowEdit = false;
            this.colAmbalajTipi.StatusBarAciklama = null;
            this.colAmbalajTipi.StatusBarKisayol = null;
            this.colAmbalajTipi.StatusBarKisayolAciklama = null;
            this.colAmbalajTipi.Visible = true;
            this.colAmbalajTipi.VisibleIndex = 6;
            this.colAmbalajTipi.Width = 120;
            // 
            // colAmbalajMaddeTipi
            // 
            this.colAmbalajMaddeTipi.Caption = "Ambalaj Madde Tipi";
            this.colAmbalajMaddeTipi.FieldName = "AmbalajMaddeTipi";
            this.colAmbalajMaddeTipi.Name = "colAmbalajMaddeTipi";
            this.colAmbalajMaddeTipi.OptionsColumn.AllowEdit = false;
            this.colAmbalajMaddeTipi.StatusBarAciklama = null;
            this.colAmbalajMaddeTipi.StatusBarKisayol = null;
            this.colAmbalajMaddeTipi.StatusBarKisayolAciklama = null;
            this.colAmbalajMaddeTipi.Visible = true;
            this.colAmbalajMaddeTipi.VisibleIndex = 2;
            this.colAmbalajMaddeTipi.Width = 120;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 492);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1122, 24);
            this.longNavigator.TabIndex = 4;
            // 
            // MalzemeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 540);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "MalzemeListForm";
            this.Text = "MalzemeListForm";
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

        private myUserControls.Grid.myGridControl Grid;
        private myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colId;
        private myUserControls.Grid.MyGridColumn colKod;
        protected myUserControls.Grid.MyGridColumn colAdı;
        protected myUserControls.Grid.MyGridColumn colMalzemeTipi;
        protected myUserControls.Grid.MyGridColumn colMalzemeBirim;
        protected myUserControls.Grid.MyGridColumn colHacim;
        protected myUserControls.Grid.MyGridColumn colHacimBirim;
        private myUserControls.Grid.MyGridColumn colAmbalajTipi;
        private myUserControls.Grid.MyGridColumn colAmbalajMaddeTipi;
        private myUserControls.Navigator.LongNavigator longNavigator;
    }
}