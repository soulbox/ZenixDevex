namespace Zenix.WinUI.Forms.ÜretimFormu
{
    partial class YarıMamüldenÜretimEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl1 = new Zenix.WinUI.myUserControls.Controls.myDataLayoutControl();
            this.txtÜrünMiktar = new Zenix.WinUI.myUserControls.Controls.mySpinEdit();
            this.txtKoliiçi = new Zenix.WinUI.myUserControls.Controls.mySpinEdit();
            this.txtKoli = new Zenix.WinUI.myUserControls.Controls.mySpinEdit();
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.Tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colMamülId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colmazleme = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colStok = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colYarımamülStok = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colÜret = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colgrup = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colüretilen = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtÜrünMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoliiçi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(677, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.txtÜrünMiktar);
            this.myDataLayoutControl1.Controls.Add(this.txtKoliiçi);
            this.myDataLayoutControl1.Controls.Add(this.txtKoli);
            this.myDataLayoutControl1.Controls.Add(this.myGridControl1);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(677, 418);
            this.myDataLayoutControl1.TabIndex = 2;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // txtÜrünMiktar
            // 
            this.txtÜrünMiktar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtÜrünMiktar.EnterMoveNextControl = true;
            this.txtÜrünMiktar.Location = new System.Drawing.Point(72, 386);
            this.txtÜrünMiktar.MenuManager = this.ribbonControl;
            this.txtÜrünMiktar.Name = "txtÜrünMiktar";
            this.txtÜrünMiktar.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtÜrünMiktar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtÜrünMiktar.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtÜrünMiktar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtÜrünMiktar.Properties.Mask.EditMask = "d";
            this.txtÜrünMiktar.Size = new System.Drawing.Size(136, 20);
            this.txtÜrünMiktar.StatusBarAciklama = null;
            this.txtÜrünMiktar.StyleController = this.myDataLayoutControl1;
            this.txtÜrünMiktar.TabIndex = 7;
            // 
            // txtKoliiçi
            // 
            this.txtKoliiçi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtKoliiçi.EnterMoveNextControl = true;
            this.txtKoliiçi.Location = new System.Drawing.Point(72, 362);
            this.txtKoliiçi.MenuManager = this.ribbonControl;
            this.txtKoliiçi.Name = "txtKoliiçi";
            this.txtKoliiçi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtKoliiçi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKoliiçi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKoliiçi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKoliiçi.Properties.Mask.EditMask = "d";
            this.txtKoliiçi.Size = new System.Drawing.Size(136, 20);
            this.txtKoliiçi.StatusBarAciklama = null;
            this.txtKoliiçi.StyleController = this.myDataLayoutControl1;
            this.txtKoliiçi.TabIndex = 6;
            // 
            // txtKoli
            // 
            this.txtKoli.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtKoli.EnterMoveNextControl = true;
            this.txtKoli.Location = new System.Drawing.Point(72, 338);
            this.txtKoli.MenuManager = this.ribbonControl;
            this.txtKoli.Name = "txtKoli";
            this.txtKoli.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtKoli.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKoli.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKoli.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKoli.Properties.Mask.EditMask = "d";
            this.txtKoli.Size = new System.Drawing.Size(136, 20);
            this.txtKoli.StatusBarAciklama = null;
            this.txtKoli.StyleController = this.myDataLayoutControl1;
            this.txtKoli.TabIndex = 5;
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(12, 12);
            this.myGridControl1.MainView = this.Tablo;
            this.myGridControl1.MenuManager = this.ribbonControl;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCalcEdit1});
            this.myGridControl1.Size = new System.Drawing.Size(653, 322);
            this.myGridControl1.TabIndex = 4;
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
            this.colMamülId,
            this.colmazleme,
            this.colStok,
            this.colYarımamülStok,
            this.colÜret,
            this.colgrup,
            this.colüretilen});
            this.Tablo.GridControl = this.myGridControl1;
            this.Tablo.GroupCount = 1;
            this.Tablo.Name = "Tablo";
            this.Tablo.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.Tablo.OptionsBehavior.AutoExpandAllGroups = true;
            this.Tablo.OptionsFind.FindDelay = 100;
            this.Tablo.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.Tablo.OptionsFind.FindNullPrompt = "Ara";
            this.Tablo.OptionsFind.ShowFindButton = false;
            this.Tablo.OptionsMenu.EnableColumnMenu = false;
            this.Tablo.OptionsMenu.EnableFooterMenu = false;
            this.Tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.Tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.Tablo.OptionsPrint.AutoWidth = false;
            this.Tablo.OptionsPrint.ExpandAllDetails = true;
            this.Tablo.OptionsPrint.PrintGroupFooter = false;
            this.Tablo.OptionsView.ColumnAutoWidth = false;
            this.Tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.Tablo.OptionsView.RowAutoHeight = true;
            this.Tablo.OptionsView.ShowAutoFilterRow = true;
            this.Tablo.OptionsView.ShowGroupPanel = false;
            this.Tablo.OptionsView.ShowViewCaption = true;
            this.Tablo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colgrup, DevExpress.Data.ColumnSortOrder.Descending)});
            this.Tablo.StatusBarAciklama = null;
            this.Tablo.StatusBarKisayol = null;
            this.Tablo.StatusBarKisayolAciklama = null;
            // 
            // colMamülId
            // 
            this.colMamülId.Caption = "MamülId";
            this.colMamülId.FieldName = "MamülId";
            this.colMamülId.Name = "colMamülId";
            this.colMamülId.OptionsColumn.AllowEdit = false;
            this.colMamülId.OptionsColumn.ShowInCustomizationForm = false;
            this.colMamülId.StatusBarAciklama = null;
            this.colMamülId.StatusBarKisayol = null;
            this.colMamülId.StatusBarKisayolAciklama = null;
            // 
            // colmazleme
            // 
            this.colmazleme.Caption = "Malzeme";
            this.colmazleme.FieldName = "GörünenAd";
            this.colmazleme.Name = "colmazleme";
            this.colmazleme.OptionsColumn.AllowEdit = false;
            this.colmazleme.StatusBarAciklama = null;
            this.colmazleme.StatusBarKisayol = null;
            this.colmazleme.StatusBarKisayolAciklama = null;
            this.colmazleme.Visible = true;
            this.colmazleme.VisibleIndex = 0;
            this.colmazleme.Width = 210;
            // 
            // colStok
            // 
            this.colStok.Caption = "Stok";
            this.colStok.FieldName = "Stok";
            this.colStok.Name = "colStok";
            this.colStok.OptionsColumn.AllowEdit = false;
            this.colStok.StatusBarAciklama = null;
            this.colStok.StatusBarKisayol = null;
            this.colStok.StatusBarKisayolAciklama = null;
            this.colStok.Visible = true;
            this.colStok.VisibleIndex = 1;
            this.colStok.Width = 94;
            // 
            // colYarımamülStok
            // 
            this.colYarımamülStok.Caption = "Y.M. Stok";
            this.colYarımamülStok.FieldName = "YarıMamülStok";
            this.colYarımamülStok.Name = "colYarımamülStok";
            this.colYarımamülStok.OptionsColumn.AllowEdit = false;
            this.colYarımamülStok.StatusBarAciklama = null;
            this.colYarımamülStok.StatusBarKisayol = null;
            this.colYarımamülStok.StatusBarKisayolAciklama = null;
            this.colYarımamülStok.Visible = true;
            this.colYarımamülStok.VisibleIndex = 2;
            this.colYarımamülStok.Width = 91;
            // 
            // colÜret
            // 
            this.colÜret.Caption = "Üretime Alınan Miktar";
            this.colÜret.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colÜret.FieldName = "Miktar";
            this.colÜret.Name = "colÜret";
            this.colÜret.StatusBarAciklama = null;
            this.colÜret.StatusBarKisayol = null;
            this.colÜret.StatusBarKisayolAciklama = null;
            this.colÜret.Visible = true;
            this.colÜret.VisibleIndex = 3;
            this.colÜret.Width = 121;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // colgrup
            // 
            this.colgrup.Caption = "  ";
            this.colgrup.FieldName = "GrupAdı";
            this.colgrup.Name = "colgrup";
            this.colgrup.OptionsColumn.AllowEdit = false;
            this.colgrup.StatusBarAciklama = null;
            this.colgrup.StatusBarKisayol = null;
            this.colgrup.StatusBarKisayolAciklama = null;
            this.colgrup.Visible = true;
            this.colgrup.VisibleIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 90D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
            this.Root.Size = new System.Drawing.Size(677, 418);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.myGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem1.Size = new System.Drawing.Size(657, 326);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtKoli;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 326);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Text = "Koli";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtKoliiçi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 350);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Text = "Koli İçi ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtÜrünMiktar;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 374);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Text = "Ürün Miktarı";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(57, 13);
            // 
            // colüretilen
            // 
            this.colüretilen.Caption = "Üretilen";
            this.colüretilen.FieldName = "ÜretimStok";
            this.colüretilen.Name = "colüretilen";
            this.colüretilen.OptionsColumn.AllowEdit = false;
            this.colüretilen.StatusBarAciklama = null;
            this.colüretilen.StatusBarKisayol = null;
            this.colüretilen.StatusBarKisayolAciklama = null;
            this.colüretilen.Visible = true;
            this.colüretilen.VisibleIndex = 4;
            this.colüretilen.Width = 118;
            // 
            // YarıMamüldenÜretimEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 551);
            this.Controls.Add(this.myDataLayoutControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "YarıMamüldenÜretimEditForm";
            this.Text = "YarıMamüldenÜretimEditForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtÜrünMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoliiçi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl1;
        private myUserControls.Grid.myGridControl myGridControl1;
        private myUserControls.Grid.myGridview Tablo;
        private myUserControls.Grid.MyGridColumn colMamülId;
        private myUserControls.Grid.MyGridColumn colmazleme;
        private myUserControls.Grid.MyGridColumn colStok;
        private myUserControls.Grid.MyGridColumn colÜret;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private myUserControls.Grid.MyGridColumn colYarımamülStok;
        private myUserControls.Grid.MyGridColumn colgrup;
        private myUserControls.Controls.mySpinEdit txtÜrünMiktar;
        private myUserControls.Controls.mySpinEdit txtKoliiçi;
        private myUserControls.Controls.mySpinEdit txtKoli;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private myUserControls.Grid.MyGridColumn colüretilen;
    }
}