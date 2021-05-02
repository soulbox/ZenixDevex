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
    public class İşemriBll : BaseGenelBLL<İşemri>, IBaseCommonBLL
    {
        public İşemriBll() : base(KartTuru.İşemri) { }

        public İşemriBll(Control ctrl) : base(ctrl, KartTuru.İşemri) { }
        public override BaseEntity Single(Expression<Func<İşemri, bool>> filter)
        {
            return BaseSingle(filter, x => new İşemriS
            {
                Id = x.Id,
                Kod = x.Kod,
                Durum = x.Durum,
                KullanıcıId = x.KullanıcıId,
                KazanNo = x.Kazan.No,
                KazanId = x.KazanId,
                Tarih=x.Tarih,
                ŞarjId=x.ŞarjId,
                ŞarzMiktarı=x.ŞarzMiktarı,
                ReçeteId = x.ReçeteId,
                ÜrünId = x.Reçete.Revizyon.ÜrünId,
                ÜrünAdı = x.Reçete.Revizyon.Ürün.Adı,
                FirmaAdı = x.Reçete.Revizyon.Ürün.Firma.FirmaAdi,
                FirmaId = x.Reçete.Revizyon.Ürün.FirmaId,
                RevizyonId = x.Reçete.RevizyonId,
                RevizyonKod = x.Reçete.Revizyon.Kod,
                RevizyonTarihi = x.Reçete.Revizyon.RevizyonTarihi,
                
            });
        }

    }
}
