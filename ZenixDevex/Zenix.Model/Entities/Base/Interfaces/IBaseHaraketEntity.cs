using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Model.Entities.Base.Interfaces
{
    public interface IBaseHaraketEntity
    {
        bool Insert { get; set; }
        bool Update { get; set; }
        bool Delete { get; set; }


    }
}
