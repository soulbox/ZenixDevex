using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Zenix.UI;

namespace Zenix.WinUI.MainForm
{
    public partial class Splash : SplashScreen
    {
        public Splash()
        {
            InitializeComponent();
            //this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
            lblVers.Text = $"Versiyon :{Program.DeplayVersion()}";
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}