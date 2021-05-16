using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Zenix.WinUI.Forms.BaseForms;
using Zenix.BLL.General;
using Zenix.WinUI.Show;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities;
using DevExpress.XtraBars;
using Zenix.WinUI.myUserControls.Grid;
using System.Linq;
using Zenix.Common.Function;
using DevExpress.XtraGrid.Views.Grid;
using Zenix.WinUI.MainForm;
using Zenix.Common.Messages;
using System.Linq.Expressions;
using Zenix.Model.Entities.Base;

namespace Zenix.WinUI.Forms.MamülFormu
{
    public partial class MamülListForm : BaseListForm

    {
        Expression<Func<Mamül, bool>> Filter;
        bool isÜrün { get; }

        public MamülListForm(bool isürün)
        {
            InitializeComponent();
            Bll = new MamülBll();
            isÜrün = isürün;
        }

        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Mamül;
            //this.FormShow = new ShowEditForms<MamülEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Mamül Kartları ";
            Tablo.ViewCaption = Text;

        }
        protected override void Listele()
        {
            IEnumerable<BaseEntity> liste = null;
            if (isÜrün)
                liste = ((MamülBll)Bll).List(x => x.Durum && x.MalzemeTipi == Common.Enums.MalzemeTipi.Ürün);
            else
                liste = ((MamülBll)Bll).List(x => x.Durum && x.MalzemeTipi != Common.Enums.MalzemeTipi.Ürün);

            Tablo.GridControl.DataSource = liste;
            if (!isMultiSelect) return;
            if (liste.Any())
                EkelenebilecekEntityVar = true;
            else
                Msg.UyariMesajı("İşlem Yapılabilecek Kart Bulunamadı");
        }
        protected override void ShowEditForm(long id)
        {

            var result = new ShowEditForms<MamülEditForm>().ShowDialogEditForm(Common.Enums.KartTuru.Mamül, id, isÜrün);
            ShowEditFormDefault(result);
        }
    }
}