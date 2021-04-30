using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Model.Attributes
{
    public class Kod : Attribute
    {
        /// <summary>
        /// Validation işlemleri sırasında Zorunlu Olan Alanları işaretlemek için kullanılacak
        /// </summary>
        /// <param name="description">Uyarı Mesajında Gösterilicek Olan Açıklama</param>
        /// <param name="controlname">Uyarı Mesajı sonrası Focuslanıcak Control adı</param>
        public Kod(string description, string controlname)
        {
            Description = description;
            ControlName = controlname;
        }
        public string Description { get; }
        public string ControlName { get; }
    }
}
