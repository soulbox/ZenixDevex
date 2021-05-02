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
    public class SiparişBll : BaseGenelBLL<Sipariş>, IBaseGenelBll, IBaseCommonBLL
    {
        public SiparişBll() : base(KartTuru.Sipariş) { }

        public SiparişBll(Control ctrl) : base(ctrl, KartTuru.Sipariş) { }
        public override BaseEntity Single(Expression<Func<Sipariş, bool>> filter)
        {
            return BaseSingle(filter, x => new SiparişS
            {
                Id = x.Id,
                Kod = x.Kod,
                Durum = x.Durum,
                Miktar = x.Miktar,
                Tarih = x.Tarih,
                Açıklama = x.Açıklama,
                FirmaAdı = x.Ürün.Firma.FirmaAdi,
                FirmaId = x.Ürün.FirmaId,
                ÜrünAdı = x.Ürün.Adı,
                ÜrünId = x.ÜrünId,
                BirimTipi = x.BirimTipi,
                AdSoyad = x.Kullanıcı.Adı + x.Kullanıcı.Soyadı,
                KullanıcıId = x.KullanıcıId,

            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Sipariş, bool>> filter)
        {
            return BaseList(filter, x => new SiparişL
            {
                Id = x.Id,
                Kod = x.Kod,
                Durum = x.Durum,
                Miktar = x.Miktar,
                Tarih = x.Tarih,
                Açıklama = x.Açıklama,
                FirmaAdı = x.Ürün.Firma.FirmaAdi,
                ÜrünAdı = x.Ürün.Adı,
                BirimTipi = x.BirimTipi,
                AdSoyad = x.Kullanıcı.Adı + x.Kullanıcı.Soyadı,
            }).ToList();
        }

    }
}
