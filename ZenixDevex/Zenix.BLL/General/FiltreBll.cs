using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zenix.BLL.Base;
using Zenix.BLL.Interfaces;
using Zenix.Common.Enums;
using Zenix.Data.Context;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;

namespace Zenix.BLL.General
{
    public class FiltreBll : BaseGenelBLL<Filtre>, IBaseCommonBLL
    {
        public FiltreBll():base(KartTuru.Filtre ) { }

        public FiltreBll(Control ctrl) : base(ctrl, KartTuru.Filtre ) { }
    
    }
}
