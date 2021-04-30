namespace Zenix.WinUI.myUserControls.UserControl.GenelEditTable
{
    partial class RolYetkileriTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myGridControl1 = new Zenix.WinUI.myUserControls.Grid.myGridControl();
            this.tablo = new Zenix.WinUI.myUserControls.Grid.myGridview();
            this.colId = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKartTürü = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colGörebilir = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.repoCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colEkleyebilir = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colDeğiştirebilir = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colSilebilir = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            this.colKısmiGörüntü = new Zenix.WinUI.myUserControls.Grid.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpdNavigator
            // 
            this.insUpdNavigator.Location = new System.Drawing.Point(0, 361);
            this.insUpdNavigator.Size = new System.Drawing.Size(646, 24);
            // 
            // myGridControl1
            // 
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.tablo;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheck});
            this.myGridControl1.Size = new System.Drawing.Size(646, 361);
            this.myGridControl1.TabIndex = 5;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.tablo.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKartTürü,
            this.colGörebilir,
            this.colEkleyebilir,
            this.colDeğiştirebilir,
            this.colSilebilir,
            this.colKısmiGörüntü});
            this.tablo.GridControl = this.myGridControl1;
            this.tablo.Name = "tablo";
            this.tablo.OptionsFind.FindDelay = 100;
            this.tablo.OptionsFind.FindNullPrompt = "Ara";
            this.tablo.OptionsFind.ShowFindButton = false;
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Rol Yetki Kartları";
            this.tablo.StatusBarKisayol = "Shift+Insert";
            this.tablo.StatusBarKisayolAciklama = "Yetki Kartı Ekle";
            this.tablo.ViewCaption = "Rol Yetkileri";
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
            // colKartTürü
            // 
            this.colKartTürü.Caption = "Kart Türü";
            this.colKartTürü.FieldName = "KartTuru";
            this.colKartTürü.Name = "colKartTürü";
            this.colKartTürü.OptionsColumn.AllowEdit = false;
            this.colKartTürü.OptionsFilter.AllowAutoFilter = false;
            this.colKartTürü.OptionsFilter.AllowFilter = false;
            this.colKartTürü.StatusBarAciklama = null;
            this.colKartTürü.StatusBarKisayol = null;
            this.colKartTürü.StatusBarKisayolAciklama = null;
            this.colKartTürü.Visible = true;
            this.colKartTürü.VisibleIndex = 0;
            this.colKartTürü.Width = 233;
            // 
            // colGörebilir
            // 
            this.colGörebilir.Caption = "Görebilir";
            this.colGörebilir.ColumnEdit = this.repoCheck;
            this.colGörebilir.FieldName = "Görebilir";
            this.colGörebilir.Name = "colGörebilir";
            this.colGörebilir.OptionsFilter.AllowAutoFilter = false;
            this.colGörebilir.OptionsFilter.AllowFilter = false;
            this.colGörebilir.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colGörebilir.StatusBarAciklama = null;
            this.colGörebilir.StatusBarKisayol = null;
            this.colGörebilir.StatusBarKisayolAciklama = null;
            this.colGörebilir.Visible = true;
            this.colGörebilir.VisibleIndex = 1;
            // 
            // repoCheck
            // 
            this.repoCheck.AutoHeight = false;
            this.repoCheck.Name = "repoCheck";
            this.repoCheck.ValueChecked = ((byte)(1));
            this.repoCheck.ValueGrayed = ((byte)(2));
            this.repoCheck.ValueUnchecked = ((byte)(0));
            // 
            // colEkleyebilir
            // 
            this.colEkleyebilir.Caption = "Ekleyebilir";
            this.colEkleyebilir.ColumnEdit = this.repoCheck;
            this.colEkleyebilir.FieldName = "Ekleyebilir";
            this.colEkleyebilir.Name = "colEkleyebilir";
            this.colEkleyebilir.OptionsFilter.AllowAutoFilter = false;
            this.colEkleyebilir.OptionsFilter.AllowFilter = false;
            this.colEkleyebilir.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colEkleyebilir.StatusBarAciklama = null;
            this.colEkleyebilir.StatusBarKisayol = null;
            this.colEkleyebilir.StatusBarKisayolAciklama = null;
            this.colEkleyebilir.Visible = true;
            this.colEkleyebilir.VisibleIndex = 2;
            // 
            // colDeğiştirebilir
            // 
            this.colDeğiştirebilir.Caption = "Değiştirebilir";
            this.colDeğiştirebilir.ColumnEdit = this.repoCheck;
            this.colDeğiştirebilir.FieldName = "Değiştirebilir";
            this.colDeğiştirebilir.Name = "colDeğiştirebilir";
            this.colDeğiştirebilir.OptionsFilter.AllowAutoFilter = false;
            this.colDeğiştirebilir.OptionsFilter.AllowFilter = false;
            this.colDeğiştirebilir.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colDeğiştirebilir.StatusBarAciklama = null;
            this.colDeğiştirebilir.StatusBarKisayol = null;
            this.colDeğiştirebilir.StatusBarKisayolAciklama = null;
            this.colDeğiştirebilir.Visible = true;
            this.colDeğiştirebilir.VisibleIndex = 3;
            // 
            // colSilebilir
            // 
            this.colSilebilir.Caption = "Silebilir";
            this.colSilebilir.ColumnEdit = this.repoCheck;
            this.colSilebilir.FieldName = "Silebilir";
            this.colSilebilir.Name = "colSilebilir";
            this.colSilebilir.OptionsFilter.AllowAutoFilter = false;
            this.colSilebilir.OptionsFilter.AllowFilter = false;
            this.colSilebilir.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colSilebilir.StatusBarAciklama = null;
            this.colSilebilir.StatusBarKisayol = null;
            this.colSilebilir.StatusBarKisayolAciklama = null;
            this.colSilebilir.Visible = true;
            this.colSilebilir.VisibleIndex = 4;
            // 
            // colKısmiGörüntü
            // 
            this.colKısmiGörüntü.Caption = "Kısmi Görüntü";
            this.colKısmiGörüntü.ColumnEdit = this.repoCheck;
            this.colKısmiGörüntü.FieldName = "KısmiGörüntü";
            this.colKısmiGörüntü.Name = "colKısmiGörüntü";
            this.colKısmiGörüntü.OptionsFilter.AllowAutoFilter = false;
            this.colKısmiGörüntü.OptionsFilter.AllowFilter = false;
            this.colKısmiGörüntü.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colKısmiGörüntü.StatusBarAciklama = null;
            this.colKısmiGörüntü.StatusBarKisayol = null;
            this.colKısmiGörüntü.StatusBarKisayolAciklama = null;
            this.colKısmiGörüntü.Visible = true;
            this.colKısmiGörüntü.VisibleIndex = 5;
            // 
            // RolYetkileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myGridControl1);
            this.Name = "RolYetkileriTable";
            this.Size = new System.Drawing.Size(646, 385);
            this.Controls.SetChildIndex(this.insUpdNavigator, 0);
            this.Controls.SetChildIndex(this.myGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grid.myGridControl myGridControl1;
        private Grid.MyGridColumn colId;
        private Grid.MyGridColumn colKartTürü;
        private Grid.MyGridColumn colGörebilir;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheck;
        private Grid.MyGridColumn colEkleyebilir;
        private Grid.MyGridColumn colDeğiştirebilir;
        private Grid.MyGridColumn colSilebilir;
        public Grid.myGridview tablo;
        private Grid.MyGridColumn colKısmiGörüntü;
    }
}
