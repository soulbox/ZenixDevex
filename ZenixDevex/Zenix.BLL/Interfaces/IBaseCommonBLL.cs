using Zenix.Model.Entities.Base;

namespace Zenix.BLL.Interfaces
{
    public   interface IBaseCommonBLL
    {
        bool Delete(BaseEntity entity, bool mesajver = true);
    }
}
