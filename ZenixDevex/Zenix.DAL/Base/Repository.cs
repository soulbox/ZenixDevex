using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Zenix.Common.Enums;
using Zenix.Common.Function;
using Zenix.DAL.Interfaces;

namespace Zenix.DAL.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext Db;
        private readonly DbSet<TEntity> DbSet;

        public Repository(DbContext db)
        {
            if (db == null) return;
            this.Db = db;
            DbSet = Db.Set<TEntity>();
        }
        public void Insert(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Added;
        }
        public void InsertRange(IEnumerable<TEntity> entities)
        {
            entities.ToList().ForEach(x => Db.Entry(x).State = EntityState.Added);
        }
        public void Update(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;

        }
        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            entities.ToList().ForEach(x => Db.Entry(x).State = EntityState.Modified);

        }
        public void Update(TEntity entity, IEnumerable<string> fields)
        {
            //bu entityle işlem yapıcağımızı söyledik
            DbSet.Attach(entity);
            //biz entitynin fields'ları arasında dolaşım güncelleme yapıcağımızı söyledik
            var entry = Db.Entry(entity);

            fields.ToList().ForEach(field =>
            {
                entry.Property(field).IsModified = true;
            });
        }
        public void UpdateRange(IEnumerable<TEntity> entities, IEnumerable<string> fields)
        {
            entities.ToList().ForEach(entity =>
            {
                //bu entityle işlem yapıcağımızı söyledik
                DbSet.Attach(entity);
                //biz entitynin fields'ları arasında dolaşım güncelleme yapıcağımızı söyledik
                var entry = Db.Entry(entity);
                fields.ToList().ForEach(field =>
                {
                    entry.Property(field).IsModified = true;
                });
            });
        }
        public void Delete(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Deleted;

        }
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            entities.ToList().ForEach(x => Db.Entry(x).State = EntityState.Deleted);

        }
        public TResult Find<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        {
            return filter == null ? DbSet.Select(selector).FirstOrDefault() : DbSet.Where(filter).Select(selector).FirstOrDefault();
        }
        public IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        {
            return filter == null ? DbSet.Select(selector) : DbSet.Where(filter).Select(selector);
        }

        public int Count(Expression<Func<TEntity, bool>> filter = null)
        {
            var count = filter == null ? DbSet.Count() : DbSet.Count(filter);
            return count;
        }

        public string YeniKodVer(KartTuru kartTuru, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null)
        {

            string Kod()
            {
                var name = kartTuru.ToName();
                var dizi = name
                    .Replace(" Kartı","")
                    .Replace("Kredi", "Kart") + "-0001";
                //if (kartTuru != KartTuru.Sigortalar)
                //    dizi = dizi.Replace("Sigorta ", "");
                return dizi;
            }
            string YeniKodVer(string kod)
            {
                var sayısaldeğerler = "";
                foreach (var karakter in kod)
                    if (char.IsDigit(karakter))
                        sayısaldeğerler += karakter;
                    else
                        sayısaldeğerler = "";


                var artis = int.Parse(sayısaldeğerler) + 1;
                var fark = kod.Length - artis.ToString().Length;
                if (fark < 0)
                    fark = 0;
                var yenideğer = kod.Substring(0, fark);
                yenideğer += artis.ToString();
                return yenideğer.ToString();
            }

            var maxKod = where == null ? DbSet.Max(filter) : DbSet.Where(where).Max(filter);

            return maxKod == null ? Kod() : YeniKodVer(maxKod);

        }
        public string YeniKodVer(KartTuru kartTuru, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null,bool birüst=false )
        {

            string Kod()
            {
                string kod = null;
                var dizi = kartTuru.ToName() + "-0001";


                return dizi;
            }
            string YeniKodVer(string kod)
            {
                var sayısaldeğerler = "";
                foreach (var karakter in kod)
                    if (char.IsDigit(karakter))
                        sayısaldeğerler += karakter;
                    else
                        sayısaldeğerler = "";


                var artis = int.Parse(sayısaldeğerler) + 1;
                var fark = kod.Length - artis.ToString().Length;
                if (fark < 0)
                    fark = 0;
                var yenideğer = kod.Substring(0, fark);
                yenideğer += artis.ToString();
                return yenideğer.ToString();
            }

            var maxKod = where == null ? DbSet.Max(filter) : DbSet.Where(where).Max(filter);

            return maxKod == null ? Kod() : birüst ? YeniKodVer(YeniKodVer(maxKod)): YeniKodVer(maxKod);

        }

        #region Dispose

        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    Db.Dispose();
                disposedValue = true;

            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }






        #endregion
    }
}
