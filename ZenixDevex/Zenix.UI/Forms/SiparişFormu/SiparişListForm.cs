﻿using System;
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
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((SiparişBll)Bll).List(FilterFunctions.Filter<Sipariş>(AktifKayitlariGoster));

        }
    }
}