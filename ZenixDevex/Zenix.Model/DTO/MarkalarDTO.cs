using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.DTO
{
    [NotMapped]
    public class MarkalarS : Markalar
    {
        public string FirmaAdı { get; set; }
        public string ÜrünAdı { get; set; }
        public FirmaTipi FirmaTipi { get; set; }

    }

}
