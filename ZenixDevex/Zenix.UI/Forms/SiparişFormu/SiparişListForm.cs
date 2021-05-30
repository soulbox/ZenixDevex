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
using Zenix.WinUI.Show;
using Zenix.Model.DTO;
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using DevExpress.XtraGrid.Views.Base;

namespace Zenix.WinUI.Forms.SiparişFormu
{
    public partial class SiparişListForm : BaseListForm
    {
        public SiparişListForm()
        {
            InitializeComponent();
            Bll = new SiparişBll();

        }
        protected override void Degiskenleridoldur()
        {
            this.tablo = Tablo;
            this.KartTuru = Common.Enums.KartTuru.Sipariş;
            this.FormShow = new ShowEditForms<SiparişEditForm>();
            this.Navigator = longNavigator.controlNavigator;
            Text = "Sipariş Kartları ";
            Tablo.ViewCaption = Text;

        }
        protected override void SagMenuGoster(object sender, MouseEventArgs e)
        {
            var isRight = (e.Button == MouseButtons.Right);
            var entity = Tablo.GetRow<SiparişL>();
            ShowHideButtons(entity != null, btnYeniSiparişKullan);
            base.SagMenuGoster(sender, e);
        }
        protected override void YeniSiparişKullan()
        {
            var entity = Tablo.GetRow<SiparişL>();
            var clone = entity.Clone;
            var result = new ShowEditForms<SiparişEditForm>().ShowDialogEditForm(Common.Enums.KartTuru.Sipariş, clone.Id, clone);
            Listele();
            ShowEditFormDefault(result);

        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SiparişBll)Bll).List(FilterFunctions.Filter<Sipariş>(AktifKayitlariGoster));

        }
        protected override void Tablo_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var entity = tablo.GetRow<SiparişL>();
            if (entity == null) return;
            using (var siparişbll = new SiparişÜrünleriBll())
                SiparişTablo .GridControl.DataSource = siparişbll.List(x => x.SiparişId == entity.Id);
        }
    }
}