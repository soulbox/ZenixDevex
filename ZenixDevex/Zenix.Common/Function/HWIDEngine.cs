using System.Collections.Generic;
using System.IO;
using System.Linq;
using Zenix.Common.HWID;

namespace Zenix.Common.Function
{
    public static class HWIDEngine
    {
        public static string SimpleUid { get; }

        public static string AdvancedUid { get; }

        public static List<string> ExcludeHwid { get; }

        public static bool isExcludeMachine { get; }
        static HWIDEngine()
        {
            var volumeSerial = DiskId.GetDiskId();
            var cpuId = CpuId.GetCpuId();
            var windowsId = WindowsId.GetWindowsId();
            //var motherboardId = MotherboardId.GetMotherBoardIdv2().Trim().ToHexString()
            var motherboardId = EncDesc.Encrypt(MotherboardId.GetMotherBoardIdv2().Trim()).Replace("=", "").ToUpper();
            SimpleUid = volumeSerial + cpuId;
            AdvancedUid = SimpleUid + motherboardId + windowsId;
            using (StreamWriter writer = new StreamWriter(PathEngine.ConfigPath + @"\HWID.txt", false))
            {
                writer.WriteLine($"volumeSerial:{volumeSerial}");
                writer.WriteLine($"cpuId:{cpuId}");
                writer.WriteLine($"windowsId:{windowsId}");
                writer.WriteLine($"motherboardId:{motherboardId}");
                writer.WriteLine($"AdvancedUid:{AdvancedUid}");
                writer.WriteLine($"SimpleUid:{SimpleUid}");
                writer.Close();
            }
            ExcludeHwid = new List<string>()
                    {
                    "B800D754178BFBFF00600F12MBATUU0NLE8İVSYL5CVXDGTBSEOCQ30FGJENRXEEIAE084B2C601621E867D248D219A8DF0F69",
                    "91E4D299178BFBFF00600F12GS4KUXWEGQ0CGNAJSQHTMA0FE505BA2C01B680EAD5D69269C3E438"
                    };
            isExcludeMachine = ExcludeHwid.Any(x => x.Equals(AdvancedUid));
        }
    }
}