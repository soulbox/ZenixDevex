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
    public class Revizyon : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        public Ürün Ürün { get; set; }
        public long ÜrünId { get; set; }
        public DateTime RevizyonTarihi { get; set; }
        public string Açıklama { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        int GetRevNo { get => Convert.ToInt32(Regex.Match(Kod, @"\d+").Value); }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string RevKodu { get => $"{RevizyonTarihi:yyyyMMdd}{GetRevNo:00}"; }


    }
}
