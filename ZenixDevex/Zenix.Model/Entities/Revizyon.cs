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
   public interface IBaseRevizyon
    {
        string BaseRevKod { get; set; }
        string RevKodu { get; }
        DateTime RevizyonTarihi { get; set; }
    }

    public class BaseRevizyon : BaseEntityDurum,IBaseRevizyon
    {
        [Index(name: "IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        public DateTime RevizyonTarihi { get; set; } = DateTime.Now;
        [NotMapped]
        public string BaseRevKod { get; set; }
        [NotMapped]
        public int RevNo { get => GetRevNo(BaseRevKod); }
        [NotMapped]
        public string RevKodu { get => $"{RevizyonTarihi:ddMMyyyy}-{RevNo:00}"; }
        public static string GetRevKodu(string kod,DateTime revtarih) 
        {
        int getrevno = string.IsNullOrEmpty(kod) ? 1 : Convert.ToInt32(Regex.Match(kod, @"\d+").Value);
            return $"{revtarih:ddMMyyyy}-{getrevno:00}";
        }
        public  static int GetRevNo(string baserevkod)
            => string.IsNullOrEmpty(baserevkod) ? 1 : Convert.ToInt32(Regex.Match(baserevkod, @"\d+").Value);

    }
}
