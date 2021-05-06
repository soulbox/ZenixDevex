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
    public class RevizyonBll : BaseGenelBLL<Revizyon>, IBaseCommonBLL
    {
        public RevizyonBll() : base(KartTuru.Revizyon) { }

        public RevizyonBll(Control ctrl) : base(ctrl, KartTuru.Revizyon) { }

        public override BaseEntity Single(Expression<Func<Revizyon, bool>> filter)
        {
            return BaseSingle(filter, x => new RevizyonS
            {
                Id = x.Id,
                Kod = x.Kod,
                Durum = x.Durum,
                Açıklama = x.Açıklama,
                FirmaAdi = x.Ürün.Firma.FirmaAdi,
                MamülAdı = x.Ürün.Mamül.MamülAdı,
                MarkaAdı = x.Ürün.Marka.MarkaAdı,
                GTIN = x.Ürün.GTIN,
                RevizyonTarihi = x.RevizyonTarihi,
                ÜrünId = x.ÜrünId,
            });

        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Revizyon, bool>> filter)
        {
            return BaseList(filter, x => new RevizyonS
            {
                Id = x.Id,
                Kod = x.Kod,
                Durum = x.Durum,
                Açıklama = x.Açıklama,
                FirmaAdi = x.Ürün.Firma.FirmaAdi,
                MamülAdı = x.Ürün.Mamül.MamülAdı,
                MarkaAdı = x.Ürün.Marka.MarkaAdı,
                GTIN = x.Ürün.GTIN,
                RevizyonTarihi = x.RevizyonTarihi,
                ÜrünId = x.ÜrünId,
                
            });
        }
        public RevizyonS GetMaxRevizyon(long ürünid) => (RevizyonS)List(x=>x.Durum==true && x.ÜrünId==ürünid)
            .OrderByDescending(x => x.Kod).FirstOrDefault();

    }
}
