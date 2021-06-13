using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{
    public interface IYarıMamülAdı
    {

        string YarıMamülAdı { get; set; }
    }
    public class YarıMamülGrup : BaseEntity, IYarıMamülAdı
    {
        [Index(name: "IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        public string YarıMamülAdı { get; set; }
    }
}
