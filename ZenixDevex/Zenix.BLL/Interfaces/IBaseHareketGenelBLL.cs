using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.BLL.Interfaces
{
  public   interface IBaseHareketGenelBLL
    {
        Boolean Insert(IList<BaseEntityHaraket> entities);
        bool Update(IList<BaseEntityHaraket> entities);
        bool Delete(IList<BaseEntityHaraket> entities);
    }
}
