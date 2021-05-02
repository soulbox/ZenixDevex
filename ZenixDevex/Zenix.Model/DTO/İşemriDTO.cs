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
    public class İşemriS : İşemri
    {
        public string FirmaAdı { get; set; }
        public long FirmaId { get; set; }
        public string ÜrünAdı { get; set; }
        public long ÜrünId { get; set; }
        public long RevizyonId { get; set; }
        //
        public string RevizyonKod { get; set; }
        bool isEmptyKod { get => string.IsNullOrEmpty(Kod); }
        int GetRevNo { get => isEmptyKod ? 1 : Convert.ToInt32(Regex.Match(Kod, @"\d+").Value); }
        public DateTime RevizyonTarihi { get; set; } 
        public string RevKodu { get => isEmptyKod ? "" : $"{RevizyonTarihi:ddMMyyyy}-{GetRevNo:00}"; }
        public string ReçeteAdı { get => $"{ÜrünAdı}-{RevKodu}"; }
        public byte KazanNo { get; set; }

        public int ŞarjNo { get; set; }


    }
}
