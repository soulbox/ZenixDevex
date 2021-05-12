using Zenix.BLL.Base;
using Zenix.Common.Function;
using Zenix.Data.Context;
using Zenix.Model.DTO;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Zenix.BLL.General
{
    public class ÜretimBll : BaseHaraketBLL<Üretim, ZenixContext>, IBaseHaraketSelectBLL<Üretim>
    {
        public IEnumerable<BaseEntityHaraket> List(Expression<Func<Üretim, bool>> filter)
        {
            return List(filter, x => new ÜretimL
            {
                Id             = x.Id,
                AşamaTipi      = x.AşamaTipi,
                BaseRevKod     = x.İşemri.Reçete.Revizyon.BaseRevKod,
                ReçeteId       = x.İşemri.ReçeteId,
                İşemriId       = x.İşemriId,
                ÜrünId         = x.İşemri.Reçete.ÜrünId,
                Miktar         = x.Miktar,
                MamülAdı       = x.Mamül.MamülAdı,
                ÜrünAdı        = x.İşemri.Reçete.Ürün.Mamül.MamülAdı,
                işemriTarih    = x.İşemri.işemriTarih,
                ŞarjMiktarı    = x.İşemri.ŞarjMiktarı,
                ŞarjNo         = x.İşemri.ŞarjNo,
                MarkaAdı       = x.İşemri.Reçete.Ürün.Marka.MarkaAdı,
                FirmaAdi       = x.İşemri.Reçete.Ürün.Firma.FirmaAdi,
                RevizyonTarihi = x.İşemri.Reçete.Revizyon.RevizyonTarihi,
                GTIN           = x.İşemri.Reçete.Ürün.GTIN,
                KullanıcıId    = x.İşemri.KullanıcıId,
                MamülId        = x.MamülId,


            }).ToList();
        }
    }
}
