namespace Zenix.WinUI.myUserControls.Navigator
{
    partial class SmallNavigator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmallNavigator));
            this.ımageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.Navigator = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageCollection
            // 
            this.ımageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection.ImageStream")));
            this.ımageCollection.Images.SetKeyName(0, "first_16x16.png");
            this.ımageCollection.Images.SetKeyName(1, "doubleprev_16x16.png");
            this.ımageCollection.Images.SetKeyName(2, "prev_16x16.png");
            this.ımageCollection.Images.SetKeyName(3, "next_16x16.png");
            this.ımageCollection.Images.SetKeyName(4, "doublenext_16x16.png");
            this.ımageCollection.Images.SetKeyName(5, "last_16x16.png");
            this.ımageCollection.InsertImage(global::Zenix.WinUI.Properties.Resources.addfile_16x16, "addfile_16x16", typeof(global::Zenix.WinUI.Properties.Resources), 6);
            this.ımageCollection.Images.SetKeyName(6, "addfile_16x16");
            this.ımageCollection.InsertImage(global::Zenix.WinUI.Properties.Resources.deletelist_16x16, "deletelist_16x16", typeof(global::Zenix.WinUI.Properties.Resources), 7);
            this.ımageCollection.Images.SetKeyName(7, "deletelist_16x16");
            // 
            // Navigator
            // 
            this.Navigator.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Navigator.Appearance.Options.UseForeColor = true;
            this.Navigator.Buttons.Append.ImageIndex = 6;
            this.Navigator.Buttons.CancelEdit.Visible = false;
            this.Navigator.Buttons.Edit.Visible = false;
            this.Navigator.Buttons.EndEdit.Visible = false;
            this.Navigator.Buttons.First.ImageIndex = 0;
            this.Navigator.Buttons.ImageList = this.ımageCollection;
            this.Navigator.Buttons.Last.ImageIndex = 5;
            this.Navigator.Buttons.Next.ImageIndex = 3;
            this.Navigator.Buttons.NextPage.Visible = false;
            this.Navigator.Buttons.Prev.ImageIndex = 2;
            this.Navigator.Buttons.PrevPage.Visible = false;
            this.Navigator.Buttons.Remove.ImageIndex = 7;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Location = new System.Drawing.Point(0, 0);
            this.Navigator.Name = "Navigator";
            this.Navigator.Size = new System.Drawing.Size(600, 24);
            this.Navigator.TabIndex = 1;
            this.Navigator.Text = "controlNavigator1";
            this.Navigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.Navigator.TextStringFormat = "Kayıtlar ( {0} / {1} )";
            // 
            // SmallNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Navigator);
            this.Name = "SmallNavigator";
            this.Size = new System.Drawing.Size(600, 24);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ImageCollection ımageCollection;
        private DevExpress.XtraEditors.ControlNavigator Navigator;
    }
}
