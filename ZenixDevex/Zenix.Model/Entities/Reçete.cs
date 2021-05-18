using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Attributes;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{
    public interface IBaseReçete
    {
        long RevizyonId { get; set; }
        string AFazıHazırlanış { get; set; }
        string BFazıHazırlanış { get; set; }
        string CFazıHazırlanış { get; set; }
        string DFazıHazırlanış { get; set; }
        string EFazıHazırlanış { get; set; }
        string Açıklama { get; set; }

    }
    public class Reçete : BaseEntityDurum, IBaseReçete
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        public Ürün Ürün { get; set; }
        [Required, ZorunluAlan("Ürün", "txtÜrün")]
        public long ÜrünId { get; set; }
        public Revizyon Revizyon { get; set; }
        [Required, ZorunluAlan("Revizyonu", "txtRevizyon")]
        public long RevizyonId { get; set; }

        public string AFazıHazırlanış { get; set; }
        public string BFazıHazırlanış { get; set; }
        public string CFazıHazırlanış { get; set; }
        public string DFazıHazırlanış { get; set; }
        public string EFazıHazırlanış { get; set; }

        public string Açıklama { get; set; }


        public ICollection<ReçeteMalzemeler> ReçeteMalzemeler { get; set; }
    }
}
