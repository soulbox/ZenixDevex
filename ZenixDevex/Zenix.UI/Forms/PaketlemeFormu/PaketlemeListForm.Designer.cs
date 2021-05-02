namespace Zenix.WinUI.Forms.PaketlemeFormu
{
    partial class PaketlemeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaketlemeListForm));
            this.Grid = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAyarTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colKutu = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colStand = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.colKoli = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colBirimTipi = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAçıklama = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
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
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 109);
            this.Grid.MainView = this.Tablo;
            this.Grid.MenuManager = this.ribbonControl;
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.Grid.Size = new System.Drawing.Size(952, 357);
            this.Grid.TabIndex = 9;
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
            this.colAyarTipi,
            this.colKutu,
            this.colStand,
            this.colKoli,
            this.colBirimTipi,
            this.colAçıklama});
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
            // colAyarTipi
            // 
            this.colAyarTipi.AppearanceCell.Options.UseTextOptions = true;
            this.colAyarTipi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAyarTipi.Caption = "Ayar Tipi";
            this.colAyarTipi.FieldName = "AyarTipi";
            this.colAyarTipi.Name = "colAyarTipi";
            this.colAyarTipi.OptionsColumn.AllowEdit = false;
            this.colAyarTipi.StatusBarAciklama = null;
            this.colAyarTipi.StatusBarKisayol = null;
            this.colAyarTipi.StatusBarKisayolAciklama = null;
            this.colAyarTipi.Visible = true;
            this.colAyarTipi.VisibleIndex = 1;
            this.colAyarTipi.Width = 200;
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
            // colKutu
            // 
            this.colKutu.Caption = "Kutu İçi";
            this.colKutu.FieldName = "Kutu";
            this.colKutu.Name = "colKutu";
            this.colKutu.OptionsColumn.AllowEdit = false;
            this.colKutu.StatusBarAciklama = null;
            this.colKutu.StatusBarKisayol = null;
            this.colKutu.StatusBarKisayolAciklama = null;
            this.colKutu.Visible = true;
            this.colKutu.VisibleIndex = 2;
            this.colKutu.Width = 200;
            // 
            // colStand
            // 
            this.colStand.Caption = "Stand İçi";
            this.colStand.FieldName = "Stand";
            this.colStand.Name = "colStand";
            this.colStand.OptionsColumn.AllowEdit = false;
            this.colStand.StatusBarAciklama = null;
            this.colStand.StatusBarKisayol = null;
            this.colStand.StatusBarKisayolAciklama = null;
            this.colStand.Visible = true;
            this.colStand.VisibleIndex = 3;
            this.colStand.Width = 200;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 466);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(952, 24);
            this.longNavigator.TabIndex = 8;
            // 
            // colKoli
            // 
            this.colKoli.Caption = "Koli İçi ";
            this.colKoli.FieldName = "Koli";
            this.colKoli.Name = "colKoli";
            this.colKoli.OptionsColumn.AllowEdit = false;
            this.colKoli.StatusBarAciklama = null;
            this.colKoli.StatusBarKisayol = null;
            this.colKoli.StatusBarKisayolAciklama = null;
            this.colKoli.Visible = true;
            this.colKoli.VisibleIndex = 4;
            // 
            // colBirimTipi
            // 
            this.colBirimTipi.Caption = "Birim";
            this.colBirimTipi.FieldName = "BirimTipi";
            this.colBirimTipi.Name = "colBirimTipi";
            this.colBirimTipi.OptionsColumn.AllowEdit = false;
            this.colBirimTipi.StatusBarAciklama = null;
            this.colBirimTipi.StatusBarKisayol = null;
            this.colBirimTipi.StatusBarKisayolAciklama = null;
            this.colBirimTipi.Visible = true;
            this.colBirimTipi.VisibleIndex = 5;
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
            this.colAçıklama.VisibleIndex = 6;
            this.colAçıklama.Width = 150;
            // 
            // PaketlemeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 514);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "PaketlemeListForm";
            this.Text = "PaketlemeListForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.Grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Grid.myGridControl Grid;
        private myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colId;
        private myUserControls.Grid.MyGridColumn colKod;
        protected myUserControls.Grid.MyGridColumn colAyarTipi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        protected myUserControls.Grid.MyGridColumn colKutu;
        private myUserControls.Grid.MyGridColumn colStand;
        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Grid.MyGridColumn colKoli;
        private myUserControls.Grid.MyGridColumn colBirimTipi;
        private myUserControls.Grid.MyGridColumn colAçıklama;
    }
}