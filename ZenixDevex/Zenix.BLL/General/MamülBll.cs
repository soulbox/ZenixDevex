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
    public class MamülBll : BaseGenelBLL<Mamül>, IBaseGenelBll, IBaseCommonBLL
    {
        public MamülBll() : base(KartTuru.Mamül) { }

        public MamülBll(Control ctrl) : base(ctrl, KartTuru.Mamül) { }
        public override BaseEntity Single(Expression<Func<Mamül, bool>> filter)
        {
            return BaseSingle(filter, x => new MamülL
            {
                Id                 = x.Id,
                Kod                = x.Kod,
                Durum              = x.Durum,
                Adı                = x.Adı,
                Alan               = x.Alan,
                AlanınBirimi       = x.AlanınBirimi,
                AmbalajMaddeAdı    = x.AmbalajMaddeTipi.Adı,
                AmbalajMaddeTipiId = x.AmbalajMaddeTipiId,
                AmbalajTipiAdı     = x.AmbalajTipi.Adı,
                AmbalajTipiId      = x.AmbalajTipiId,
                Ağırlık            = x.Ağırlık,
                AğırlığınBirimi    = x.AğırlığınBirimi,
                AğızÖlçüsü         = x.AğızÖlçüsü,
                BirimAuEbY         = x.BirimAuEbY,
                Boy                = x.Boy,
                En                 = x.En,
                Uzunluk            = x.Uzunluk,
                Hacim              = x.Hacim,
                MalzemeBirimi      = x.MalzemeBirimi,
                SarfTipi           = x.SarfTipi,
                Yükseklik          = x.Yükseklik,
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Mamül, bool>> filter)
        {
            return BaseList(filter, x => new MamülL
            {
                Id = x.Id,
                Kod = x.Kod,
                Durum = x.Durum,
                Adı = x.Adı,
                //Alan = x.Alan,
                //AlanınBirimi = x.AlanınBirimi,
                //AmbalajMaddeAdı = x.AmbalajMaddeTipi.Adı,
                //AmbalajMaddeTipiId = x.AmbalajMaddeTipiId,
                //AmbalajTipiAdı = x.AmbalajTipi.Adı,
                //AmbalajTipiId = x.AmbalajTipiId,
                //Ağırlık = x.Ağırlık,
                //AğırlığınBirimi = x.AğırlığınBirimi,
                //AğızÖlçüsü = x.AğızÖlçüsü,
                //BirimAuEbY = x.BirimAuEbY,
                //Boy = x.Boy,
                //En = x.En,
                //Uzunluk = x.Uzunluk,
                //Hacim = x.Hacim,
                //MalzemeBirimi = x.MalzemeBirimi,
                //SarfTipi = x.SarfTipi,
                //Yükseklik = x.Yükseklik,

            })
                .ToList();
        }
    }
}
