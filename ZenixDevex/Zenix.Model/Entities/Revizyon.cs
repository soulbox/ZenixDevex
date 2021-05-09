using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.Attributes;
using Zenix.Model.Entities.Base;


namespace Zenix.Model.Entities
{
    public class Revizyon : BaseRevizyon
    {

        public Ürün Ürün { get; set; }
        public long ÜrünId { get; set; }
        public string Açıklama { get; set; }

    }
    public class BaseRevizyon : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        public DateTime RevizyonTarihi { get; set; } = DateTime.Now;
        [NotMapped]
        public string BaseRevKod { get; set; }
        [NotMapped]
        public int RevNo { get => string.IsNullOrEmpty(BaseRevKod) ? 1 : Convert.ToInt32(Regex.Match(BaseRevKod, @"\d+").Value); }
        [NotMapped]
        public string RevKodu { get => $"{RevizyonTarihi:ddMMyyyy}-{RevNo:00}"; }
    }
}
