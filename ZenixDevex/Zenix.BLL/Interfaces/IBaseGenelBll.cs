using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Entities.Base;

namespace Zenix.BLL.Interfaces
{
    public interface IBaseGenelBll
    {
        bool Insert(BaseEntity entity);
        //bool Insert(List<BaseEntity> entity);

        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);
        string YeniKodVer();
    }
}
