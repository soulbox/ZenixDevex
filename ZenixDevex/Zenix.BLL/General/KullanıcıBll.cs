using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Zenix.BLL.Base;
using Zenix.BLL.Interfaces;
using Zenix.Common.Enums;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using Zenix.Model.DTO;

namespace Zenix.BLL.General
{
    public class KullanıcıBll : BaseGenelBLL<Kullanici>, IBaseGenelBll, IBaseCommonBLL
    {
        public KullanıcıBll() : base(KartTuru.Kullanıcı) { }

        public KullanıcıBll(Control ctrl) : base(ctrl, KartTuru.Kullanıcı) { }

        public override BaseEntity Single(Expression<Func<Kullanici, bool>> filter)
        {
            return BaseSingle(filter , x => new KullanıcıS
            {
                Id = x.Id,
                Kod = x.Kod,
                Adı = x.Adı,
                Durum = x.Durum,
                Açıklama = x.Açıklama,
                Email = x.Email,
                RolAdı = x.Rol.RolAdi,
                RolId = x.RolId,
                Soyadı = x.Soyadı,
                Şifre = x.Şifre,
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Kullanici, bool>> filter)
        {
            return BaseList(filter, x => new KullanıcıL
            {
                Id = x.Id,
                Kod = x.Kod,
                Adı = x.Adı,
                Açıklama = x.Açıklama,
                Email = x.Email,
                RolAdı = x.Rol.RolAdi,
                Soyadı = x.Soyadı,
            })
            .Where(x => x.Kod != "admin")
            .ToList();
        }
    }
}
