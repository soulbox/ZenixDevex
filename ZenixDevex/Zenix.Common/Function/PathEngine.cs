using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Function
{
    public class PathEngine
    {
        const string ConfigFolder = "ZenixSolution";
        public static string ZenixSolution { get; }

        public static string ConfigPath { get; private set; }
        static PathEngine()
        {
            var path = $@"{ProgramDataFolder}\{ConfigFolder}";
            System.IO.Directory.CreateDirectory(path);
            ConfigPath = path;
        }
        static string ProgramDataFolder => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        public static void ClearConfigFiles()
        {
            // Delete all files in a directory    
            string[] files = Directory.GetFiles(ConfigPath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                try
                {

                    File.Delete(file);
                    Console.WriteLine($"{file} is deleted.");
                }
                catch (Exception) { }

            }
        }
    }
}
