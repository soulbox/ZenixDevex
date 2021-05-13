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
    public class DepoBll : BaseGenelBLL<Depo>, IBaseGenelBll, IBaseCommonBLL
    {
        public DepoBll() : base(KartTuru.Depo) { }

        public DepoBll(Control ctrl) : base(ctrl, KartTuru.Depo) { }


        public override IEnumerable<BaseEntity> List(Expression<Func<Depo, bool>> filter)
        {
            return base.List(filter);
        }

        public List<MalzemeDepoL> MalzemeDepoList(Expression<Func<Depo, bool>> filter)
        {
            return BaseList(filter, x => new MalzemeDepoL
            {
                Id = x.Id,
                Kod = x.Kod,
                DepoMiktar = x.DepoMiktar,
                KayıtTarihi = x.KayıtTarihi,
                MamülAdı = x.Mamül.MamülAdı,
                SatınAlma = x.Satınalma == null ? "" : x.Satınalma.Kod,
                SatınalmaId=x.SatınalmaId,
                MamülId=x.MamülId,
                

            }).ToList();

        }

    }
}
