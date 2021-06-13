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
    public class ÜretimBll : BaseGenelBLL<Üretim>, IBaseGenelBll, IBaseCommonBLL
    {
        public ÜretimBll() : base(KartTuru.Üretim) { }

        public ÜretimBll(Control ctrl) : base(ctrl, KartTuru.Üretim) { }

        public override BaseEntity Single(Expression<Func<Üretim, bool>> filter)
        {
            return base.Single(filter);
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Üretim, bool>> filter)
        {
            return BaseList(filter, x => new ÜretimL
            {
                Id = x.Id,
                AşamaTipi = x.AşamaTipi,
                BaseRevKod = x.İşemri.Reçete.Revizyon.Kod,
                ReçeteId = x.İşemri.ReçeteId,
                İşemriId = x.İşemriId,
                ÜrünId = x.İşemri.Reçete.ÜrünId,
                Miktar = x.Miktar,
                MamülAdı = x.Mamül.MamülAdı,
                ÜrünAdı = x.İşemri.Reçete.Ürün.Mamül.MamülAdı,
                işemriTarih = x.İşemri.işemriTarih,
                ŞarjMiktarı = x.İşemri.ŞarjMiktarı,
                ŞarjNo = x.İşemri.ŞarjNo,
                MarkaAdı = x.İşemri.Reçete.Ürün.Marka.MarkaAdı,
                FirmaAdi = x.İşemri.Reçete.Ürün.Firma.FirmaAdi,
                RevizyonTarihi = x.İşemri.Reçete.Revizyon.RevizyonTarihi,
                GTIN = x.İşemri.Reçete.Ürün.GTIN,
                KullaniciId = x.İşemri.KullaniciId,
                MamülId = x.MamülId,

            }).ToList();
        }
        public List<ÜretimL> ÜretimList(Expression<Func<Üretim, bool>> filter)
            => List(filter).Cast<ÜretimL>().ToList();

    }
}
