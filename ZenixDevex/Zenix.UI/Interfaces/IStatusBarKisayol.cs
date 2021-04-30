using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.WinUI.Interfaces
{
   public  interface IStatusBarKisayol:IStatusBarAciklama 
    {
         string StatusBarKisayol { get; set; }
         string StatusBarKisayolAciklama { get; set; }
    }
}
