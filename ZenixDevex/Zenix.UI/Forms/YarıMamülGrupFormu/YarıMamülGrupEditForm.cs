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
using Zenix.Model.Entities;
using Zenix.WinUI.Functions;
using Zenix.BLL.Interfaces;
using Zenix.BLL.Functions;


namespace Zenix.WinUI.Forms.YarıMamülGrupFormu
{
    public partial class YarıMamülGrupEditForm : BaseEditForm
    {
        public YarıMamülGrupEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new YarıMamülGrupBll(myDataLayoutControl);

            this.KartTuru = Common.Enums.KartTuru.YarıMamülGrup;
            EventsLoad();
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new YarıMamülGrup () : ((YarıMamülGrupBll)Bll).Single(FilterFunctions.Filter<YarıMamülGrup>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((YarıMamülGrupBll)Bll).YeniKodVer();
            txtAdı.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (YarıMamülGrup)OldEntity;
            txtKod.Text = entity.Kod;
            txtAdı.Text = entity.YarıMamülAdı;

        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new YarıMamülGrup
            {
                Id = Id,
                Kod = txtKod.Text,
                YarıMamülAdı = txtAdı.Text,
            };
            ButtonEnableDurumu();
        }
    }
}