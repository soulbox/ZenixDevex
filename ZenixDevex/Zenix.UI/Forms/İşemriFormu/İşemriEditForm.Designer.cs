﻿namespace Zenix.WinUI.Forms.İşemriFormu
{
    partial class İşemriEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new Zenix.WinUI.myUserControls.Controls.myDataLayoutControl();
            this.dtTarih = new Zenix.WinUI.myUserControls.Controls.myDateEdit();
            this.txtKazan = new Zenix.WinUI.myUserControls.Controls.myButtonEdit();
            this.txtŞarjMiktarı = new Zenix.WinUI.myUserControls.Controls.mySpinEdit();
            this.txtŞarj = new Zenix.WinUI.myUserControls.Controls.myButtonEdit();
            this.txtReçete = new Zenix.WinUI.myUserControls.Controls.myButtonEdit();
            this.tglDurum = new Zenix.WinUI.myUserControls.Controls.myToogleSwitch();
            this.txtKod = new Zenix.WinUI.myUserControls.Controls.myKodText();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKazan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtŞarjMiktarı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtŞarj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReçete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(492, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.dtTarih);
            this.myDataLayoutControl.Controls.Add(this.txtKazan);
            this.myDataLayoutControl.Controls.Add(this.txtŞarjMiktarı);
            this.myDataLayoutControl.Controls.Add(this.txtŞarj);
            this.myDataLayoutControl.Controls.Add(this.txtReçete);
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(492, 191);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // dtTarih
            // 
            this.dtTarih.EditValue = null;
            this.dtTarih.EnterMoveNextControl = true;
            this.dtTarih.Location = new System.Drawing.Point(70, 132);
            this.dtTarih.MenuManager = this.ribbonControl;
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtTarih.Properties.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.dtTarih.Properties.Appearance.Options.UseBackColor = true;
            this.dtTarih.Properties.Appearance.Options.UseTextOptions = true;
            this.dtTarih.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtTarih.Size = new System.Drawing.Size(138, 20);
            this.dtTarih.StatusBarAciklama = "Tarih Giriniz";
            this.dtTarih.StatusBarKisayol = "F4 :";
            this.dtTarih.StatusBarKisayolAciklama = "Tarih Seç";
            this.dtTarih.StyleController = this.myDataLayoutControl;
            this.dtTarih.TabIndex = 4;
            // 
            // txtKazan
            // 
            this.txtKazan.EditValue = "";
            this.txtKazan.EnterMoveNextControl = true;
            this.txtKazan.Id = null;
            this.txtKazan.Location = new System.Drawing.Point(70, 108);
            this.txtKazan.MenuManager = this.ribbonControl;
            this.txtKazan.Name = "txtKazan";
            this.txtKazan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKazan.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKazan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKazan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtKazan.Size = new System.Drawing.Size(138, 20);
            this.txtKazan.StatusBarAciklama = "Kazan No Seçiniz";
            this.txtKazan.StatusBarKisayol = "F4 :";
            this.txtKazan.StatusBarKisayolAciklama = "Seç";
            this.txtKazan.StyleController = this.myDataLayoutControl;
            this.txtKazan.TabIndex = 3;
            // 
            // txtŞarjMiktarı
            // 
            this.txtŞarjMiktarı.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtŞarjMiktarı.EnterMoveNextControl = true;
            this.txtŞarjMiktarı.Location = new System.Drawing.Point(70, 84);
            this.txtŞarjMiktarı.MenuManager = this.ribbonControl;
            this.txtŞarjMiktarı.Name = "txtŞarjMiktarı";
            this.txtŞarjMiktarı.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtŞarjMiktarı.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtŞarjMiktarı.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtŞarjMiktarı.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtŞarjMiktarı.Properties.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtŞarjMiktarı.Properties.Mask.EditMask = "d";
            this.txtŞarjMiktarı.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtŞarjMiktarı.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtŞarjMiktarı.Size = new System.Drawing.Size(138, 20);
            this.txtŞarjMiktarı.StatusBarAciklama = "Şarj Miktarı Giriniz";
            this.txtŞarjMiktarı.StyleController = this.myDataLayoutControl;
            this.txtŞarjMiktarı.TabIndex = 2;
            // 
            // txtŞarj
            // 
            this.txtŞarj.EnterMoveNextControl = true;
            this.txtŞarj.Id = null;
            this.txtŞarj.Location = new System.Drawing.Point(70, 60);
            this.txtŞarj.MenuManager = this.ribbonControl;
            this.txtŞarj.Name = "txtŞarj";
            this.txtŞarj.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtŞarj.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtŞarj.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtŞarj.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtŞarj.Size = new System.Drawing.Size(320, 20);
            this.txtŞarj.StatusBarAciklama = "Şarj Seç";
            this.txtŞarj.StatusBarKisayol = "F4 :";
            this.txtŞarj.StatusBarKisayolAciklama = "Seç";
            this.txtŞarj.StyleController = this.myDataLayoutControl;
            this.txtŞarj.TabIndex = 1;
            // 
            // txtReçete
            // 
            this.txtReçete.EnterMoveNextControl = true;
            this.txtReçete.Id = null;
            this.txtReçete.Location = new System.Drawing.Point(70, 36);
            this.txtReçete.MenuManager = this.ribbonControl;
            this.txtReçete.Name = "txtReçete";
            this.txtReçete.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtReçete.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtReçete.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtReçete.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtReçete.Size = new System.Drawing.Size(320, 20);
            this.txtReçete.StatusBarAciklama = "Reçete Seç";
            this.txtReçete.StatusBarKisayol = "F4 :";
            this.txtReçete.StatusBarKisayolAciklama = "Seç";
            this.txtReçete.StyleController = this.myDataLayoutControl;
            this.txtReçete.TabIndex = 0;
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(394, 12);
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
            this.tglDurum.StatusBarAciklama = null;
            this.tglDurum.StyleController = this.myDataLayoutControl;
            this.tglDurum.TabIndex = 5;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(70, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(138, 20);
            this.txtKod.StatusBarAciklama = "Kod Giriniz";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem5});
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
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition8.Height = 100D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7,
            rowDefinition8});
            this.Root.Size = new System.Drawing.Size(492, 191);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Text = "Kod";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.tglDurum;
            this.layoutControlItem2.Location = new System.Drawing.Point(382, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem2.Size = new System.Drawing.Size(90, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtReçete;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(382, 24);
            this.layoutControlItem3.Text = "Reçete";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtŞarj;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(382, 24);
            this.layoutControlItem4.Text = "Şarj";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.dtTarih;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Text = "Tarih";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtKazan;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Text = "Kazan";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtŞarjMiktarı;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Text = "Şarz Miktarı";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(55, 13);
            // 
            // İşemriEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 324);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MaximumSize = new System.Drawing.Size(494, 325);
            this.Name = "İşemriEditForm";
            this.Text = "İşemriEditForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKazan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtŞarjMiktarı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtŞarj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReçete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl;
        private myUserControls.Controls.myToogleSwitch tglDurum;
        private myUserControls.Controls.myKodText txtKod;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private myUserControls.Controls.mySpinEdit txtŞarjMiktarı;
        private myUserControls.Controls.myButtonEdit txtŞarj;
        private myUserControls.Controls.myButtonEdit txtReçete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private myUserControls.Controls.myDateEdit dtTarih;
        private myUserControls.Controls.myButtonEdit txtKazan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}