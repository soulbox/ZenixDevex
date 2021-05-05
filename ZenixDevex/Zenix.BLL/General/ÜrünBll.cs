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
    public class ÜrünBll : BaseGenelBLL<Ürün>, IBaseGenelBll, IBaseCommonBLL
    {
        public ÜrünBll() : base(KartTuru.Ürün) { }

        public ÜrünBll(Control ctrl) : base(ctrl, KartTuru.Ürün) { }
        public override BaseEntity Single(Expression<Func<Ürün, bool>> filter)
        {
            return BaseSingle(filter, x =>
            new ÜrünS
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                FirmaAdi = x.Firma.FirmaAdi,
                FirmaId = x.FirmaId,
                GTIN = x.GTIN,
                Kutu = x.Kutu,
                Stand = x.Stand,
                Koli = x.Koli,
                MamülAdı = x.Mamül.MamülAdı,
                MamülId = x.MamülId,
                MarkaAdı = x.Marka.MarkaAdı,
                MarkaId = x.MarkaId,


            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Ürün, bool>> filter)
        {
            return BaseList(filter, x => new ÜrünL
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                FirmaAdi = x.Firma.FirmaAdi,
                FirmaId = x.FirmaId,
                GTIN = x.GTIN,
                Kutu = x.Kutu,
                Stand = x.Stand,
                Koli = x.Koli,
                MamülAdı = x.Mamül.MamülAdı,
                MamülId = x.MamülId,
                MarkaAdı = x.Marka.MarkaAdı,
                MarkaId = x.MarkaId,
                Alan = x.Mamül.Alan,
                AlanınBirimi = x.Mamül.AlanınBirimi,
                AmbalajMaddeTipiId = x.Mamül.AmbalajMaddeTipiId,
                AmbalajTipiId = x.Mamül.AmbalajTipiId,
                Ağırlık = x.Mamül.Ağırlık,
                AğırlığınBirimi = x.Mamül.AğırlığınBirimi,
                AğızÖlçüsü = x.Mamül.AğızÖlçüsü,
                En = x.Mamül.En,
                Boy = x.Mamül.Boy,
                Hacim = x.Mamül.Hacim,
                MalzemeBirimi = x.Mamül.MalzemeBirimi,
                MalzemeTipi = x.Mamül.MalzemeTipi,
                SarfTipi = x.Mamül.SarfTipi,
                Uzunluk = x.Mamül.Uzunluk,
                Yükseklik = x.Mamül.Yükseklik,
                BirimAuEbY=x.Mamül.BirimAuEbY,
                AmbalajMaddeAdı=x.Mamül.AmbalajMaddeTipi.Adı,
                AmbalajTipiAdı=x.Mamül.AmbalajTipi.Adı,
                

            }).ToList();
        }
    }
}
