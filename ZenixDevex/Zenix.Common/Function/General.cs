using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Function
{
    public static class General
    {
        public static string TrimStartEnd(this string source) => source.TrimStart().TrimEnd();

        public static string GetName(this string source)
        {
            if (string.IsNullOrEmpty(source)) return source;
            var str = source.TrimStartEnd().Split(' ');
            int count = str.Count();
            var adı = str.Take(count - 1 > 0 ? count - 1 : count);

            return string.Join(" ", adı.ToArray());
        }
        public static string GetSurname(this string source) => source.TrimStartEnd().Split(' ').LastOrDefault();

        public static bool isLenght(this object obj, int lentght)
        {
            return obj.ToString().Length == lentght;
        }
        public static bool isAbleTel(this string tel)
        {
            string[] constr =
                {
                "530", "531", "532", "533", "534", "535", "536", "537", "538", "539", "561",    //turkçel
                "540", "541", "542", "543", "544", "545", "546", "547", "548", "549",           //vodofone
                "501", "505", "506", "507", "551", "552", "553", "554", "555", "559"            //TURK Telekom
                };
            return tel != null && tel.Length == 10 && constr.Contains(tel.Substring(0, 3));
        }
    }

}
