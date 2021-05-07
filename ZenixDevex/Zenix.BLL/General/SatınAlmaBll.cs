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
    public class SatınAlmaBll : BaseGenelBLL<Satınalma>, IBaseGenelBll, IBaseCommonBLL
    {
        public SatınAlmaBll() : base(KartTuru.SatınAlma) { }

        public SatınAlmaBll(Control ctrl) : base(ctrl, KartTuru.SatınAlma) { }


        public override BaseEntity Single(Expression<Func<Satınalma, bool>> filter)
        {
            return BaseSingle (filter, x => new SatınalmaS 
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                FirmaAdi = x.Firma.FirmaAdi,
                Tarihi = x.Tarihi,
                FirmaId=x.FirmaId,
                KullanıcıId=x.KullanıcıId,

            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Satınalma, bool>> filter)
        {
            return BaseList(filter, x => new SatınalmaL
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                AdSoyad = x.Kullanıcı.Adı + " " + x.Kullanıcı.Soyadı,
                FirmaAdi = x.Firma.FirmaAdi,
                FirmaTipi = x.Firma.FirmaTipi.Adı,
                Tarihi = x.Tarihi,
                SatınAlmaMiktarı = x.SatınAlmaMalzemeler.Count,
                Ülke=x.Firma.Ülke.Adı,
                FirmaId = x.FirmaId,
                KullanıcıId = x.KullanıcıId,
            }).ToList();
        }
    }
}
