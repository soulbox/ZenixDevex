using System;
using System.Management;

namespace Zenix.Common.HWID
{
    internal static class MotherboardId
    {
		public static string GetMotherBoardID()
		{
			string mbInfo = String.Empty;
			ManagementScope scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
			scope.Connect();
			ManagementObject wmiClass = new ManagementObject(scope, new ManagementPath("Win32_BaseBoard.Tag=\"Base Board\""), new ObjectGetOptions());

			foreach (PropertyData propData in wmiClass.Properties)
			{
				if (propData.Name == "SerialNumber")
					mbInfo = String.Format("{0,-25}{1}", propData.Name, Convert.ToString(propData.Value));
			}

			return mbInfo;
		}
		public static string GetMotherBoardIdv2() 
		{
			ManagementClass mc = new ManagementClass("Win32_BaseBoard");
			ManagementObjectCollection moc = mc.GetInstances();
			string strID = null;
			foreach (ManagementObject mo in moc)
			{
				strID = mo.Properties["SerialNumber"].Value.ToString();
				break;
			}
			return strID;
		}
	}

}
