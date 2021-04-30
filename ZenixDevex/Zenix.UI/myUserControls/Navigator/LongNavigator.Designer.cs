namespace Zenix.WinUI.myUserControls.Navigator
{
    partial class LongNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LongNavigator));
            this.controlNavigator = new DevExpress.XtraEditors.ControlNavigator();
            this.ımageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNavigator
            // 
            this.controlNavigator.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.controlNavigator.Appearance.Options.UseForeColor = true;
            this.controlNavigator.Buttons.Append.ImageIndex = 6;
            this.controlNavigator.Buttons.CancelEdit.Visible = false;
            this.controlNavigator.Buttons.Edit.Visible = false;
            this.controlNavigator.Buttons.EndEdit.Visible = false;
            this.controlNavigator.Buttons.First.ImageIndex = 0;
            this.controlNavigator.Buttons.ImageList = this.ımageCollection;
            this.controlNavigator.Buttons.Last.ImageIndex = 5;
            this.controlNavigator.Buttons.Next.ImageIndex = 3;
            this.controlNavigator.Buttons.NextPage.ImageIndex = 4;
            this.controlNavigator.Buttons.Prev.ImageIndex = 2;
            this.controlNavigator.Buttons.PrevPage.ImageIndex = 1;
            this.controlNavigator.Buttons.Remove.ImageIndex = 7;
            this.controlNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator.Location = new System.Drawing.Point(0, 0);
            this.controlNavigator.Name = "controlNavigator";
            this.controlNavigator.Size = new System.Drawing.Size(403, 24);
            this.controlNavigator.TabIndex = 0;
            this.controlNavigator.Text = "controlNavigator1";
            this.controlNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.controlNavigator.TextStringFormat = "Kayıtlar ( {0} / {1} )";
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
            // LongNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlNavigator);
            this.Name = "LongNavigator";
            this.Size = new System.Drawing.Size(403, 24);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ImageCollection ımageCollection;
        public DevExpress.XtraEditors.ControlNavigator controlNavigator;
    }
}
