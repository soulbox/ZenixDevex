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
    public class İşemriBll : BaseGenelBLL<İşemri>, IBaseGenelBll, IBaseCommonBLL
    {
        public İşemriBll() : base(KartTuru.İşemri) { }

        public İşemriBll(Control ctrl) : base(ctrl, KartTuru.İşemri) { }

        public override BaseEntity Single(Expression<Func<İşemri, bool>> filter)
        {
            return BaseSingle(filter, x => new İşemriS
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                AdSoyad = x.Kullanici.Adı + " " + x.Kullanici.Soyadı,
                FirmaAdi = x.Reçete.Ürün.Firma.FirmaAdi,
                MamülAdı = x.Reçete.Ürün.Mamül.MamülAdı,
                MarkaAdı = x.Reçete.Ürün.Marka.MarkaAdı,
                AFazıHazırlanış = x.Reçete.AFazıHazırlanış,
                BFazıHazırlanış = x.Reçete.BFazıHazırlanış,
                CFazıHazırlanış = x.Reçete.CFazıHazırlanış,
                DFazıHazırlanış = x.Reçete.DFazıHazırlanış,
                ŞarjMiktarı = x.ŞarjMiktarı,
                işemriTarih = x.işemriTarih,
                ÜrünId = x.Reçete.ÜrünId,
                RevizyonTarihi = x.Reçete.Revizyon.RevizyonTarihi,
                BaseRevKod = x.Reçete.Revizyon.Kod,
                ŞarjNo = x.ŞarjNo,
                Açıklama = x.Açıklama,
                RevizyonId = x.Reçete.RevizyonId,
                ReçeteId = x.ReçeteId,
                GTIN = x.Reçete.Ürün.GTIN,
                MalzemeBirimi = x.Reçete.Ürün.Mamül.MalzemeBirimi,
                Alan = x.Reçete.Ürün.Mamül.Alan,
                En = x.Reçete.Ürün.Mamül.En,
                Boy = x.Reçete.Ürün.Mamül.Boy,
                Hacim = x.Reçete.Ürün.Mamül.Hacim,
                AlanınBirimi = x.Reçete.Ürün.Mamül.AlanınBirimi,
                Ağırlık = x.Reçete.Ürün.Mamül.Ağırlık,
                Uzunluk= x.Reçete.Ürün.Mamül.Uzunluk,
                AğızÖlçüsü= x.Reçete.Ürün.Mamül.AğızÖlçüsü,
                AğırlığınBirimi= x.Reçete.Ürün.Mamül.AğırlığınBirimi,
                BirimAuEbY= x.Reçete.Ürün.Mamül.BirimAuEbY,
                
                
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<İşemri, bool>> filter)
        {
            return BaseList(filter, x => new İşemriL
            {
                Id = x.Id,
                Durum = x.Durum,
                Kod = x.Kod,
                AdSoyad = x.Kullanici.Adı + " " + x.Kullanici.Soyadı,
                FirmaAdi = x.Reçete.Ürün.Firma.FirmaAdi,
                MamülAdı = x.Reçete.Ürün.Mamül.MamülAdı,
                MarkaAdı = x.Reçete.Ürün.Marka.MarkaAdı,
                AFazıHazırlanış = x.Reçete.AFazıHazırlanış,
                BFazıHazırlanış = x.Reçete.BFazıHazırlanış,
                CFazıHazırlanış = x.Reçete.CFazıHazırlanış,
                DFazıHazırlanış = x.Reçete.DFazıHazırlanış,
                ŞarjMiktarı = x.ŞarjMiktarı,
                işemriTarih = x.işemriTarih,
                ÜrünId = x.Reçete.ÜrünId,
                RevizyonTarihi = x.Reçete.Revizyon.RevizyonTarihi,
                BaseRevKod = x.Reçete.Revizyon.Kod,
                ŞarjNo = x.ŞarjNo,
                Açıklama = x.Açıklama,
                RevizyonId = x.Reçete.RevizyonId,
                ReçeteId = x.ReçeteId,
                GTIN = x.Reçete.Ürün.GTIN,
                MalzemeBirimi = x.Reçete.Ürün.Mamül.MalzemeBirimi,
                Alan = x.Reçete.Ürün.Mamül.Alan,
                En = x.Reçete.Ürün.Mamül.En,
                Boy = x.Reçete.Ürün.Mamül.Boy,
                Hacim = x.Reçete.Ürün.Mamül.Hacim,
                AlanınBirimi = x.Reçete.Ürün.Mamül.AlanınBirimi,
                Ağırlık = x.Reçete.Ürün.Mamül.Ağırlık,
                Uzunluk = x.Reçete.Ürün.Mamül.Uzunluk,
                AğızÖlçüsü = x.Reçete.Ürün.Mamül.AğızÖlçüsü,
                AğırlığınBirimi = x.Reçete.Ürün.Mamül.AğırlığınBirimi,
                BirimAuEbY = x.Reçete.Ürün.Mamül.BirimAuEbY,                

            }).ToList();
        }

        public int ŞarjNo(long reçeteid) => BaseList(x => x.ReçeteId == reçeteid, x => x.Id).DefaultIfEmpty(1).Count();
    }
}
