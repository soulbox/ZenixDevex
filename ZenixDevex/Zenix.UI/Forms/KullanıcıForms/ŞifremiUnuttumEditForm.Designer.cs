namespace Zenix.WinUI.Forms.KullanıcıForms
{
    partial class ŞifremiUnuttumEditForm
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
            this.txtEposta = new Zenix.WinUI.myUserControls.Controls.myEposta();
            this.txtSoyadı = new Zenix.WinUI.myUserControls.Controls.myTextEdit();
            this.txtAdı = new Zenix.WinUI.myUserControls.Controls.myTextEdit();
            this.txtKullanıcıAdı = new Zenix.WinUI.myUserControls.Controls.myTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcıAdı.Properties)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(368, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtEposta);
            this.myDataLayoutControl.Controls.Add(this.txtSoyadı);
            this.myDataLayoutControl.Controls.Add(this.txtAdı);
            this.myDataLayoutControl.Controls.Add(this.txtKullanıcıAdı);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(368, 122);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtEposta
            // 
            this.txtEposta.EnterMoveNextControl = true;
            this.txtEposta.Location = new System.Drawing.Point(70, 84);
            this.txtEposta.MenuManager = this.ribbonControl;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEposta.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEposta.Properties.Mask.EditMask = "((((\\w+-*)|(-*\\w+))+\\.*((\\w+-*)|(-*\\w+))+)|(((\\w+-*)|(-*\\w+))+))+@((((\\w+-*)|(-*\\" +
    "w+))+\\.*((\\w+-*)|(-*\\w+))+)|(((\\w+-*)|(-*\\w+))+))+\\.[A-Za-z]+";
            this.txtEposta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEposta.Properties.MaxLength = 50;
            this.txtEposta.Size = new System.Drawing.Size(286, 20);
            this.txtEposta.StatusBarAciklama = "E-Posta Giriniz";
            this.txtEposta.StyleController = this.myDataLayoutControl;
            this.txtEposta.TabIndex = 3;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.EditValue = "";
            this.txtSoyadı.EnterMoveNextControl = true;
            this.txtSoyadı.Location = new System.Drawing.Point(70, 60);
            this.txtSoyadı.MenuManager = this.ribbonControl;
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSoyadı.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSoyadı.Properties.MaxLength = 50;
            this.txtSoyadı.Size = new System.Drawing.Size(286, 20);
            this.txtSoyadı.StatusBarAciklama = "Soyadınızı Giriniz";
            this.txtSoyadı.StyleController = this.myDataLayoutControl;
            this.txtSoyadı.TabIndex = 2;
            // 
            // txtAdı
            // 
            this.txtAdı.EditValue = "";
            this.txtAdı.EnterMoveNextControl = true;
            this.txtAdı.Location = new System.Drawing.Point(70, 36);
            this.txtAdı.MenuManager = this.ribbonControl;
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAdı.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAdı.Properties.MaxLength = 50;
            this.txtAdı.Size = new System.Drawing.Size(286, 20);
            this.txtAdı.StatusBarAciklama = "Adınızı Giriniz";
            this.txtAdı.StyleController = this.myDataLayoutControl;
            this.txtAdı.TabIndex = 1;
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.EditValue = "";
            this.txtKullanıcıAdı.EnterMoveNextControl = true;
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(70, 12);
            this.txtKullanıcıAdı.MenuManager = this.ribbonControl;
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKullanıcıAdı.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKullanıcıAdı.Properties.MaxLength = 50;
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(286, 20);
            this.txtKullanıcıAdı.StatusBarAciklama = "Kullanıcı Adı Giriniz";
            this.txtKullanıcıAdı.StyleController = this.myDataLayoutControl;
            this.txtKullanıcıAdı.TabIndex = 0;
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
            this.Root.Size = new System.Drawing.Size(368, 122);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKullanıcıAdı;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(348, 24);
            this.layoutControlItem1.Text = "Kullanıcı Adı";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtAdı;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(348, 24);
            this.layoutControlItem2.Text = "Adı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtSoyadı;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(348, 24);
            this.layoutControlItem3.Text = "Soyadı";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtEposta;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(348, 30);
            this.layoutControlItem4.Text = "E-Posta";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // ŞifremiUnuttumEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 255);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(370, 256);
            this.Name = "ŞifremiUnuttumEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEposta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcıAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl;
        private myUserControls.Controls.myTextEdit txtSoyadı;
        private myUserControls.Controls.myTextEdit txtAdı;
        private myUserControls.Controls.myTextEdit txtKullanıcıAdı;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private myUserControls.Controls.myEposta txtEposta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}