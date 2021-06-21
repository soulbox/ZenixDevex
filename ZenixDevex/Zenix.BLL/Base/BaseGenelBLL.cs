using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenix.Common.Enums;
using Zenix.Data.Context;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;

namespace Zenix.BLL.Base
{
    public class BaseGenelBLL<TEntity> : BaseBLL<TEntity, ZenixContext> where TEntity : BaseEntity
    {
        public readonly KartTuru KartTuru;

        public BaseGenelBLL(KartTuru kartTuru) { KartTuru = kartTuru; }
        public BaseGenelBLL(Control ctrl, KartTuru kartTuru) : base(ctrl) { KartTuru = kartTuru; }
        public BaseGenelBLL() { }
        public BaseGenelBLL(Control ctrl) : base(ctrl) { }



        public virtual BaseEntity Single(Expression<Func<TEntity, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public virtual IEnumerable<BaseEntity> List(Expression<Func<TEntity, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }
        public virtual bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }
        public virtual bool Insert(BaseEntity entity, Expression<Func<TEntity, bool>> filter)
        {

            return BaseInsert(entity, filter);
        }
        public virtual bool Insert(List<BaseEntity> entities)
        {

            return entities.Count == 0 || BaseInsert(entities);
        }
        public bool InsertRange(List<BaseEntity> entity, Expression<Func<TEntity, bool>> filter)
        {

            return BaseInsertRange(entity, filter);
        }
        public virtual bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        }


        public virtual bool Update(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<TEntity, bool>> filter)
        {
            return BaseUpdate(oldEntity, currentEntity, filter);
        }
        public bool Delete(BaseEntity entity, bool mesajver = true)
        {
            return BaseDelete(entity, this.KartTuru, mesajver);
        }

        public string YeniKodVer()
        {
            return BaseYeniKodVer(KartTuru, x => x.Kod, null);
        }
        public string YeniKodVer(bool isdouble)
        {
            return BaseYeniKodVer(KartTuru, x => x.Kod, null, isdouble);
        }
        public string YeniKodVer(Expression<Func<TEntity, bool>> filter)
        {
            return BaseYeniKodVer(KartTuru, x => x.Kod, filter);
        }

        public string YeniKodVer(MalzemeTipi malzemeTipi, Expression<Func<TEntity, bool>> filter)
        {
            return BaseYeniKodVer(KartTuru.Mamül, malzemeTipi, x => x.Kod, filter);
        }
    }
}
