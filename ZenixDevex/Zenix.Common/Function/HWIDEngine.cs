using System.Collections.Generic;
using System.IO;
using System.Linq;
using Zenix.Common.HWID;

namespace Zenix.Common.Function
{
    public static class HWIDEngine
    {
        public static string SimpleUid { get; private set; }

        public static string AdvancedUid { get; private set; }
        public static List<string> ExcludeHwid { get; }

        public static bool isExcludeMachine { get; }

        const string homepc = "B800D754178BFBFF00600F12MBATUU0NLE8İVSYL5CVXDGTBSEOCQ30FGJENRXEEIAE084B2C601621E867D248D219A8DF0F69";
        const string workpc = "91E4D299178BFBFF00600F12GS4KUXWEGQ0CGNAJSQHTMA0FE505BA2C01B680EAD5D69269C3E438";
        const string workpc2 = "91E4D299178BFBFF00600F12GS4KUXWEGQ0CGNAJSQHTMA6ED108C425FB49CA0732C6F15BF5F673";

        public static bool isHomePc { get; }
        public static bool isWorkPc { get; }


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
            ExcludeHwid = new List<string>() { homepc, workpc, workpc2 };
            isHomePc = AdvancedUid.Equals(homepc);
            isWorkPc = AdvancedUid.Equals(isWorkPc) | AdvancedUid.Equals(workpc2);

            isExcludeMachine = ExcludeHwid.Any(x => x.Equals(AdvancedUid));
        }

    }
}