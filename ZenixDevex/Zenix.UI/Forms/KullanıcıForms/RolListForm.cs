using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.WinUI.Show;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using Zenix.Model.DTO;

using System;
using DevExpress.DataAccess;
using System.Linq.Expressions;
using System.Linq;
using Zenix.Common.Messages;

namespace Zenix.WinUI.Forms.KullanıcıForms
{
    public partial class RolListForm :BaseListForm
    {
        public RolListForm()
        {
            InitializeComponent();
            Bll = new RolBll();
        }

        
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Rol ;
            this.FormShow = new ShowEditForms<RolEditForm >();
            this.Navigator = longNavigator.controlNavigator;
            Tablo.ViewCaption = Text;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((RolBll)Bll).List(FilterFunctions.Filter<Rol>(AktifKayitlariGoster));

        }
    }
}