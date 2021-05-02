
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.Attributes;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{
    public class Filtre : BaseEntity
    {
        [Index(name: "IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        [Required(), StringLength(100), ZorunluAlan("Filitre Adı", "txtFiltreAdi")]
        public string FiltreAdi { get; set; }
        [Required(), StringLength(1000), ZorunluAlan("Filitre Metini", "txtFiltreMetni")]
        public string FiltreMetni { get; set; }
        [Required(),]
        public KartTuru KartTuru { get; set; }


    }

}
