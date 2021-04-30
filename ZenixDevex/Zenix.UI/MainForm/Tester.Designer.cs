namespace Zenix.WinUI.MainForm
{
    partial class Tester
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
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.myGridview1 = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.myGridColumn1 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.myGridColumn2 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.myGridColumn3 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.myGridColumn4 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.myGridColumn5 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.mySimpleButton1 = new Zenix.WinUI.myUserControls.Controls.mySimpleButton();
            this.rolYetkileriTable1 = new Zenix.WinUI.myUserControls.UserControl.GenelEditTable.RolYetkileriTable();
            this.myGridColumn6 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.myGridColumn7 = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridControl1
            // 
            this.myGridControl1.Location = new System.Drawing.Point(95, 12);
            this.myGridControl1.MainView = this.myGridview1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.myGridControl1.Size = new System.Drawing.Size(714, 211);
            this.myGridControl1.TabIndex = 2;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridview1});
            // 
            // myGridview1
            // 
            this.myGridview1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.myGridview1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridview1.Appearance.FooterPanel.Options.UseFont = true;
            this.myGridview1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.myGridview1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.myGridview1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.myGridview1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.myGridview1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myGridview1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.myGridview1.Appearance.ViewCaption.Options.UseForeColor = true;
            this.myGridview1.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.myGridview1.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myGridview1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.myGridColumn1,
            this.myGridColumn2,
            this.myGridColumn3,
            this.myGridColumn4,
            this.myGridColumn5,
            this.myGridColumn6,
            this.myGridColumn7});
            this.myGridview1.GridControl = this.myGridControl1;
            this.myGridview1.Name = "myGridview1";
            this.myGridview1.OptionsFind.AlwaysVisible = true;
            this.myGridview1.OptionsFind.FindDelay = 100;
            this.myGridview1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.myGridview1.OptionsFind.FindNullPrompt = "Ara";
            this.myGridview1.OptionsFind.ShowFindButton = false;
            this.myGridview1.OptionsMenu.EnableColumnMenu = false;
            this.myGridview1.OptionsMenu.EnableFooterMenu = false;
            this.myGridview1.OptionsMenu.EnableGroupPanelMenu = false;
            this.myGridview1.OptionsNavigation.EnterMoveNextColumn = true;
            this.myGridview1.OptionsPrint.AutoWidth = false;
            this.myGridview1.OptionsPrint.PrintGroupFooter = false;
            this.myGridview1.OptionsView.ColumnAutoWidth = false;
            this.myGridview1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.myGridview1.OptionsView.RowAutoHeight = true;
            this.myGridview1.OptionsView.ShowAutoFilterRow = true;
            this.myGridview1.OptionsView.ShowGroupPanel = false;
            this.myGridview1.OptionsView.ShowViewCaption = true;
            this.myGridview1.StatusBarAciklama = null;
            this.myGridview1.StatusBarKisayol = null;
            this.myGridview1.StatusBarKisayolAciklama = null;
            // 
            // myGridColumn1
            // 
            this.myGridColumn1.Caption = "No";
            this.myGridColumn1.FieldName = "No";
            this.myGridColumn1.Name = "myGridColumn1";
            this.myGridColumn1.StatusBarAciklama = null;
            this.myGridColumn1.StatusBarKisayol = null;
            this.myGridColumn1.StatusBarKisayolAciklama = null;
            this.myGridColumn1.Visible = true;
            this.myGridColumn1.VisibleIndex = 0;
            // 
            // myGridColumn2
            // 
            this.myGridColumn2.Caption = "Adı";
            this.myGridColumn2.FieldName = "Adı";
            this.myGridColumn2.Name = "myGridColumn2";
            this.myGridColumn2.StatusBarAciklama = null;
            this.myGridColumn2.StatusBarKisayol = null;
            this.myGridColumn2.StatusBarKisayolAciklama = null;
            this.myGridColumn2.Visible = true;
            this.myGridColumn2.VisibleIndex = 1;
            // 
            // myGridColumn3
            // 
            this.myGridColumn3.Caption = "Soyadı";
            this.myGridColumn3.FieldName = "Soyadı";
            this.myGridColumn3.Name = "myGridColumn3";
            this.myGridColumn3.StatusBarAciklama = null;
            this.myGridColumn3.StatusBarKisayol = null;
            this.myGridColumn3.StatusBarKisayolAciklama = null;
            this.myGridColumn3.Visible = true;
            this.myGridColumn3.VisibleIndex = 2;
            // 
            // myGridColumn4
            // 
            this.myGridColumn4.Caption = "Görebilir";
            this.myGridColumn4.ColumnEdit = this.repositoryItemCheckEdit1;
            this.myGridColumn4.FieldName = "Görebilir";
            this.myGridColumn4.Name = "myGridColumn4";
            this.myGridColumn4.StatusBarAciklama = null;
            this.myGridColumn4.StatusBarKisayol = null;
            this.myGridColumn4.StatusBarKisayolAciklama = null;
            this.myGridColumn4.Visible = true;
            this.myGridColumn4.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = ((byte)(1));
            this.repositoryItemCheckEdit1.ValueGrayed = ((byte)(2));
            this.repositoryItemCheckEdit1.ValueUnchecked = ((byte)(0));
            // 
            // myGridColumn5
            // 
            this.myGridColumn5.Caption = "Ekleyebilir";
            this.myGridColumn5.ColumnEdit = this.repositoryItemCheckEdit1;
            this.myGridColumn5.FieldName = "Ekleyebilir";
            this.myGridColumn5.Name = "myGridColumn5";
            this.myGridColumn5.StatusBarAciklama = null;
            this.myGridColumn5.StatusBarKisayol = null;
            this.myGridColumn5.StatusBarKisayolAciklama = null;
            this.myGridColumn5.Visible = true;
            this.myGridColumn5.VisibleIndex = 4;
            // 
            // mySimpleButton1
            // 
            this.mySimpleButton1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.mySimpleButton1.Appearance.Options.UseForeColor = true;
            this.mySimpleButton1.Location = new System.Drawing.Point(564, 475);
            this.mySimpleButton1.Name = "mySimpleButton1";
            this.mySimpleButton1.Size = new System.Drawing.Size(177, 34);
            this.mySimpleButton1.StatusBarAciklama = null;
            this.mySimpleButton1.TabIndex = 3;
            this.mySimpleButton1.Text = "mySimpleButton1";
            this.mySimpleButton1.Click += new System.EventHandler(this.mySimpleButton1_Click);
            // 
            // rolYetkileriTable1
            // 
            this.rolYetkileriTable1.Location = new System.Drawing.Point(12, 229);
            this.rolYetkileriTable1.Name = "rolYetkileriTable1";
            this.rolYetkileriTable1.Size = new System.Drawing.Size(699, 214);
            this.rolYetkileriTable1.TabIndex = 4;
            // 
            // myGridColumn6
            // 
            this.myGridColumn6.Caption = "Değiştirebilir";
            this.myGridColumn6.ColumnEdit = this.repositoryItemCheckEdit1;
            this.myGridColumn6.FieldName = "Değiştirebilir";
            this.myGridColumn6.Name = "myGridColumn6";
            this.myGridColumn6.OptionsColumn.AllowEdit = false;
            this.myGridColumn6.StatusBarAciklama = null;
            this.myGridColumn6.StatusBarKisayol = null;
            this.myGridColumn6.StatusBarKisayolAciklama = null;
            this.myGridColumn6.Visible = true;
            this.myGridColumn6.VisibleIndex = 5;
            // 
            // myGridColumn7
            // 
            this.myGridColumn7.Caption = "Silebilir";
            this.myGridColumn7.ColumnEdit = this.repositoryItemCheckEdit1;
            this.myGridColumn7.FieldName = "Silebilir";
            this.myGridColumn7.Name = "myGridColumn7";
            this.myGridColumn7.OptionsColumn.AllowEdit = false;
            this.myGridColumn7.StatusBarAciklama = null;
            this.myGridColumn7.StatusBarKisayol = null;
            this.myGridColumn7.StatusBarKisayolAciklama = null;
            this.myGridColumn7.Visible = true;
            this.myGridColumn7.VisibleIndex = 6;
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 550);
            this.Controls.Add(this.rolYetkileriTable1);
            this.Controls.Add(this.mySimpleButton1);
            this.Controls.Add(this.myGridControl1);
            this.Name = "Tester";
            this.Text = "Tester";
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private myUserControls.Grid.myGridControl myGridControl1;
        private myUserControls.Grid.myGridview myGridview1;
        private myUserControls.Grid.MyGridColumn myGridColumn1;
        private myUserControls.Grid.MyGridColumn myGridColumn2;
        private myUserControls.Grid.MyGridColumn myGridColumn3;
        private myUserControls.Controls.mySimpleButton mySimpleButton1;
        private myUserControls.UserControl.GenelEditTable.RolYetkileriTable rolYetkileriTable1;
        private myUserControls.Grid.MyGridColumn myGridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private myUserControls.Grid.MyGridColumn myGridColumn5;
        private myUserControls.Grid.MyGridColumn myGridColumn6;
        private myUserControls.Grid.MyGridColumn myGridColumn7;
    }
}