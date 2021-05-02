using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;

namespace Zenix.Model.DTO
{
    [NotMapped]
    public class SiparişS : Sipariş
    {
        public string FirmaAdı { get; set; }
        public string ÜrünAdı { get; set; }
        public string AdSoyad { get; set; }
        public string Personel { get=>AdSoyad.ToUpper(); }
        public long FirmaId { get; set; }

    }
    [NotMapped]
    public class SiparişL : BaseEntityDurum
    {
        public string FirmaAdı { get; set; }
        public string ÜrünAdı { get; set; }
        public BirimTipi BirimTipi { get; set; }    
        public int Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public string AdSoyad { get; set; }
        public string Personel { get => AdSoyad.ToUpper(); }
        public string Açıklama { get; set; }

    }
}
