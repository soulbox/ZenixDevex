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
    public class SatınAlmaMalzemelerBll : BaseHaraketBLL<SatınAlmaMalzemeler, ZenixContext>, IBaseHaraketSelectBLL<SatınAlmaMalzemeler>
    {
        public IEnumerable<BaseEntityHaraket> List(Expression<Func<SatınAlmaMalzemeler, bool>> filter)
        {
            return List(filter, x => new SatınAlmaMalzemeleriL
            {
                Id = x.Id,
                MamülId = x.MamülId,
                MamülAdı = x.Mamül.MamülAdı,
                MalzemeBirimi = x.Mamül.MalzemeBirimi,
                SatınalmaId = x.SatınalmaId,

                Miktar = x.Miktar,
                TerminTarihi = x.TerminTarihi,
                Teslimat = x.Teslimat,


            })
            .ToList();
        }
        public List<SatınAlmaMalzemeleriDepo> Deposatınalma(Expression<Func<SatınAlmaMalzemeler, bool>> filter)
        {
            return List(filter, x => new SatınAlmaMalzemeleriDepo
            {
                Id = x.Id,
                MamülId = x.MamülId,
                MamülAdı = x.Mamül.MamülAdı,
                SatınalmaId = x.SatınalmaId,
                FirmaAdi = x.Satınalma.Firma.FirmaAdi,
                SatınAlmaKod = x.Satınalma.Kod,
                Miktar = x.Miktar,
                TerminTarihi = x.TerminTarihi,
                Teslimat = x.Teslimat,
                

            })
                .ToList();
        }
    }
}
