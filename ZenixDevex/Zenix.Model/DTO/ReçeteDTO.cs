using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Zenix.Model.DTO
{

    [NotMapped]
    public class ReçeteS : BaseRevizyon, IBaseÜrünTanıtım, IBaseReçete
    {
        public string ReçeteAdı => $"{MarkaAdı}-{MamülAdı}-{GTIN}-{RevKodu}";

        public long ÜrünId { get; set; }
        public long RevizyonId { get; set; }
        public string MamülAdı { get; set; }
        public string FirmaAdi { get; set; }
        public string MarkaAdı { get; set; }
        public string GTIN { get; set; }
        public string AFazıHazırlanış { get; set; }
        public string BFazıHazırlanış { get; set; }
        public string CFazıHazırlanış { get; set; }
        public string DFazıHazırlanış { get; set; }
        public string EFazıHazırlanış { get; set; }
        public string Açıklama { get; set; }


    }
    [NotMapped]
    public class ReçeteL : ReçeteS
    {
        public bool RevizyonDurum { get; set; }
        public int MalzemeMiktarı { get; set; }
        public ReçeteL  Clone { get=>(ReçeteL )this.MemberwiseClone(); }

    }
}
