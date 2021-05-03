using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Zenix.BLL.Base;
using Zenix.BLL.Interfaces;
using Zenix.Common.Enums;
using Zenix.Data.Context;
using Zenix.Model.DTO;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;


namespace Zenix.BLL.General
{
    public class ÜrünBll : BaseGenelBLL<Ürün>, IBaseGenelBll, IBaseCommonBLL
    {
        public ÜrünBll() : base(KartTuru.Ürün) { }

        public ÜrünBll(Control ctrl) : base(ctrl, KartTuru.Ürün) { }


    }
}
