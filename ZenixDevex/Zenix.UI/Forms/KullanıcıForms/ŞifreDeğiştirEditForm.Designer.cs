namespace Zenix.WinUI.Forms.KullanıcıForms
{
    partial class ŞifreDeğiştirEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new Zenix.WinUI.myUserControls.Controls.myDataLayoutControl();
            this.txtYeniŞifreTekrar = new Zenix.WinUI.myUserControls.Controls.myTextEdit();
            this.txtYeniŞifre = new Zenix.WinUI.myUserControls.Controls.myTextEdit();
            this.txtEskiŞifre = new Zenix.WinUI.myUserControls.Controls.myTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniŞifreTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniŞifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEskiŞifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(390, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtYeniŞifreTekrar);
            this.myDataLayoutControl.Controls.Add(this.txtYeniŞifre);
            this.myDataLayoutControl.Controls.Add(this.txtEskiŞifre);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(390, 117);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtYeniŞifreTekrar
            // 
            this.txtYeniŞifreTekrar.EditValue = "";
            this.txtYeniŞifreTekrar.EnterMoveNextControl = true;
            this.txtYeniŞifreTekrar.Location = new System.Drawing.Point(102, 60);
            this.txtYeniŞifreTekrar.MenuManager = this.ribbonControl;
            this.txtYeniŞifreTekrar.Name = "txtYeniŞifreTekrar";
            this.txtYeniŞifreTekrar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtYeniŞifreTekrar.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtYeniŞifreTekrar.Properties.MaxLength = 50;
            this.txtYeniŞifreTekrar.Properties.PasswordChar = '*';
            this.txtYeniŞifreTekrar.Properties.UseSystemPasswordChar = true;
            this.txtYeniŞifreTekrar.Size = new System.Drawing.Size(276, 20);
            this.txtYeniŞifreTekrar.StatusBarAciklama = "Yeni Şifre Tekrar Giriniz";
            this.txtYeniŞifreTekrar.StyleController = this.myDataLayoutControl;
            this.txtYeniŞifreTekrar.TabIndex = 2;
            // 
            // txtYeniŞifre
            // 
            this.txtYeniŞifre.EditValue = "";
            this.txtYeniŞifre.EnterMoveNextControl = true;
            this.txtYeniŞifre.Location = new System.Drawing.Point(102, 36);
            this.txtYeniŞifre.MenuManager = this.ribbonControl;
            this.txtYeniŞifre.Name = "txtYeniŞifre";
            this.txtYeniŞifre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtYeniŞifre.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtYeniŞifre.Properties.MaxLength = 50;
            this.txtYeniŞifre.Properties.PasswordChar = '*';
            this.txtYeniŞifre.Properties.UseSystemPasswordChar = true;
            this.txtYeniŞifre.Size = new System.Drawing.Size(276, 20);
            this.txtYeniŞifre.StatusBarAciklama = "Yeni Şifre Giriniz";
            this.txtYeniŞifre.StyleController = this.myDataLayoutControl;
            this.txtYeniŞifre.TabIndex = 1;
            // 
            // txtEskiŞifre
            // 
            this.txtEskiŞifre.EditValue = "";
            this.txtEskiŞifre.EnterMoveNextControl = true;
            this.txtEskiŞifre.Location = new System.Drawing.Point(102, 12);
            this.txtEskiŞifre.MenuManager = this.ribbonControl;
            this.txtEskiŞifre.Name = "txtEskiŞifre";
            this.txtEskiŞifre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEskiŞifre.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEskiŞifre.Properties.MaxLength = 50;
            this.txtEskiŞifre.Properties.PasswordChar = '*';
            this.txtEskiŞifre.Properties.UseSystemPasswordChar = true;
            this.txtEskiŞifre.Size = new System.Drawing.Size(276, 20);
            this.txtEskiŞifre.StatusBarAciklama = "Eski Şifreyi Giriniz";
            this.txtEskiŞifre.StyleController = this.myDataLayoutControl;
            this.txtEskiŞifre.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
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
            this.Root.Size = new System.Drawing.Size(390, 117);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtEskiŞifre;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(370, 24);
            this.layoutControlItem1.Text = "Eski Şifre";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtYeniŞifre;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(370, 24);
            this.layoutControlItem2.Text = "Yeni Şifre";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtYeniŞifreTekrar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(370, 24);
            this.layoutControlItem3.Text = "Yeni Şifre (Tekrar)";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(87, 13);
            // 
            // ŞifreDeğiştirEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 250);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.Name = "ŞifreDeğiştirEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştir";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniŞifreTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniŞifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEskiŞifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl;
        private myUserControls.Controls.myTextEdit txtYeniŞifreTekrar;
        private myUserControls.Controls.myTextEdit txtYeniŞifre;
        private myUserControls.Controls.myTextEdit txtEskiŞifre;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}