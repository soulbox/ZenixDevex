using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Common.Function;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{
    public class SiparişÜrünleri : BaseEntityHaraket
    {
        public Sipariş Sipariş { get; set; }
        public long SiparişId { get; set; }
        public Ürün Ürün { get; set; }
        public long ÜrünId { get; set; }
        public int KoliAdedi { get; set; }
        public int Miktar { get; set; }

        public BirimTipi BirimTipi { get; set; }
        public bool Teslimat { get; set; }
        public string Açıklama { get; set; }
        public float BirimFiyat { get; set; }
        public ParaBirimi ParaBirimi { get; set; } = ParaBirimi.TL;
        [NotMapped]
        public string Tutar { get => string.Format("{0:n2}" + $"{ParaBirimi.ToName()}", Miktar * BirimFiyat); }

    }
}
