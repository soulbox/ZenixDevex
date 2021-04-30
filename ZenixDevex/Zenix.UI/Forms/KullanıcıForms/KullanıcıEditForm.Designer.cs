namespace Zenix.WinUI.Forms.KullanıcıForms
{
    partial class KullanıcıEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new Zenix.WinUI.myUserControls.Controls.myDataLayoutControl();
            this.tglDurum = new Zenix.WinUI.myUserControls.Controls.myToogleSwitch();
            this.txtAçıklama = new Zenix.WinUI.myUserControls.Controls.myMemoEdit();
            this.txtRol = new Zenix.WinUI.myUserControls.Controls.myButtonEdit();
            this.txtEmail = new Zenix.WinUI.myUserControls.Controls.myEposta();
            this.txtSoyadı = new Zenix.WinUI.myUserControls.Controls.myTextEdit();
            this.txtAdı = new Zenix.WinUI.myUserControls.Controls.myTextEdit();
            this.txtKullanıcıAdı = new Zenix.WinUI.myUserControls.Controls.myKodText();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAçıklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcıAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(384, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.txtAçıklama);
            this.myDataLayoutControl.Controls.Add(this.txtRol);
            this.myDataLayoutControl.Controls.Add(this.txtEmail);
            this.myDataLayoutControl.Controls.Add(this.txtSoyadı);
            this.myDataLayoutControl.Controls.Add(this.txtAdı);
            this.myDataLayoutControl.Controls.Add(this.txtKullanıcıAdı);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(384, 224);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(286, 12);
            this.tglDurum.MenuManager = this.ribbonControl;
            this.tglDurum.Name = "tglDurum";
            this.tglDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglDurum.Properties.Appearance.Options.UseForeColor = true;
            this.tglDurum.Properties.AutoHeight = false;
            this.tglDurum.Properties.AutoWidth = true;
            this.tglDurum.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglDurum.Properties.OffText = "Pasif";
            this.tglDurum.Properties.OnText = "Aktif";
            this.tglDurum.Size = new System.Drawing.Size(77, 20);
            this.tglDurum.StatusBarAciklama = "Kaydın Kullanım Durumunu Seçiniz.";
            this.tglDurum.StyleController = this.myDataLayoutControl;
            this.tglDurum.TabIndex = 6;
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.EnterMoveNextControl = true;
            this.txtAçıklama.Location = new System.Drawing.Point(70, 132);
            this.txtAçıklama.MenuManager = this.ribbonControl;
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAçıklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAçıklama.Properties.MaxLength = 500;
            this.txtAçıklama.Size = new System.Drawing.Size(302, 80);
            this.txtAçıklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.txtAçıklama.StyleController = this.myDataLayoutControl;
            this.txtAçıklama.TabIndex = 5;
            // 
            // txtRol
            // 
            this.txtRol.EnterMoveNextControl = true;
            this.txtRol.Id = null;
            this.txtRol.Location = new System.Drawing.Point(70, 108);
            this.txtRol.MenuManager = this.ribbonControl;
            this.txtRol.Name = "txtRol";
            this.txtRol.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtRol.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtRol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtRol.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtRol.Size = new System.Drawing.Size(138, 20);
            this.txtRol.StatusBarAciklama = "Rol Seçiniz";
            this.txtRol.StatusBarKisayol = "F4 :";
            this.txtRol.StatusBarKisayolAciklama = "Seç";
            this.txtRol.StyleController = this.myDataLayoutControl;
            this.txtRol.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.EnterMoveNextControl = true;
            this.txtEmail.Location = new System.Drawing.Point(70, 84);
            this.txtEmail.MenuManager = this.ribbonControl;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEmail.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEmail.Properties.Mask.EditMask = "((((\\w+-*)|(-*\\w+))+\\.*((\\w+-*)|(-*\\w+))+)|(((\\w+-*)|(-*\\w+))+))+@((((\\w+-*)|(-*\\" +
    "w+))+\\.*((\\w+-*)|(-*\\w+))+)|(((\\w+-*)|(-*\\w+))+))+\\.[A-Za-z]+";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(302, 20);
            this.txtEmail.StatusBarAciklama = "Kullanıcı Emaili Giriniz";
            this.txtEmail.StyleController = this.myDataLayoutControl;
            this.txtEmail.TabIndex = 3;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.EnterMoveNextControl = true;
            this.txtSoyadı.Location = new System.Drawing.Point(70, 60);
            this.txtSoyadı.MenuManager = this.ribbonControl;
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSoyadı.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSoyadı.Properties.MaxLength = 50;
            this.txtSoyadı.Size = new System.Drawing.Size(138, 20);
            this.txtSoyadı.StatusBarAciklama = "Soyadınız Giriniz";
            this.txtSoyadı.StyleController = this.myDataLayoutControl;
            this.txtSoyadı.TabIndex = 1;
            // 
            // txtAdı
            // 
            this.txtAdı.EnterMoveNextControl = true;
            this.txtAdı.Location = new System.Drawing.Point(70, 36);
            this.txtAdı.MenuManager = this.ribbonControl;
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAdı.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAdı.Properties.MaxLength = 50;
            this.txtAdı.Size = new System.Drawing.Size(138, 20);
            this.txtAdı.StatusBarAciklama = "Kullanıcının Adını Giriniz";
            this.txtAdı.StyleController = this.myDataLayoutControl;
            this.txtAdı.TabIndex = 0;
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.EnterMoveNextControl = true;
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(70, 12);
            this.txtKullanıcıAdı.MenuManager = this.ribbonControl;
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKullanıcıAdı.Properties.Appearance.Options.UseBackColor = true;
            this.txtKullanıcıAdı.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKullanıcıAdı.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKullanıcıAdı.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKullanıcıAdı.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKullanıcıAdı.Properties.MaxLength = 20;
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(138, 20);
            this.txtKullanıcıAdı.StatusBarAciklama = "Kullanıcı Adı Giriniz";
            this.txtKullanıcıAdı.StyleController = this.myDataLayoutControl;
            this.txtKullanıcıAdı.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
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
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 100D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6});
            this.Root.Size = new System.Drawing.Size(384, 224);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKullanıcıAdı;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
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
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Text = "Soyadı";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtEmail;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem5.Size = new System.Drawing.Size(364, 24);
            this.layoutControlItem5.Text = "Email";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtRol;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Text = "Rol";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.txtAçıklama;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem7.Size = new System.Drawing.Size(364, 84);
            this.layoutControlItem7.Text = "Açıklama";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.tglDurum;
            this.layoutControlItem8.Location = new System.Drawing.Point(274, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem8.Size = new System.Drawing.Size(90, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // KullanıcıEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 357);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(386, 358);
            this.Name = "KullanıcıEditForm";
            this.Text = "Kullanıcı Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAçıklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcıAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl;
        private myUserControls.Controls.myToogleSwitch tglDurum;
        private myUserControls.Controls.myMemoEdit txtAçıklama;
        private myUserControls.Controls.myButtonEdit txtRol;
        private myUserControls.Controls.myEposta txtEmail;
        private myUserControls.Controls.myTextEdit txtSoyadı;
        private myUserControls.Controls.myTextEdit txtAdı;
        private myUserControls.Controls.myKodText txtKullanıcıAdı;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}