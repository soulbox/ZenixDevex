namespace Zenix.WinUI.MainForm
{
    partial class Login
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
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl1 = new Zenix.WinUI.myUserControls.Controls.myDataLayoutControl();
            this.btnUnuttum = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.chckHatırla = new Zenix.WinUI.myUserControls.Controls.myCheckEdit();
            this.txtPassword = new Zenix.WinUI.myUserControls.Controls.myTextEdit();
            this.txtusername = new Zenix.WinUI.myUserControls.Controls.myTextEdit();
            this.btnGiriş = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.laysif = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblVers = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).BeginInit();
            this.myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chckHatırla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laysif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataLayoutControl1
            // 
            this.myDataLayoutControl1.Controls.Add(this.btnUnuttum);
            this.myDataLayoutControl1.Controls.Add(this.chckHatırla);
            this.myDataLayoutControl1.Controls.Add(this.txtPassword);
            this.myDataLayoutControl1.Controls.Add(this.txtusername);
            this.myDataLayoutControl1.Controls.Add(this.btnGiriş);
            this.myDataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.myDataLayoutControl1.Name = "myDataLayoutControl1";
            this.myDataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(910, 63, 650, 400);
            this.myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl1.Root = this.Root;
            this.myDataLayoutControl1.Size = new System.Drawing.Size(384, 190);
            this.myDataLayoutControl1.TabIndex = 0;
            this.myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // btnUnuttum
            // 
            this.btnUnuttum.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnUnuttum.Location = new System.Drawing.Point(290, 60);
            this.btnUnuttum.Name = "btnUnuttum";
            this.btnUnuttum.Size = new System.Drawing.Size(82, 20);
            this.btnUnuttum.StyleController = this.myDataLayoutControl1;
            this.btnUnuttum.TabIndex = 4;
            this.btnUnuttum.Text = "Şifremi Unuttum";
            this.btnUnuttum.UseMnemonic = false;
            this.btnUnuttum.Click += new System.EventHandler(this.btnUnuttum_Click);
            // 
            // chckHatırla
            // 
            this.chckHatırla.EnterMoveNextControl = true;
            this.chckHatırla.Location = new System.Drawing.Point(40, 84);
            this.chckHatırla.Name = "chckHatırla";
            this.chckHatırla.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.chckHatırla.Properties.Appearance.Options.UseForeColor = true;
            this.chckHatırla.Properties.Caption = "Hatırla";
            this.chckHatırla.Size = new System.Drawing.Size(246, 20);
            this.chckHatırla.StatusBarAciklama = null;
            this.chckHatırla.StyleController = this.myDataLayoutControl1;
            this.chckHatırla.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(105, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPassword.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPassword.Properties.MaxLength = 50;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
            this.txtPassword.StatusBarAciklama = null;
            this.txtPassword.StyleController = this.myDataLayoutControl1;
            this.txtPassword.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.EnterMoveNextControl = true;
            this.txtusername.Location = new System.Drawing.Point(105, 36);
            this.txtusername.Name = "txtusername";
            this.txtusername.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtusername.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtusername.Properties.MaxLength = 50;
            this.txtusername.Size = new System.Drawing.Size(181, 20);
            this.txtusername.StatusBarAciklama = null;
            this.txtusername.StyleController = this.myDataLayoutControl1;
            this.txtusername.TabIndex = 0;
            // 
            // btnGiriş
            // 
            this.btnGiriş.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnGiriş.Appearance.Options.UseForeColor = true;
            this.btnGiriş.Location = new System.Drawing.Point(40, 108);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(246, 20);
            this.btnGiriş.StyleController = this.myDataLayoutControl1;
            this.btnGiriş.TabIndex = 2;
            this.btnGiriş.Text = "Giriş";
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.laysif,
            this.lblVers,
            this.layoutControlItem2,
            this.layout});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 25D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 250D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 75D;
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
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7});
            this.Root.Size = new System.Drawing.Size(384, 190);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnGiriş;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(28, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem4.Size = new System.Drawing.Size(250, 24);
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtusername;
            this.layoutControlItem1.Location = new System.Drawing.Point(28, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(250, 24);
            this.layoutControlItem1.Text = "Kullanıcı Adı :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
            // 
            // laysif
            // 
            this.laysif.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.laysif.AppearanceItemCaption.Options.UseForeColor = true;
            this.laysif.Control = this.txtPassword;
            this.laysif.Location = new System.Drawing.Point(28, 48);
            this.laysif.Name = "laysif";
            this.laysif.OptionsTableLayoutItem.ColumnIndex = 1;
            this.laysif.OptionsTableLayoutItem.RowIndex = 2;
            this.laysif.Size = new System.Drawing.Size(250, 24);
            this.laysif.Text = "Şifre :";
            this.laysif.TextSize = new System.Drawing.Size(62, 13);
            // 
            // lblVers
            // 
            this.lblVers.AllowHotTrack = false;
            this.lblVers.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lblVers.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblVers.Location = new System.Drawing.Point(0, 144);
            this.lblVers.Name = "lblVers";
            this.lblVers.OptionsTableLayoutItem.ColumnSpan = 2;
            this.lblVers.OptionsTableLayoutItem.RowIndex = 6;
            this.lblVers.Size = new System.Drawing.Size(278, 26);
            this.lblVers.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.chckHatırla;
            this.layoutControlItem2.Location = new System.Drawing.Point(28, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem2.Size = new System.Drawing.Size(250, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layout
            // 
            this.layout.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layout.AppearanceItemCaption.Options.UseForeColor = true;
            this.layout.Control = this.btnUnuttum;
            this.layout.Location = new System.Drawing.Point(278, 48);
            this.layout.MinSize = new System.Drawing.Size(80, 17);
            this.layout.Name = "layout";
            this.layout.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layout.OptionsTableLayoutItem.RowIndex = 2;
            this.layout.Size = new System.Drawing.Size(86, 24);
            this.layout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout.Text = "Unuttum";
            this.layout.TextSize = new System.Drawing.Size(0, 0);
            this.layout.TextVisible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 190);
            this.Controls.Add(this.myDataLayoutControl1);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(358, 222);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl1)).EndInit();
            this.myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chckHatırla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laysif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private myUserControls.Controls.myTextEdit txtPassword;
        private myUserControls.Controls.myTextEdit txtusername;
        private DevExpress.XtraEditors.SimpleButton btnGiriş;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem laysif;
        private DevExpress.XtraLayout.SimpleLabelItem lblVers;
        private myUserControls.Controls.myCheckEdit chckHatırla;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.HyperlinkLabelControl btnUnuttum;
        private DevExpress.XtraLayout.LayoutControlItem layout;
    }
}