using Zenix.BLL.Base;
using Zenix.BLL.Interfaces;
using Zenix.Common.Enums;
using Zenix.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zenix.BLL.General
{
    public class RolBll : BaseGenelBLL<Rol>, IBaseGenelBll, IBaseCommonBLL
    {
        public RolBll() : base( KartTuru.Rol) { }

        public RolBll(Control ctrl) : base(ctrl,KartTuru.Rol ) { }


    }
}
