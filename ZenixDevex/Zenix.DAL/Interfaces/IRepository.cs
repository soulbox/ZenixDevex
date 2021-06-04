using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;

namespace Zenix.DAL.Interfaces
{

    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        /// <summary>
        /// TEntity: tablosundaki alanlara göre update yapar 
        /// </summary> 
        /// <typeparamref name="TEntity">tablosundaki alanlara göre update yapar </typeparamref>
        /// <param name="entity">tablosundaki</param>
        /// <param name="fields">alanlar</param>
        void Update(TEntity entity, IEnumerable<string> fields);
        /// <summary>
        /// IEnumerable<TEntity>:liste tablosundaki alanlara göre update yapar 
        /// </summary>
        /// <typeparamref name="TEntity">tablosundaki alanlara göre update yapar </typeparamref>
        /// <param name="entities">liste tablosundaki</param>
        /// <param name="fields">alanlar</param>
        void UpdateRange(IEnumerable<TEntity> entities, IEnumerable<string> fields);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        TResult Find<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector);
        /// <summary>
        /// entitye göre filitreliyip tresult tipinde geri değer döner.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="filter">Filitreler</param>
        /// <param name="selector">Tresolt tipinde Geri Döner</param>
        /// <returns></returns>
        IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector);
        int Count(Expression<Func<TEntity, bool>> filter = null);

        string YeniKodVer(KartTuru kartTuru, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null);

        string YeniKodVer(KartTuru kartTuru, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null, bool birüst = false);
        string YeniKodVer(KartTuru kartTuru,MalzemeTipi malzemeTipi, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null);

    }
}
