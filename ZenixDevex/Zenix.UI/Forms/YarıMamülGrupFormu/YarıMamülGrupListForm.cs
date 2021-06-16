using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.WinUI.Show;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using Zenix.BLL.Functions;
using System.Linq;
using Zenix.Common.Messages;

namespace Zenix.WinUI.Forms.YarıMamülGrupFormu
{
    public partial class YarıMamülGrupListForm : BaseListForm
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
            var liste = Bll.ToBll<YarıMamülGrupBll>().List(x => !ListeDışıBırakılıcakKayıtlar.Contains(x.Id));
            Tablo.GridControl.DataSource = liste;
            if (!isMultiSelect) return;
            if (liste.Any())
                EkelenebilecekEntityVar = true;
            else
                Msg.UyariMesajı("İşlem Yapılabilecek Kart Bulunamadı");
        }
    }
}