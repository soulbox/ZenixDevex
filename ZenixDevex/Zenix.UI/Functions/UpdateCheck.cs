using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenix.Common.Messages;

namespace Zenix.WinUI.Functions
{
    public static class UpdateCheck
    {
        public static void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    Msg.HataMesajı("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later.\nError: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    Msg.HataMesajı("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    Msg.HataMesajı("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    bool  doUpdate = true;
                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = Msg.EvetSeciliEvetHayir("An update is available. Would you like to update the application now?", "Update Available");
                        doUpdate = dr == DialogResult.Yes;

                    }
                    else
                    {
                        Msg.BilgilendirmeMesajı("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.");
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            Msg.BilgilendirmeMesajı("The application has been upgraded, and will now restart.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            Msg.HataMesajı("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. Error: " + dde);
                            return;
                        }
                    }
                }
            }
        }
    }
}
