namespace Zenix.WinUI.Forms.PaketlemeFormu
{
    partial class PaketlemeEditForm
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
            this.txtAçıklama = new Zenix.WinUI.myUserControls.Controls.myMemoEdit();
            this.tglDurum = new Zenix.WinUI.myUserControls.Controls.myToogleSwitch();
            this.txtKod = new Zenix.WinUI.myUserControls.Controls.myKodText();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmbAyartipi = new Zenix.WinUI.myUserControls.Controls.myComboBoxEdit();
            this.txtKutu = new Zenix.WinUI.myUserControls.Controls.mySpinEdit();
            this.txtStand = new Zenix.WinUI.myUserControls.Controls.mySpinEdit();
            this.txtKoli = new Zenix.WinUI.myUserControls.Controls.mySpinEdit();
            this.cmbBirim = new Zenix.WinUI.myUserControls.Controls.myComboBoxEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAçıklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAyartipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKutu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(405, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.cmbBirim);
            this.myDataLayoutControl.Controls.Add(this.txtKoli);
            this.myDataLayoutControl.Controls.Add(this.txtStand);
            this.myDataLayoutControl.Controls.Add(this.txtKutu);
            this.myDataLayoutControl.Controls.Add(this.cmbAyartipi);
            this.myDataLayoutControl.Controls.Add(this.txtAçıklama);
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(405, 246);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.EnterMoveNextControl = true;
            this.txtAçıklama.Location = new System.Drawing.Point(57, 180);
            this.txtAçıklama.MenuManager = this.ribbonControl;
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAçıklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAçıklama.Properties.MaxLength = 500;
            this.txtAçıklama.Size = new System.Drawing.Size(336, 54);
            this.txtAçıklama.StatusBarAciklama = "Açıklama Giriniz.";
            this.txtAçıklama.StyleController = this.myDataLayoutControl;
            this.txtAçıklama.TabIndex = 1;
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(307, 12);
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
            this.tglDurum.TabIndex = 2;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(57, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(151, 20);
            this.txtKod.StatusBarAciklama = "Kod Giriniz";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem3});
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
            this.Root.Size = new System.Drawing.Size(405, 246);
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
            this.layoutControlItem1.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.tglDurum;
            this.layoutControlItem2.Location = new System.Drawing.Point(295, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem2.Size = new System.Drawing.Size(90, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtAçıklama;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 7;
            this.layoutControlItem4.Size = new System.Drawing.Size(385, 58);
            this.layoutControlItem4.Text = "Açıklama";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(42, 13);
            // 
            // cmbAyartipi
            // 
            this.cmbAyartipi.EnterMoveNextControl = true;
            this.cmbAyartipi.Location = new System.Drawing.Point(57, 60);
            this.cmbAyartipi.MenuManager = this.ribbonControl;
            this.cmbAyartipi.Name = "cmbAyartipi";
            this.cmbAyartipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.cmbAyartipi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cmbAyartipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAyartipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbAyartipi.Size = new System.Drawing.Size(151, 20);
            this.cmbAyartipi.StatusBarAciklama = null;
            this.cmbAyartipi.StatusBarKisayol = "F4 :";
            this.cmbAyartipi.StatusBarKisayolAciklama = "Seç";
            this.cmbAyartipi.StyleController = this.myDataLayoutControl;
            this.cmbAyartipi.TabIndex = 4;
            // 
            // txtKutu
            // 
            this.txtKutu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtKutu.EnterMoveNextControl = true;
            this.txtKutu.Location = new System.Drawing.Point(57, 84);
            this.txtKutu.MenuManager = this.ribbonControl;
            this.txtKutu.Name = "txtKutu";
            this.txtKutu.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtKutu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKutu.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKutu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKutu.Properties.Mask.EditMask = "d";
            this.txtKutu.Size = new System.Drawing.Size(151, 20);
            this.txtKutu.StatusBarAciklama = null;
            this.txtKutu.StyleController = this.myDataLayoutControl;
            this.txtKutu.TabIndex = 5;
            // 
            // txtStand
            // 
            this.txtStand.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtStand.EnterMoveNextControl = true;
            this.txtStand.Location = new System.Drawing.Point(57, 108);
            this.txtStand.MenuManager = this.ribbonControl;
            this.txtStand.Name = "txtStand";
            this.txtStand.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtStand.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtStand.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtStand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStand.Properties.Mask.EditMask = "d";
            this.txtStand.Size = new System.Drawing.Size(151, 20);
            this.txtStand.StatusBarAciklama = null;
            this.txtStand.StyleController = this.myDataLayoutControl;
            this.txtStand.TabIndex = 6;
            // 
            // txtKoli
            // 
            this.txtKoli.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtKoli.EnterMoveNextControl = true;
            this.txtKoli.Location = new System.Drawing.Point(57, 132);
            this.txtKoli.MenuManager = this.ribbonControl;
            this.txtKoli.Name = "txtKoli";
            this.txtKoli.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtKoli.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKoli.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKoli.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKoli.Properties.Mask.EditMask = "d";
            this.txtKoli.Size = new System.Drawing.Size(151, 20);
            this.txtKoli.StatusBarAciklama = null;
            this.txtKoli.StyleController = this.myDataLayoutControl;
            this.txtKoli.TabIndex = 7;
            // 
            // cmbBirim
            // 
            this.cmbBirim.EnterMoveNextControl = true;
            this.cmbBirim.Location = new System.Drawing.Point(57, 156);
            this.cmbBirim.MenuManager = this.ribbonControl;
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.cmbBirim.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cmbBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBirim.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbBirim.Size = new System.Drawing.Size(151, 20);
            this.cmbBirim.StatusBarAciklama = null;
            this.cmbBirim.StatusBarKisayol = "F4 :";
            this.cmbBirim.StatusBarKisayolAciklama = "Seç";
            this.cmbBirim.StyleController = this.myDataLayoutControl;
            this.cmbBirim.TabIndex = 8;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.cmbBirim;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 6;
            this.layoutControlItem8.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.Text = "Birim";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.txtKoli;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Text = "Koli İçi";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtStand;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Text = "Stand İçi";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtKutu;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Text = "Kutu İçi";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(42, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.cmbAyartipi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Text = "Ayar Tipi";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(42, 13);
            // 
            // PaketlemeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 379);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(407, 380);
            this.Name = "PaketlemeEditForm";
            this.Text = "PaketlemeEditForm";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAçıklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAyartipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKutu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUserControls.Controls.myDataLayoutControl myDataLayoutControl;
        private myUserControls.Controls.myMemoEdit txtAçıklama;
        private myUserControls.Controls.myToogleSwitch tglDurum;
        private myUserControls.Controls.myKodText txtKod;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private myUserControls.Controls.myComboBoxEdit cmbBirim;
        private myUserControls.Controls.mySpinEdit txtKoli;
        private myUserControls.Controls.mySpinEdit txtStand;
        private myUserControls.Controls.mySpinEdit txtKutu;
        private myUserControls.Controls.myComboBoxEdit cmbAyartipi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}