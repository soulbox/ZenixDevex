using Zenix.BLL.Base;
using Zenix.Common.Function;
using Zenix.Data.Context;
using Zenix.Model.DTO;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.BLL.General
{
    public class RolYetkileriBll : BaseHaraketBLL<RolYetkileri, ZenixContext>, IBaseHaraketSelectBLL<RolYetkileri>
    {
        public IEnumerable<BaseEntityHaraket> List(Expression<Func<RolYetkileri, bool>> filter)
        {
            return List(filter, x => new RolYetkileriL
            {
                Id = x.Id,
                RolId = x.RolId,
                Değiştirebilir = x.Değiştirebilir,
                Görebilir = x.Görebilir,
                Ekleyebilir = x.Ekleyebilir,
                Silebilir = x.Silebilir,
                KartTuru = x.KartTuru,

            }).AsEnumerable()// veriler çekilsin
            .OrderBy(x=>x.KartTuru.ToName()).ToList();
        }
    }
}
