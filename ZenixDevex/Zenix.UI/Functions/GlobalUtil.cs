using Zenix.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.DTO;

namespace Zenix.WinUI.Functions
{
    public static class GlobalUtil
    {
        public static bool HasValue(this IBaseEntity sourc) => sourc != null;
        public static bool isNull(this IBaseEntity sourc) => sourc == null;

        //public static (bool hasval, T value) HasValue<T>(this T sourc) => sourc == null ? (false, sourc ) : (true, sourc);
        internal static Dictionary<MalzemeTipi, int> enumOrder = new Dictionary<MalzemeTipi, int>()
            {
                { MalzemeTipi.Esans , 1 },
                { MalzemeTipi.HamMadde , 2 },
                { MalzemeTipi.Ambalaj , 3 },
                { MalzemeTipi.Etiket , 4 },
                { MalzemeTipi.Kapak , 5 },
                { MalzemeTipi.Sarf , 6 },
                { MalzemeTipi.Şişe , 7 },
                { MalzemeTipi.Koli , 8 },
                { MalzemeTipi.Kutu , 9 },
                { MalzemeTipi.Kavanoz , 10 },
              { MalzemeTipi.Diğer , 11 }
            };

        public static List<ReçeteMalzemeleriL> Order(this IEnumerable<ReçeteMalzemeleriL> source)
        {
            return source.OrderBy(x => enumOrder[x.MalzemeTipi]).ThenBy(x => enumOrder[x.MalzemeTipi]).ToList();
        }

    }

}
