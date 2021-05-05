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
    public class ReçeteMalzemelerBll : BaseHaraketBLL<ReçeteMalzemeler, ZenixContext>, IBaseHaraketSelectBLL<ReçeteMalzemeler>
    {
        public IEnumerable<BaseEntityHaraket> List(Expression<Func<ReçeteMalzemeler, bool>> filter)
        {
            return List(filter, x => new ReçeteMalzemeleriL
            {
                Id = x.Id,
                ReçeteId = x.ReçeteId,
                Miktar = x.Miktar,
                //MalzemeId = x.MalzemeId,
                //FazTipi = x.FazTipi,
                //MalzemeAdı = x.Malzeme.Adı,
                //Birim = x.Malzeme.MalzemeBirimi,
            })
           //.AsEnumerable()// veriler çekilsin
           //.OrderBy(x => x.KartTuru.ToName())
           .ToList();
        }

    }
}
