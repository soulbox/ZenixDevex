using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Function
{
    public static class Crypto
    {
        public static string Md5Şifrele(this string value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var byt = Encoding.UTF8.GetBytes(value);
            byt = md5.ComputeHash(byt);
            return BitConverter.ToString(byt).Replace("-", "");
        }

        public static SecureString ConvertToSecureString(this string value)
        {
            var result = new SecureString();
            if (value.Length > 0)
                value.ToCharArray().ForEach(x => result.AppendChar(x));
            result.MakeReadOnly();
            return result;
        }
        public static string ConvertToUnsecureString(this SecureString value)
        {
            var result = Marshal.SecureStringToBSTR(value);
            return Marshal.PtrToStringAuto(result);
        }
    }
}
