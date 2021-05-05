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
    public class AmbalajMaddeTipiBll : BaseGenelBLL<AmbalajMaddeTipi >, IBaseGenelBll, IBaseCommonBLL
    {
        public AmbalajMaddeTipiBll() : base(KartTuru.AmbalajTipi) { }

        public AmbalajMaddeTipiBll(Control ctrl) : base(ctrl, KartTuru.AmbalajTipi) { }
    }
}
