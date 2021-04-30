using Zenix.BLL.Functions;
using Zenix.BLL.Interfaces;
using Zenix.DAL.Interfaces;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zenix.BLL.Base
{
    public class BaseHaraketBLL<TEntity, TContext> : IBaseBLL, IBaseHareketGenelBLL
        where TEntity : BaseEntityHaraket
        where TContext : DbContext
    {
        private IUnitOfWork<TEntity> uow;

        //protected TResult BaseSingle<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        //{

        //    GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
        //    return uow.Rep.Find(filter, selector);
        //}

        public  IQueryable<TResult> List<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
           
            return uow.Rep.Select(filter, selector);
        }

        public Boolean Insert(IList<BaseEntityHaraket> entities)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            uow.Rep.InsertRange (entities.EntityListConvert<TEntity>());
            return uow.Save();
        }

        public bool Update(IList<BaseEntityHaraket> entities)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            uow.Rep.UpdateRange (entities.EntityListConvert<TEntity>());
            return uow.Save();
        }

        public bool Delete(IList<BaseEntityHaraket> entities)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            uow.Rep.DeleteRange(entities.EntityListConvert<TEntity>());
            return uow.Save();
        }

        #region Dispose

        public void Dispose()
        {

            uow?.Dispose();

        }
        #endregion
    }
}
