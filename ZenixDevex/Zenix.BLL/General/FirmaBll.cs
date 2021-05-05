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
    public class FirmaBll : BaseGenelBLL<Firma>, IBaseGenelBll, IBaseCommonBLL
    {
        public FirmaBll() : base(KartTuru.Firma) { }

        public FirmaBll(Control ctrl) : base(ctrl, KartTuru.Firma) { }

        public override BaseEntity Single(Expression<Func<Firma, bool>> filter)
        {
            return BaseSingle(filter, x => new FirmalarL
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                FirmaAdi = x.FirmaAdi,
                Adres = x.Adres,
                Tarih = x.Tarih,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                FirmaTipi = x.FirmaTipi,
                ÜlkeAdı = x.Ülke.Adı,
                ÜlkeId = x.ÜlkeId,
                FirmaTipiAdı=x.FirmaTipi.Adı,

            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Firma, bool>> filter)
        {
            return BaseList(filter, x => new FirmalarL
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                FirmaAdi = x.FirmaAdi,
                Adres = x.Adres,
                Tarih = x.Tarih,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                FirmaTipi = x.FirmaTipi,
                ÜlkeAdı  = x.Ülke.Adı,
                ÜlkeId = x.ÜlkeId,
                FirmaTipiAdı = x.FirmaTipi.Adı,


            }).OrderBy(x => x.Kod).ToList();
        }

    }
}
