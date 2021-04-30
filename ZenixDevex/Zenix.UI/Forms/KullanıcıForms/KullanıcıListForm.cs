using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using DevExpress.XtraBars;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using Zenix.WinUI.Show;

namespace Zenix.WinUI.Forms.KullanıcıForms
{
    public partial class KullanıcıListForm : BaseListForm
    {
        public KullanıcıListForm()
        {
            InitializeComponent();
            Bll = new KullanıcıBll();
            HideItems = new BarItem[] { btnSeç  };
        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Kullanıcı ;
            //this.FormShow = new ShowEditForms<KullanıcıEditForm >();

            this.Navigator = longNavigator.controlNavigator;
            Tablo.ViewCaption = Text;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KullanıcıBll)Bll).List(FilterFunctions.Filter<Kullanici>(AktifKayitlariGoster));
        }
        protected override void ShowEditForm(long id)
        {
            var result = new ShowEditForms<KullanıcıEditForm>().ShowDialogEditForm(Common.Enums.KartTuru.Kullanıcı, id);
            ShowEditFormDefault(result);

        }
    }
}