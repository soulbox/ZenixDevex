using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.DTO
{

    public interface IBaseÜrünTanıtım
    {
         long ÜrünId { get; set; }
        string MamülAdı { get; set; }
        string FirmaAdi { get; set; }
        string MarkaAdı { get; set; }
        string GTIN { get; set; }
    }

    public interface IRevizyon : IBaseÜrünTanıtım
    {
  
        string Açıklama { get; set; }
    }

    [NotMapped]
    public class RevizyonS : Revizyon, IRevizyon
    {
        public string MamülAdı { get; set; }
        public string FirmaAdi { get; set; }
        public string MarkaAdı { get; set; }
        public string GTIN { get; set; }
    }

}
