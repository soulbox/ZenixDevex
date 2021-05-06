using Zenix.BLL.Base;
using Zenix.BLL.Interfaces;
using Zenix.Common.Enums;
using Zenix.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenix.Model.Entities.Base;
using Zenix.Model.DTO;

namespace Zenix.BLL.General
{
    public class ReçeteBll : BaseGenelBLL<Reçete>, IBaseGenelBll, IBaseCommonBLL
    {
        public ReçeteBll() : base(KartTuru.Reçete) { }

        public ReçeteBll(Control ctrl) : base(ctrl, KartTuru.Reçete) { }

        public override BaseEntity Single(Expression<Func<Reçete, bool>> filter)
        {
            return BaseSingle(filter, x => new ReçeteS
            {
                Id = x.Id,
                Kod = x.Kod,
                Durum = x.Durum,
                AFazıHazırlanış = x.AFazıHazırlanış,
                BFazıHazırlanış = x.BFazıHazırlanış,
                CFazıHazırlanış = x.CFazıHazırlanış,
                DFazıHazırlanış = x.DFazıHazırlanış,
                GTIN = x.Ürün.GTIN,
                FirmaAdi = x.Ürün.Firma.FirmaAdi,
                MamülAdı = x.Ürün.Mamül.MamülAdı,
                MarkaAdı = x.Ürün.Marka.MarkaAdı,
                RevizyonId = x.RevizyonId,
                RevizyonTarihi = x.Revizyon.RevizyonTarihi,
                ÜrünId = x.ÜrünId,
                Açıklama = x.Açıklama,
                

            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Reçete, bool>> filter)
        {
            return BaseList(filter, x => new ReçeteL
            {
                Id = x.Id,
                Kod = x.Kod,
                Durum = x.Durum,
                AFazıHazırlanış = x.AFazıHazırlanış,
                BFazıHazırlanış = x.BFazıHazırlanış,
                CFazıHazırlanış = x.CFazıHazırlanış,
                DFazıHazırlanış = x.DFazıHazırlanış,
                GTIN = x.Ürün.GTIN,
                FirmaAdi = x.Ürün.Firma.FirmaAdi,
                MamülAdı = x.Ürün.Mamül.MamülAdı,
                MarkaAdı = x.Ürün.Marka.MarkaAdı,
                RevizyonId = x.RevizyonId,
                RevizyonTarihi = x.Revizyon.RevizyonTarihi,
                ÜrünId = x.ÜrünId,
                RevizyonDurum = x.Revizyon.Durum,
                MalzemeMiktarı = x.ReçeteMalzemeler.Count,
                Açıklama = x.Açıklama,
            }).ToList();
        }

    }
}
