using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Zenix.BLL.Interfaces;
using Zenix.DAL.Base;
using Zenix.DAL.Interfaces;
using Zenix.Data.Context;
using Zenix.Model.DTO;
using Zenix.Model.Entities.Base;
using Zenix.Model.Entities.Base.Interfaces;

namespace Zenix.BLL.Functions
{
    public static class GeneralFunctions
    {
        const string server = "zenixContext";
        private static string GetConnectionString(string name)
        {
            //return server;
            return ZenixContext.ConBuilder.ConnectionString;
            //return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static T ToBll<T>(this IBaseBLL inter) where T : IBaseBLL
            => (T)inter;

        public static string GetConnectionString()
        {
            return GetConnectionString(server);
        }
        
        private static TContext CreateContext<TContext>() where TContext : DbContext
        {

            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());

        }
        public static void CreateUnitOfWork<TEntity, TContext>(ref IUnitOfWork<TEntity> uow)
        where TEntity : class, IBaseEntity
            where TContext : DbContext
        {
            uow?.Dispose();
            uow = new UnitOfWork<TEntity>(CreateContext<TContext>());
        }


        public static IList<string> GetChangedFields<T>(this T oldEntity, T currentEntity)
        {
            List<string> alanlar = new List<string>();
            List<string> Discard = new List<string>();

            currentEntity.GetType().GetPropertiyAttributeFromType<NotMappedAttribute>()
               .Select(x => x.PropertyInfo.Name).ToList().ForEach(x => Discard.Add(x));
            currentEntity.GetType().GetPropertiyAttributeFromType<DatabaseGeneratedAttribute>()
                .Where(x => ((DatabaseGeneratedAttribute)x.Attribute).DatabaseGeneratedOption == DatabaseGeneratedOption.Computed)
                .Select(x => x.PropertyInfo.Name)
                .ToList().ForEach(x => Discard.Add(x));

            List<PropertyInfo> GetList()
            {
                List<PropertyInfo> proplist = new List<PropertyInfo>();
                foreach (var x in currentEntity.GetType().GetProperties())
                {
                    if (x.PropertyType.IsClass && !x.PropertyType.FullName.StartsWith("System.")) continue;
                    if (!x.CanWrite || Discard.Contains(x.Name) |
                        x.PropertyType.Namespace.Equals("System.Collections.Generic")) continue;
                    proplist.Add(x);
                }

                return proplist;
            }
            var list = GetList();
            //Console.WriteLine("");

            list.ForEach(prop =>
                {
                    //null olan değerler karşılaştırma yapılamadığından.null ise stringe çek. 
                    //if (prop.PropertyType.Namespace.Equals("System.Collections.Generic") | prop.PropertyType.IsClass | prop.CanWrite) return;
                    var oldvalue = oldEntity.GetType().GetProperty(prop.Name).GetValue(oldEntity, null) ?? string.Empty;
                    //prop.GetValue(oldEntity) ?? string.Empty;
                    var curvalue = prop.GetValue(currentEntity) ?? string.Empty;
                    //byte tipindeyse [Resim Olabili]
                    if (prop.PropertyType == typeof(byte[]))
                    {
                        if (string.IsNullOrEmpty(oldvalue.ToString()))
                            oldvalue = new byte[] { 0 };
                        if (string.IsNullOrEmpty(curvalue.ToString()))
                            curvalue = new byte[] { 0 };
                        if (((byte[])oldvalue).Length != ((byte[])oldvalue).Length)
                            alanlar.Add(prop.Name);
                    }
                    else if (!curvalue.Equals(oldvalue)) // normal ise
                        alanlar.Add(prop.Name);
                });


            return alanlar;
        }
        //public static bool IsBase64(this string base64String)
        //{
        //    // Credit: oybek https://stackoverflow.com/users/794764/oybek
        //    if (string.IsNullOrEmpty(base64String) || base64String.Length % 4 != 0
        //       || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
        //        return false;

        //    try
        //    {
        //        Convert.FromBase64String(base64String);
        //        return true;
        //    }
        //    catch (Exception exception)
        //    {
        //        // Handle the exception
        //    }
        //    return false;
        //}
        public static BaseEntity Descrypt(this BaseEntity source, bool relation = false)
        {
            string[] discardlist = { "" };
            //if (source is ŞifrelerS || source is ŞifrelerL)
            //    discardlist = new string[] { "KullanıcıAdıSoyadı" };

            bool isBase64(string base64)
            {
                try
                {
                    if (string.IsNullOrEmpty(base64)) return false;
                    base64 = base64.Trim();
                    return (base64.Length % 4 == 0) && Regex.IsMatch(base64, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
                }
                catch (Exception)
                {

                    return false;

                }

            }

            var secondprop = source.GetType().GetProperties().FirstOrDefault(x => x.Name != "Id" && x.PropertyType == typeof(long));
            var secondpropval = secondprop.GetValue(source);
            var pas = relation ? $"{source.Id}{secondpropval}" : $"{source.Id}";
            source.GetType().GetProperties().Where(x => !discardlist.Contains(x.Name) && x.Name != "Kod" && x.PropertyType == typeof(string) && x.CanWrite).ToList()
                .ForEach(x =>
                {
                    var text = ((string)x.GetValue(source, null));
                    //if (isBase64(encryptedText))
                    //    x.SetValue(source, text.Decrypt(pas));
                    if (isBase64(text) && text.Length >= 24)
                        x.SetValue(source, text.Decrypt(pas));
                    else
                        x.SetValue(source, text);

                });
            return source;
        }
        public static IEnumerable<BaseEntity> Descrypt(this IEnumerable<BaseEntity> source, bool relation = false)
        {
            source.ToList().ForEach(x => Descrypt(x, relation));
            return source;
        }
        public static BaseEntity Encrypt(this BaseEntity source, bool relation = false)
        {
            string[] discardlist = { "" };
            //if (source is ŞifrelerS || source is ŞifrelerL)
            //    discardlist = new string[] { "KullanıcıAdıSoyadı" };
            var secondprop = source.GetType().GetProperties().FirstOrDefault(x => x.Name != "Id" && x.PropertyType == typeof(long));
            var secondpropval = secondprop.GetValue(source);
            var pas = relation ? $"{source.Id}{secondpropval}" : $"{source.Id}";
            source.GetType().GetProperties().Where(x => !discardlist.Contains(x.Name) && x.Name != "Kod" && x.PropertyType == typeof(string)).ToList()
                .ForEach(x =>
                {
                    x.SetValue(source, ((string)x.GetValue(source, null)).Encrypt(pas));
                });
            return source;
        }
        public static IEnumerable<BaseEntity> Encrypt(this IEnumerable<BaseEntity> source, bool relation = false)
        {
            source.ToList().ForEach(x => Encrypt(x, relation));
            return source;
        }


        public static Expression<Func<T, bool>> AndAlso<T>(
               this Expression<Func<T, bool>> expr1,
               Expression<Func<T, bool>> expr2)
        {
            // need to detect whether they use the same
            // parameter instance; if not, they need fixing
            ParameterExpression param = expr1.Parameters[0];
            if (ReferenceEquals(param, expr2.Parameters[0]))
            {
                // simple version
                return Expression.Lambda<Func<T, bool>>(
                    Expression.AndAlso(expr1.Body, expr2.Body), param);
            }
            // otherwise, keep expr1 "as is" and invoke expr2
            return Expression.Lambda<Func<T, bool>>(
                Expression.AndAlso(
                    expr1.Body,
                    Expression.Invoke(expr2, param)), param);
        }

    }
}
