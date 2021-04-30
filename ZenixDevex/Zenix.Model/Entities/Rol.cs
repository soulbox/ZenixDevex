using Zenix.Model.Attributes;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Model.Entities
{
   public  class Rol: BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required,StringLength(50),ZorunluAlan("Rol Adı","txtRolAdi") ]
        public string RolAdi { get; set; }
        [StringLength(50)]
        public string Açıklama { get; set; }
        [InverseProperty("Rol")]//kademeli silmek için gerekli olan attribute
        public ICollection <RolYetkileri > RolYetkileri { get; set; }
    }
}
