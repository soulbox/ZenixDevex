using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenix.Common.Function;
using Zenix.WinUI.MainForm;

namespace Zenix.UI
{
    static class Program
    {
        static ApplicationContext MainContext = new ApplicationContext();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");

            bool countdown = false;
            using (Mutex mtu = new Mutex(true, "myrunapp", out countdown))
            {
                if (countdown)
                {
                    SplashScreenManager.ShowForm(typeof(Splash));

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    if (HWIDEngine.isExcludeMachine)
                        //MainContext.MainForm = new AnaForm();
                    MainContext.MainForm = new Login();
                    else
                        MainContext.MainForm = new Login();




                    Application.Run(MainContext);
                    mtu.ReleaseMutex();

                }
                else
                    MessageBox.Show("Program Zaten Çalışıyor", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static string DeplayVersion()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
            else
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        public static void SetMainForm(Form MainForm)
        {
            MainContext.MainForm = MainForm;
        }

        public static void ShowMainForm()
        {
            MainContext.MainForm.Show();
        }
    }
}
