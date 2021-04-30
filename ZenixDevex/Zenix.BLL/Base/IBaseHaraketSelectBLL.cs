using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.BLL.Base
{
    public interface IBaseHaraketSelectBLL<TEntity>
    {
        IEnumerable<BaseEntityHaraket> List(Expression<Func<TEntity, bool>> filter);

    }
}
