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
    public class MarkalarBll : BaseGenelBLL<Markalar>, IBaseCommonBLL
    {
        public MarkalarBll() : base(KartTuru.Markalar) { }

        public MarkalarBll(Control ctrl) : base(ctrl, KartTuru.Markalar) { }
        public override BaseEntity Single(Expression<Func<Markalar, bool>> filter)
        {
            return BaseSingle(filter, x => new MarkalarS
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                Adı = x.Adı,
                GTIN = x.GTIN,
                Açıklama = x.Açıklama,
                FirmaAdı = x.Firma.FirmaAdi,
                ÜrünAdı = x.Ürün.Adı,
                FirmaId = x.FirmaId,
                ÜrünId = x.ÜrünId,
                FirmaTipi=x.Firma.FirmaTipi,

            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Markalar, bool>> filter)
        {
            return BaseList(filter, x => new MarkalarS
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                Adı = x.Adı,
                GTIN = x.GTIN,
                Açıklama = x.Açıklama,
                FirmaAdı = x.Firma.FirmaAdi,
                ÜrünAdı = x.Ürün.Adı,
                FirmaId = x.FirmaId,
                ÜrünId = x.ÜrünId,
                FirmaTipi = x.Firma.FirmaTipi,

            }).ToList();
        }

    }
}
