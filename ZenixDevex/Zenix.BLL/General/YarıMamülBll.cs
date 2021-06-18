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
    public class YarıMamülBll : BaseHaraketBLL<YarıMamül, ZenixContext>, IBaseHaraketSelectBLL<YarıMamül>
    {
        public IEnumerable<BaseEntityHaraket> List(Expression<Func<YarıMamül, bool>> filter)
        {
            return List(filter, x => new YarıMamülL
            {
                Id = x.Id,
                YarıMamülAdı = x.YarıMamülGrup.YarıMamülAdı,
                ÜrünId = x.ÜrünId,
                YarıMamülGrupId = x.YarıMamülGrupId,
                FirmaAdi = x.Ürün.Firma.FirmaAdi,
                MamülAdı = x.Ürün.Mamül.MamülAdı,
                MarkaAdı = x.Ürün.Marka.MarkaAdı,
                GTIN = x.Ürün.GTIN,
            }).ToList();
        }
        public IEnumerable<BaseEntityHaraket> LookUpGridList(Expression<Func<YarıMamül, bool>> filter)
        {
            List<YarıMamülL> list = new List<YarıMamülL> { new YarıMamülL {YarıMamülAdı="Yok" } };           
            list.AddRange(List(filter, x => new YarıMamülL
            {
                Id = x.Id,
                YarıMamülAdı = x.YarıMamülGrup.YarıMamülAdı,
            }).ToList());
            return list;
        }



        public List<YarıMamülL> ListÜrünGrup(Expression<Func<YarıMamül, bool>> filter)
        {
            return List(filter, x => new YarıMamülL
            {
                Id = x.Id,
                ÜrünId = x.ÜrünId,
                YarıMamülGrupId = x.YarıMamülGrupId,
                YarıMamülAdı = x.YarıMamülGrup.YarıMamülAdı,
                FirmaAdi = x.Ürün.Firma.FirmaAdi,
                MamülAdı = x.Ürün.Mamül.MamülAdı,
                MarkaAdı = x.Ürün.Marka.MarkaAdı,
                GTIN = x.Ürün.GTIN,
            })
            .GroupBy(x => x.ÜrünId)
            .Select(x => x.FirstOrDefault())
            .ToList();
        }
    }
}
