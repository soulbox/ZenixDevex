using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{
    public class Satınalma : BaseEntityDurum
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        public Firma Firma { get; set; }
        public long FirmaId { get; set; }
        public long KullanıcıId { get; set; }
        public Kullanici Kullanıcı { get; set; }
        public DateTime KayıtTarihi { get; set; }
        public bool Teslimat { get; set; }
        public bool Onay { get; set; }

    }
}
