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
    public interface IReçete
    {
        long ReçeteId { get; set; }
        long MamülId { get; set; }

        float Miktar { get; set; }
        FazTipi FazTipi { get; set; }
        AşamaTipi AşamaTipi { get; set; }
        BirimTipi ReçeteBirimi { get; set; }

    }
    public class ReçeteMalzemeler : BaseEntityHaraket, IReçete
    {

        public Reçete Reçete { get; set; }
        public long ReçeteId { get; set; }
        public int MalzemeİçiÜrün { get; set; }
        public Mamül Mamül { get; set; }
        public long MamülId { get; set; }
        public float Miktar { get; set; }
        public FazTipi FazTipi { get; set; }
        public AşamaTipi AşamaTipi { get; set; }
        public BirimTipi ReçeteBirimi { get; set; }
        public long? YarıMamülId { get; set; }
        public YarıMamül YarıMamül { get; set; }
    }
}
