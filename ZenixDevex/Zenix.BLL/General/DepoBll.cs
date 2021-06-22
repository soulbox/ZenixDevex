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
    }
}
