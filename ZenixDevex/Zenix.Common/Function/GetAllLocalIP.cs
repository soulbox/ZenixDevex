using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Function
{
    public class GetAllLocalIP
    {
        public static List<string> GetIP { get; private set; }

        static GetAllLocalIP()
        {
            GetIP = GetLocalIPAddress();
        }
        static List<string> GetLocalIPAddress()
        {
            List<string> list = new List<string>();
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    list.Add(ip.ToString());
                }
            }
            return list;
        }
    }
}
