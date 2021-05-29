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
using Zenix.Common.Enums;

namespace Zenix.BLL.General
{
    public class ReçeteMalzemelerBll : BaseHaraketBLL<ReçeteMalzemeler, ZenixContext>, IBaseHaraketSelectBLL<ReçeteMalzemeler>
    {
        public IEnumerable<BaseEntityHaraket> List(Expression<Func<ReçeteMalzemeler, bool>> filter)
        {
            var list = List(filter, x => new ReçeteMalzemeleriL
            {
                Id = x.Id,
                ReçeteId = x.ReçeteId,
                Miktar = x.Miktar,
                AşamaTipi = x.AşamaTipi,
                ReçeteBirimi = x.ReçeteBirimi,
                FazTipi = x.FazTipi,
                MamülId = x.MamülId,
                MamülAdı = x.Mamül.MamülAdı,
                Hacim = x.Mamül.Hacim,
                MalzemeTipi = x.Mamül.MalzemeTipi,
                MalzemeİçiÜrün = x.MalzemeİçiÜrün,
                MalzemeBirimi = x.Mamül.MalzemeBirimi,
                Stok = x.Mamül.Depo.Select(a => a.DepoMiktar).DefaultIfEmpty(0).Sum()
                //MalzemeId = x.MalzemeId,
                //FazTipi = x.FazTipi,
                //MalzemeAdı = x.Malzeme.Adı,
                //Birim = x.Malzeme.MalzemeBirimi,
            })
           //.AsEnumerable()// veriler çekilsin
           //.OrderBy(x => x.KartTuru.ToName())
           .ToList();
            var hacim = list.FirstOrDefault(x => x.Hacim > 0);
            var kimyasaloran = list
                .Where(x => x.MalzemeTipi == MalzemeTipi.Esans | x.MalzemeTipi == MalzemeTipi.HamMadde)
                .Select(x => x.Miktar).DefaultIfEmpty(0).Sum();
            if (hacim != null)
                list.ForEach(x =>
                {
                    x.Hacim = hacim.Hacim;
                    x.HacimliMalzemeAdı = hacim.MamülAdı;
                    x.HacimliMalzemeBirimi = hacim.MalzemeBirimi;
                    x.KimyasalOran = kimyasaloran;

                });
            return list;
        }

        public List<ReçeteMalzemeleriL> ReçeteList(Expression<Func<ReçeteMalzemeler, bool>> filter)
            => List(filter).Cast<ReçeteMalzemeleriL>().ToList();
        public List<ReçeteMalzemeleriL> ReçeteList(Expression<Func<ReçeteMalzemeler, bool>> filter, float şarjmiktarı)
        {
            var list = ReçeteList(filter);
            list.ForEach(x => x.ŞarjMiktarı = şarjmiktarı);
            return list;
        }
    }
}
