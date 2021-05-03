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
    public class ReçeteBll : BaseGenelBLL<Reçete>, IBaseCommonBLL
    {
        public ReçeteBll() : base(KartTuru.Reçete) { }

        public ReçeteBll(Control ctrl) : base(ctrl, KartTuru.Reçete) { }
        public override BaseEntity Single(Expression<Func<Reçete, bool>> filter)
        {
            return BaseSingle(filter, x => new ReçeteS
            {
                Id = x.Id,
                Kod = x.Kod,
                AFazıHazırlanış = x.AFazıHazırlanış,
                BFazıHazırlanış = x.BFazıHazırlanış,
                CFazıHazırlanış = x.CFazıHazırlanış,
                RevizyonId = x.RevizyonId,
                ÜrünAdı = x.Revizyon.Markalar.Ürün.Adı,
                RevizyonKod = x.Revizyon.Kod,
                RevizyonTarihi = x.Revizyon.RevizyonTarihi,
                ÜrünId = x.Revizyon.Markalar.ÜrünId ,
                FirmaAdı = x.Revizyon.Markalar.Firma.FirmaAdi,
                FirmaId = x.Revizyon.Markalar.FirmaId,

            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Reçete, bool>> filter)
        {
            return BaseList(filter, x => new ReçeteL
            {
                Id = x.Id,
                Kod = x.Kod,
                AFazıHazırlanış = x.AFazıHazırlanış,
                BFazıHazırlanış = x.BFazıHazırlanış,
                CFazıHazırlanış = x.CFazıHazırlanış,
                FirmaAdı = x.Revizyon.Markalar.Firma.FirmaAdi,
                ÜrünAdı = x.Revizyon.Markalar.Adı,
                RevizyonKod = x.Revizyon.Kod,
                RevizyonTarihi = x.Revizyon.RevizyonTarihi,
                MalzemeMiktarı = x.ReçeteMalzemeler.Count

            }).ToList();
        }

    }
}
