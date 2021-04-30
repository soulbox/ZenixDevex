using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Model.DTO
{
    [NotMapped]
    public class KullanıcıS : Kullanici
    {
        public string RolAdı { get; set; }
    }
    [NotMapped]
    public class KullanıcıL : BaseEntity 
    {
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string Email { get; set; }
        public string RolAdı { get; set; }
        public string Açıklama { get; set; }

    }
}
