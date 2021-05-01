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
    public class ReçeteMalzemeler : BaseEntityHaraket
    {

        public Reçete Reçete { get; set; }
        public long ReçeteId { get; set; }
        public Malzeme Malzeme { get; set; }
        public long MalzemeId { get; set; }
        public float Miktar { get; set; }
        public FazTipi FazTipi { get; set; }

    }
}
