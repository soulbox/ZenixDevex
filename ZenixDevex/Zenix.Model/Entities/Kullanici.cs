using Zenix.Model.Attributes;
using Zenix.Model.Entities.Base;
using Zenix.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zenix.Model.Entities
{
    public class Kullanici : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = true), Kod("Kullanıcı Adı", "txtKullanıcıAdı"), ZorunluAlan("Kullanıcı Adı", "txtKullanıcıAdı")]
        public override string Kod { get; set; }

        [Required, StringLength(30), ZorunluAlan("Adı", "txtAdı")]
        public string Adı { get; set; }
        [Required, StringLength(30), ZorunluAlan("Soyadı", "txtSoyadı")]
        public string Soyadı { get; set; }

        [Required, StringLength(50), ZorunluAlan("Email", "txtEmail")]
        public string Email { get; set; }


        [Required, StringLength(32)]
        public string Şifre { get; set; }

        [StringLength(500)]
        public string Açıklama { get; set; }

        public long? RolId { get; set; }
        public Rol Rol { get; set; }


    }

}
