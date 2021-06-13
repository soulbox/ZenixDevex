using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.WinUI.Show;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using Zenix.BLL.Functions;
namespace Zenix.WinUI.Forms.YarıMamülGrupFormu
{
    public partial class YarıMamülGrupListForm :BaseListForm
    {
        public YarıMamülGrupListForm()
        {
            InitializeComponent();
            Bll = new YarıMamülGrupBll();
        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.YarıMamülGrup;
            this.FormShow = new ShowEditForms<YarıMamülGrupEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Yarı Mamül Grup Kartları ";
            Tablo.ViewCaption = Text;

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = Bll.ToBll<YarıMamülGrupBll>().List(null);
        }
    }
}