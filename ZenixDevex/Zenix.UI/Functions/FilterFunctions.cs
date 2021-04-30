using DevExpress.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Entities.Base;

namespace Zenix.WinUI.Functions
{
    public class FilterFunctions
    {
        public static Expression<Func<T, bool>> Filter<T>(bool aktifkayıtlarıgöster)
            where T : BaseEntityDurum => x => x.Durum == aktifkayıtlarıgöster;
        public static Expression<Func<T, bool>> Filter<T>(long Id)
            where T : BaseEntity  => x => x.Id == Id;
    }
}
