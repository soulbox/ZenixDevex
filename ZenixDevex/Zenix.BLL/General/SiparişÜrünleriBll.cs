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
    public class SiparişÜrünleriBll : BaseHaraketBLL<SiparişÜrünleri, ZenixContext>, IBaseHaraketSelectBLL<SiparişÜrünleri>
    {
        public IEnumerable<BaseEntityHaraket> List(Expression<Func<SiparişÜrünleri, bool>> filter)
        {
            return List(filter, x => new SiparişÜrünleriL
            {
                Id = x.Id,
                SiparişId = x.SiparişId,
                ÜrünId = x.Id,
                MamülAdı = x.Ürün.Mamül.MamülAdı,
                FirmaAdi = x.Ürün.Firma.FirmaAdi,
                MarkaAdı = x.Ürün.Marka.MarkaAdı,
                GTIN = x.Ürün.GTIN,
                Kutu = x.Ürün.Kutu,
                Koli = x.Ürün.Koli,
                Stand = x.Ürün.Stand,
                BirimTipi = x.BirimTipi,
                Miktar = x.Miktar,
            }).ToList();
        }
    }
}
