using Zenix.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.WinUI.Functions
{
    public static class GlobalUtil 
    {    
        public static bool HasValue(this IBaseEntity sourc) =>  sourc != null;
        public static bool isNUll(this IBaseEntity sourc) => sourc == null;

        //public static (bool hasval, T value) HasValue<T>(this T sourc) => sourc == null ? (false, sourc ) : (true, sourc);

    }
}
