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

        IQueryable<MalzemeDepoL> GetQuery(Expression<Func<Depo, bool>> filter)
            => BaseList(filter, x => new MalzemeDepoL
            {
                Id = x.Id,
                Kod = x.Kod,
                DepoMiktar = x.DepoMiktar,
                KayıtTarihi = x.KayıtTarihi,
                MamülAdı = x.Mamül.MamülAdı,
                SatınalmaId = x.SatınalmaId == null ? default : x.SatınalmaId,
                SatınAlma = x.SatınalmaId == null ? default : x.Satınalma.Kod,
                İşemriId = x.İşemriId == null ? default : x.İşemriId,
                işemriTarih = x.İşemriId == null ? default : x.İşemri.işemriTarih,
                ŞarjNo = x.İşemriId == null ? default : x.İşemri.ŞarjNo,
                MarkaAdı = x.İşemriId == null ? default : x.İşemri.Reçete.Ürün.Marka.MarkaAdı,
                GTIN = x.İşemriId == null ? default : x.İşemri.Reçete.Ürün.GTIN,
                FirmaAdi = x.İşemriId == null ? default : x.İşemri.Reçete.Ürün.Firma.FirmaAdi,
                RevizyonTarihi = x.İşemriId == null ? default : x.İşemri.Reçete.Revizyon.RevizyonTarihi,
                BaseRevKod = x.İşemriId == null ? default : x.İşemri.Reçete.Revizyon.Kod,
                SiparişFirmaAdi = x.ÜrünId == null ? default : x.Ürün.Firma.FirmaAdi,
                SiparişMarkaAdı = x.ÜrünId == null ? default : x.Ürün.Marka.MarkaAdı,
                ÜrünId = x.ÜrünId,
                MamülId = x.MamülId,
                DepoTipi = x.DepoTipi,
                SiparişId = x.SiparişId,
                SiparişNo = x.Sipariş.Kod,
                YarıMamülId = x.YarıMamülId,
                YarıMamülAdı = x.YarıMamülId == null ? default : x.YarıMamül.YarıMamülGrup.YarıMamülAdı,


            });
        public List<MalzemeDepoL> MalzemeDepoList(Expression<Func<Depo, bool>> filter)
        {
            var list = GetQuery(filter).ToList();
            list.ForEach(x =>
            {
                x.KayıtDurum = x.SatınalmaId != null ? x.SatınAlma : x.İşemriId != null ? $"İşemriNo:{x.işemriNo}" : x.SiparişId != null ? $"Sipariş No:{x.SiparişNo}" : "";
            });
            return list;

        }
        public List<MalzemeDepoL> YarıMamülDepoList(Expression<Func<Depo, bool>> filter)
        {
            var list = GetQuery(filter).GroupBy(x => x.Kod).Select(X => X.FirstOrDefault()).ToList();
            list.ForEach(x =>
            {
                x.KayıtDurum = x.SatınalmaId != null ? x.SatınAlma : x.İşemriId != null ? $"İşemriNo:{x.işemriNo }" : x.SiparişId != null ? $"Sipariş No:{x.SiparişNo}" : "";
            });


            return list;

        }
        public float StokVer(long mamülid) => BaseList(x => x.MamülId == mamülid && x.YarıMamülId == null, x => x.DepoMiktar).DefaultIfEmpty(0).Sum();

        public float StokVer(long mamülid, int yarımamülid)
            => BaseList(x => x.MamülId == mamülid && x.YarıMamülId == yarımamülid, x => new { x.Kod, x.DepoMiktar })
            .GroupBy(x => x.Kod)
            .Select(x => x.FirstOrDefault())
            .ToList()
            .Select(x => x.DepoMiktar)
            .DefaultIfEmpty(0).Sum();

        public float StokVer(long işemriid, long mamülid, int yarımamülid)
    => BaseList(x => x.İşemriId == işemriid & x.MamülId == mamülid & x.YarıMamülId == yarımamülid, x => new { x.Kod, x.DepoMiktar })
    .GroupBy(x => x.Kod)
    .Select(x => x.FirstOrDefault())
    .ToList()
    .Select(x => x.DepoMiktar)
    .DefaultIfEmpty(0).Sum();


        public List<Tuple<long, float>> StokVer(List<long> mamülid, long işemriId)
            => BaseList(x => x.YarıMamülId == null && x.İşemriId == işemriId && mamülid.Contains(x.MamülId),
                x => new { x.MamülId, x.DepoMiktar, x.YarıMamülId })
            .GroupBy(x => new { x.MamülId, x.YarıMamülId })
            .Select(x => new { x.FirstOrDefault().MamülId, DepoMiktar = x.Where(a => a.MamülId == x.Key.MamülId && a.YarıMamülId == x.Key.YarıMamülId).Sum(a => a.DepoMiktar) })
            .ToList()
            .Select(x => Tuple.Create(x.MamülId, x.DepoMiktar))
            .ToList();

    }
}
