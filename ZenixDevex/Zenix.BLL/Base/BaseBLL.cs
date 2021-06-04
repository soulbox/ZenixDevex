using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Zenix.BLL.Functions;
using Zenix.BLL.Interfaces;
using Zenix.Common.Enums;
using Zenix.DAL.Interfaces;
using Zenix.Model.Entities.Base;
using Zenix.Common.Messages;
using Zenix.Common.Function;
using Zenix.Model.Attributes;
using Zenix.Model.Entities;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Zenix.BLL.Base
{
    public class BaseBLL<TEntity, TContext> : IBaseBLL
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        public bool ShowMessageOnValidation { get; set; } = true;
        private readonly Control Ctrl;
        private IUnitOfWork<TEntity> uow;
        protected BaseBLL() { }
        protected BaseBLL(Control ctrl) { this.Ctrl = ctrl; }
        private bool Validation(IslemTuru ıslemTuru, BaseEntity OldEntity, BaseEntity CurrentEntity, Expression<Func<TEntity, bool>> filter)
        {
            var errorcontrol = GetValidationErrorControl();
            if (errorcontrol == null) return true;
            Ctrl?.Controls[errorcontrol].Focus();
            return false;

            string GetValidationErrorControl()
            {
                string Mukerrer()
                {
                    foreach (var prop in typeof(TEntity).GetPropertiyAttributeFromType<Kod>())
                    {
                        if (prop.Attribute == null) continue;
                        if ((ıslemTuru == IslemTuru.EntityInsert || OldEntity.Kod == CurrentEntity.Kod) && ıslemTuru == IslemTuru.EntityUpdate) continue;
                        if (uow.Rep.Count(filter) < 1) continue;
                        if (ShowMessageOnValidation)
                            Msg.MukerrerKayitHataMesajı(prop.Attribute.Description);

                        return prop.Attribute.ControlName;
                    }
                    return null;
                }
                string HataliGiris()
                {
                    foreach (var prop in typeof(TEntity).GetPropertiyAttributeFromType<ZorunluAlan>())
                    {
                        if (prop.Attribute == null) continue;
                        var value = CurrentEntity.GetType().GetProperty(prop.PropertyInfo.Name).GetValue(CurrentEntity, null);
                        //var value = prop.PropertyInfo.GetValue(CurrentEntity);
                        if (prop.PropertyInfo.PropertyType == typeof(long))
                            if ((long)value == 0) value = null;
                        if (!string.IsNullOrEmpty(value?.ToString())) continue;
                        if (ShowMessageOnValidation)
                            Msg.HataliVeriMesajı(prop.Attribute.Description);
                        return prop.Attribute.ControlName;

                    }
                    return null;
                }
                //string MakineKullanıcıYetki()
                //{
                //    foreach (var prop in typeof(TEntity).GetPropertiyAttributeFromType<KullaniciMakineYetki>())
                //    {
                //        if (prop.Attribute == null) continue;
                //        //IUnitOfWork<KullaniciMakine> valid = uow as IUnitOfWork<KullaniciMakine>;
                //        if (valid == null) continue;
                //        if (valid.Rep.Count(x => x.KullaniciId == ((KullaniciMakine)CurrentEntity).KullaniciId && x.MakineId == ((KullaniciMakine)CurrentEntity).MakineId) < 1) continue;
                //        Msg.HataMesajı(prop.Attribute.Description);
                //        return prop.Attribute.ControlName;

                //    }
                //    return null;
                //}
                return HataliGiris() ?? Mukerrer();
            }


        }


        protected TResult BaseSingle<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        {

            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            return uow.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            return uow.Rep.Select(filter, selector);
        }

        protected Boolean BaseInsert(BaseEntity entity, Expression<Func<TEntity, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            if (!Validation(IslemTuru.EntityInsert, null, entity, filter)) return false;
            uow.Rep.Insert(entity.EntityConvert<TEntity>());

            return uow.Save();
        }
        protected bool BaseInsert(List<BaseEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            //if (!Validation(IslemTuru.EntityInsert, null, entity, filter)) return false;
            uow.Rep.InsertRange(entities.EntityListConvert<TEntity>());

            return uow.Save();
        }
        protected Boolean BaseInsertRange(List<BaseEntity> entity, Expression<Func<TEntity, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            if (entity.Any(x => !Validation(IslemTuru.EntityInsert, null, x, filter))) return false;
            //if (!Validation(IslemTuru.EntityInsert, null, entity, filter)) return false;
            uow.Rep.InsertRange(entity.Select(x => x.EntityConvert<TEntity>()));

            return uow.Save();
        }
        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<TEntity, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            if (!Validation(IslemTuru.EntityUpdate, oldEntity, currentEntity, filter)) return false;
            var değişenalanlar = oldEntity.GetChangedFields(currentEntity);
            if (değişenalanlar.Count.Equals(0)) return true;
            uow.Rep.Update(currentEntity.EntityConvert<TEntity>(), değişenalanlar);
            return uow.Save();
        }

        protected bool BaseDelete(BaseEntity entity, KartTuru EntityTuru, bool messajver = true)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            if (messajver)
                if (Msg.SilMesajı(EntityTuru.ToName()) != DialogResult.Yes) return false;

            uow.Rep.Delete(entity.EntityConvert<TEntity>());
            return uow.Save();
        }
        protected int Count(Expression<Func<TEntity, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            return uow.Rep.Count(filter);
        }
        protected string BaseYeniKodVer(KartTuru kayitTuru, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            return uow.Rep.YeniKodVer(kayitTuru, filter, where);

        }
        protected string BaseYeniKodVer(KartTuru kayitTuru, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null, bool isyeni = false)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            return uow.Rep.YeniKodVer(kayitTuru, filter, where, isyeni);

        }
        protected string BaseYeniKodVer(KartTuru kayitTuru, MalzemeTipi malzemeTipi, Expression<Func<TEntity, string>> filter, Expression<Func<TEntity, bool>> where = null)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            return uow.Rep.YeniKodVer(kayitTuru, malzemeTipi, filter, where);

        }
        public int ExecuteCommand(string cmd)
        {
            GeneralFunctions.CreateUnitOfWork<TEntity, TContext>(ref uow);
            return uow.ExecuteCommand(cmd);

        }
        #region Dispose

        public void Dispose()
        {

            Ctrl?.Dispose();
            uow?.Dispose();

        }
        #endregion
    }
}
