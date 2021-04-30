namespace Zenix.WinUI.Forms.KullanıcıForms
{
    partial class KullanıcıListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıListForm));
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.Grid = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKullanıcıAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colSoyadı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colEmail = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colRolAdı = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colAçıklama = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
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
            this.ribbonControl.Size = new System.Drawing.Size(1040, 109);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 450);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1040, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 109);
            this.Grid.MainView = this.Tablo;
            this.Grid.MenuManager = this.ribbonControl;
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1040, 341);
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
            this.Tablo.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.Tablo.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKullanıcıAdı,
            this.colAdı,
            this.colSoyadı,
            this.colEmail,
            this.colRolAdı,
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
            this.Tablo.ViewCaption = "Kullanıcı Kartları";
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
            // colKullanıcıAdı
            // 
            this.colKullanıcıAdı.Caption = "Kullanıcı Adı";
            this.colKullanıcıAdı.FieldName = "Kod";
            this.colKullanıcıAdı.Name = "colKullanıcıAdı";
            this.colKullanıcıAdı.OptionsColumn.AllowEdit = false;
            this.colKullanıcıAdı.StatusBarAciklama = null;
            this.colKullanıcıAdı.StatusBarKisayol = null;
            this.colKullanıcıAdı.StatusBarKisayolAciklama = null;
            this.colKullanıcıAdı.Visible = true;
            this.colKullanıcıAdı.VisibleIndex = 0;
            this.colKullanıcıAdı.Width = 160;
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
            this.colAdı.Width = 115;
            // 
            // colSoyadı
            // 
            this.colSoyadı.Caption = "Soyadı";
            this.colSoyadı.FieldName = "Soyadı";
            this.colSoyadı.Name = "colSoyadı";
            this.colSoyadı.OptionsColumn.AllowEdit = false;
            this.colSoyadı.StatusBarAciklama = null;
            this.colSoyadı.StatusBarKisayol = null;
            this.colSoyadı.StatusBarKisayolAciklama = null;
            this.colSoyadı.Visible = true;
            this.colSoyadı.VisibleIndex = 2;
            this.colSoyadı.Width = 115;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.StatusBarAciklama = null;
            this.colEmail.StatusBarKisayol = null;
            this.colEmail.StatusBarKisayolAciklama = null;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 160;
            // 
            // colRolAdı
            // 
            this.colRolAdı.Caption = "Rol";
            this.colRolAdı.FieldName = "RolAdı";
            this.colRolAdı.Name = "colRolAdı";
            this.colRolAdı.OptionsColumn.AllowEdit = false;
            this.colRolAdı.StatusBarAciklama = null;
            this.colRolAdı.StatusBarKisayol = null;
            this.colRolAdı.StatusBarKisayolAciklama = null;
            this.colRolAdı.Visible = true;
            this.colRolAdı.VisibleIndex = 4;
            this.colRolAdı.Width = 115;
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
            this.colAçıklama.VisibleIndex = 5;
            this.colAçıklama.Width = 350;
            // 
            // KullanıcıListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 498);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "KullanıcıListForm";
            this.Text = "Kullanıcı Kartları";
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
        private myUserControls.Grid.MyGridColumn colKullanıcıAdı;
        private myUserControls.Grid.MyGridColumn colAdı;
        private myUserControls.Grid.MyGridColumn colSoyadı;
        private myUserControls.Grid.MyGridColumn colEmail;
        private myUserControls.Grid.MyGridColumn colRolAdı;
        private myUserControls.Grid.MyGridColumn colAçıklama;
    }
}