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
    public class SatınalmaS : Satınalma, IFirma
    {
        public string FirmaAdi { get; set; }
    }
    [NotMapped]
    public class SatınalmaL : SatınalmaS
    {
        public string AdSoyad { get; set; }
        public string Personel { get => AdSoyad.ToUpper(); }
        public string Ülke { get; set; }
        public string FirmaTipi { get; set; }
        public int SatınAlmaMiktarı { get; set; }
    }

}
