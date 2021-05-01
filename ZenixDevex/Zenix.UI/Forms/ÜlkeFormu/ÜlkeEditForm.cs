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

namespace Zenix.WinUI.Forms.ÜlkeFormu
{
    public partial class ÜlkeEditForm : BaseEditForm
    {
        readonly IBaseBLL bll;
        public ÜlkeEditForm()
        {
            InitializeComponent();
            this.DataLayoutControl = myDataLayoutControl;
            this.Bll = new ÜlkeBll(myDataLayoutControl);
        
            this.KartTuru =Common.Enums.KartTuru.Ülke;
            EventsLoad();
          
        }
        protected internal override void Yukle()
        {

            OldEntity = BaseIslemTuru == Common.Enums.IslemTuru.EntityInsert ? new Ülke() : ((ÜlkeBll)Bll).Single(FilterFunctions.Filter<Ülke>(Id));
            NesneyiKontrollereBagla();
            if (BaseIslemTuru != Common.Enums.IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ÜlkeBll)Bll).YeniKodVer();
            txtAdı.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Ülke)OldEntity;
            txtKod.Text = entity.Kod;
            txtAdı.Text = entity.Adı;
            
        }
        protected override void GuncelNesneOluştur()
        {

            CurrentEntity = new Ülke
            {
                Id = Id,
                Kod = txtKod.Text,
                Adı = txtAdı.Text,                
            };
            ButtonEnableDurumu();
        }
    }
}