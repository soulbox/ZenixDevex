namespace Zenix.WinUI.Forms.YarımamülFormu
{
    partial class YarıMamülListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YarıMamülListForm));
            this.longNavigator = new Zenix.WinUI.myUserControls.Navigator.LongNavigator();
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKod = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
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
            this.longNavigator.Size = new System.Drawing.Size(952, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // myGridControl1
            // 
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 109);
            this.myGridControl1.MainView = this.Tablo;
            this.myGridControl1.MenuManager = this.ribbonControl;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(952, 357);
            this.myGridControl1.TabIndex = 3;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colKod});
            this.Tablo.GridControl = this.myGridControl1;
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
            // 
            // YarıMamülListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 514);
            this.Controls.Add(this.myGridControl1);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "YarıMamülListForm";
            this.Text = "YarıMamülListForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.myGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Navigator.LongNavigator longNavigator;
        private myUserControls.Grid.myGridControl myGridControl1;
        private myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colId;
        private myUserControls.Grid.MyGridColumn colKod;
    }
}