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
    public class ReçeteS : Reçete
    {
        public string FirmaAdı { get; set; }
        public long FirmaId { get; set; }
        public string ÜrünAdı { get; set; }
        public long ÜrünId { get; set; }
        //
        public string RevizyonKod { get; set; }
        bool isEmptyKod { get => string.IsNullOrEmpty(Kod); }
        int GetRevNo { get => isEmptyKod ? 1 : Convert.ToInt32(Regex.Match(Kod, @"\d+").Value); }
        public DateTime RevizyonTarihi { get; set; } = DateTime.Now;
        public string RevKodu { get => isEmptyKod ? "" : $"{RevizyonTarihi:ddMMyyyy}-{GetRevNo:00}"; }
    }
    [NotMapped]
    public class ReçeteL : BaseEntityDurum
    {
        public string FirmaAdı { get; set; }
        public string ÜrünAdı { get; set; }
        public string AFazıHazırlanış { get; set; }
        public string BFazıHazırlanış { get; set; }
        public string CFazıHazırlanış { get; set; }
        //
        public string RevizyonKod { get; set; }
        int GetRevNo { get => Convert.ToInt32(Regex.Match(Kod, @"\d+").Value); }
        public DateTime RevizyonTarihi { get; set; }
        public string RevKodu { get => $"{RevizyonTarihi:ddMMyyyy}-{GetRevNo:00}"; }

        public int MalzemeMiktarı { get; set; }

    }
}
