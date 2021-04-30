using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.BLL.Functions
{
public static    class ValidationFunctions
    {

        public static List<PropertyAttribute<TAttribute>> GetPropertiyAttributeFromType<TAttribute>(this Type entitytype) where TAttribute :Attribute 
        {
            var list = new List<PropertyAttribute<TAttribute>>();
            var propties = entitytype.GetProperties();
            foreach (var prop in propties)
            {
                var attributes = prop.GetCustomAttributes<TAttribute>(true).ToList();
                if (!attributes.Any()) continue;
                list.AddRange(attributes.Select(x => new PropertyAttribute<TAttribute>(prop, x)));
            }
            ///interfaceler aracılığıyla gelen attributelerde eklendi
            var interfaces = entitytype.GetInterfaces();
            foreach (var prop in interfaces)
            {
                list.AddRange(prop.GetPropertiyAttributeFromType<TAttribute>());
            }
            return list;
        } 
        public class PropertyAttribute<TAttribute>  
        {
            public PropertyInfo PropertyInfo { get;  }
            public TAttribute Attribute  { get;  }
            public PropertyAttribute(PropertyInfo info,TAttribute attribute )
            {
                PropertyInfo = info;
                this.Attribute = attribute;
            }
        }
    }
}
