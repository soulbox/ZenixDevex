using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Zenix.Model.Entities.Base.Interfaces;
using Zenix.Common.Enums;

namespace Zenix.Model.DTO
{
    [NotMapped]

    public class YarıMamülL : YarıMamül, IYarıMamülAdı, IBaseHaraketEntity, IBaseÜrünTanıtım
    {
        public string YarıMamülAdı { get; set; }
        public string ÜrünAdı { get => $"{MarkaAdı } - {MamülAdı }"; }
        public string MamülAdı { get; set; }
        public string FirmaAdi { get; set; }
        public string MarkaAdı { get; set; }
        public string GTIN { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }

    }
}
