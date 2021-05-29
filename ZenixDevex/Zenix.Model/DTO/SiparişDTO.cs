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
    public class SiparişS : Sipariş, IFirma
    {

        public string AdSoyad { get; set; }
        public string Personel { get => AdSoyad.ToUpper(); }
        public string FirmaAdi { get; set; }
    }
    [NotMapped]
    public class SiparişL : BaseEntityDurum, IFirma
    {
        public string FirmaAdi { get; set; }  
        public DateTime Tarih { get; set; }
        public string AdSoyad { get; set; }
        public string Personel { get => AdSoyad.ToUpper(); }
        public string Açıklama { get; set; }
        public int ÜrünMiktarı { get; set; }
        public SiparişL Clone { get =>(SiparişL)this.MemberwiseClone(); }

    }
}
