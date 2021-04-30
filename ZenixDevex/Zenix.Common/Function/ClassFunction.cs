using DevExpress.XtraEditors.TableLayout;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Function
{
    public static class ClassFunction
    {


        public static List<string> GetPropDescriptionList<T>() where T : class
        {
            return typeof(T).GetMembers()
                .SelectMany(x => x.GetCustomAttributes(typeof(DescriptionAttribute), true)
                .Cast<DescriptionAttribute>())
                .Select(x => x.Description).ToList();
        }
        public static void SetDescriptionPropValue<T>(this T obj, string Description, object value) where T : class
        {
            if (string.IsNullOrEmpty(Description)) return;
            if (!GetPropDescriptionList<T>().Any(x => x.Equals(Description))) return;
            var prop = obj.GetType().GetProperties().FirstOrDefault(x => ((DescriptionAttribute)x.GetCustomAttribute(typeof(DescriptionAttribute), true)).Description.Equals(Description));
            if (prop == null) return;

            Type t = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

            object safeValue = (value == null || value == DBNull.Value) ? null : Convert.ChangeType(value, t);




            prop.SetValue(obj, safeValue);
        }
        public static List<T> GetList<T>(this DataTable table) where T : class
        {

            var list = (List<T>)Activator.CreateInstance(typeof(List<T>));
            if (table == null || table.Rows.Count == 0) return list;
            var columlistDescription = GetPropDescriptionList<T>();

            foreach (DataRow item in table.Rows)
            {
                var newobj = (T)Activator.CreateInstance(typeof(T));
                foreach (var description in columlistDescription)
                    newobj.SetDescriptionPropValue(description, item[description]);
                list.Add(newobj);
            }

            return list;
        }
    }
}
