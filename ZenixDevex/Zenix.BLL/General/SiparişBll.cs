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
                Durum = x.Durum,
                Kod = x.Kod,
                AdSoyad = x.Kullanıcı.Adı + " " + x.Kullanıcı.Soyadı,
                Açıklama = x.Açıklama,
                FirmaAdi = x.Firma.FirmaAdi,
                FirmaId = x.FirmaId,
                KullanıcıId = x.KullanıcıId,
                Tarih = x.Tarih,

            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Sipariş, bool>> filter)
        {
            return BaseList(filter, x => new SiparişL
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                AdSoyad = x.Kullanıcı.Adı + " " + x.Kullanıcı.Soyadı,
                Açıklama = x.Açıklama,
                FirmaAdi = x.Firma.FirmaAdi,
                Tarih = x.Tarih,
                ÜrünMiktarı = x.SiparişÜrünleri.Count,
            }).ToList();
        }

    }
}
