using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Zenix.BLL.Base;
using Zenix.BLL.Interfaces;
using Zenix.Common.Enums;
using Zenix.Data.Context;
using Zenix.Model.DTO;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;

namespace Zenix.BLL.General
{
    public class MalzemeBll : BaseGenelBLL<Malzeme>, IBaseGenelBll, IBaseCommonBLL
    {
        public MalzemeBll() : base(KartTuru.Malzeme) { }

        public MalzemeBll(Control ctrl) : base(ctrl, KartTuru.Malzeme) { }
        public override IEnumerable<BaseEntity> List(Expression<Func<Malzeme, bool>> filter)
        {
            return base.List(filter);
        }

        public List<ReçeteMalzemeleriS> MalzemeAdListesi(Expression<Func<Malzeme, bool>> filter)
        {
            return BaseList(filter, x => new ReçeteMalzemeleriS
            {
                Id = x.Id,
                Adı = x.Adı,


            }).OrderBy(x => x.Adı)
                .ToList();
        }
    }
}
