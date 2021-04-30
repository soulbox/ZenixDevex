using System;

namespace Zenix.Model.Attributes
{
    public class ZorunluAlan : Attribute
    {
        /// <summary>
        /// Validation işlemleri sırasında Zorunlu Olan Alanları işaretlemek için kullanılacak
        /// </summary>
        /// <param name="description">Uyarı Mesajında Gösterilicek Olan Açıklama</param>
        /// <param name="controlname">Uyarı Mesajı sonrası Focuslanıcak Control adı</param>
        public ZorunluAlan(string description, string controlname)
        {
            Description = description;
            ControlName = controlname;
        }
        public string Description { get; }
        public string ControlName { get; }

    }
}
