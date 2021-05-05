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
using Zenix.Model.Entities.Base;
using Zenix.Model.DTO;

namespace Zenix.BLL.General
{
    public class ReçeteBll : BaseGenelBLL<Reçete>, IBaseCommonBLL
    {
        public ReçeteBll() : base(KartTuru.Reçete) { }

        public ReçeteBll(Control ctrl) : base(ctrl, KartTuru.Reçete) { }
      

    }
}
