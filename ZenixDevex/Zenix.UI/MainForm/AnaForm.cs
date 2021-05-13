using DevExpress.XtraBars;
using DevExpress.Utils.Extensions;
using Zenix.WinUI.Show;
using Zenix.Common.Enums;
using Zenix.Model.Entities;
using Zenix.Data.Context;
using DevExpress.XtraTabbedMdi;
using Zenix.WinUI.Forms.KullanıcıForms;
using Zenix.Common.Function;
using Zenix.WinUI.Functions;
using System;
using System.Linq;
using System.Windows.Forms;
using Zenix.Common.Messages;
using Zenix.BLL.General;
using System.Collections.Generic;
using Zenix.Model.DTO;

using System.Threading;
using Zenix.UI;
using Zenix.WinUI.Forms.FirmaFormu;
using Zenix.WinUI.Forms.ÜlkeFormu;
using Zenix.WinUI.Forms.SiparişFormu;
using Zenix.WinUI.Forms.ReçeteFormu;
using Zenix.WinUI.Forms.İşemriFormu;
using Zenix.WinUI.Forms.MamülFormu;
using Zenix.WinUI.Forms.AmbalajTipiFormu;
using Zenix.WinUI.Forms.MarkalarFormu;
using Zenix.WinUI.Forms.ÜrünlerFormu;
using Zenix.WinUI.Forms.SatınAlmaFormu;
using Zenix.WinUI.Forms.DepoFormu;
using Zenix.WinUI.Forms.ÜretimFormu;

namespace Zenix.WinUI.MainForm
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static Kullanici Kullanıcı { get; set; }
        public static string KullanıcıAdıSoyadı { get => $"{Kullanıcı?.Adı} {Kullanıcı?.Soyadı}"; }

        BarItem[] showitems, hideitems, disableitemsisexcludemachine, hideitemsisexcludemachine;
        void ButtonGizleGoster()
        {
            disableitemsisexcludemachine?.ForEach(x => x.Enabled = HWIDEngine.isExcludeMachine);
            hideitemsisexcludemachine?.ForEach(x => x.Visibility = HWIDEngine.isExcludeMachine ? BarItemVisibility.Always : BarItemVisibility.Never);
            hideitems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
            showitems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            var KullanıcıGörebilir = KartTuru.Kullanıcı.YetkiKontrolu(YetkiTuru.Gorebilir, false);  //Kullanıcı.isGörebilir(x => x.KartTuru == KartTuru.Kullanıcı);
            btnKullanıcı.Visibility = KullanıcıGörebilir ? BarItemVisibility.Always : BarItemVisibility.Never;
            btnRolKartları.Visibility = btnKullanıcı.Visibility;

        }
        public AnaForm()
        {
            InitializeComponent();
            //TODO :Test Kullanıcı
            if (!Kullanıcı.HasValue())
                Kullanıcı = Kullanıcı.GetKullanici(x => x.Adı == "admin");

            //baruserinfo.Caption = $"Hoşgeldin:{ Kullanıcı?.Adı.ToUpper()} {Kullanıcı?.Soyadı.ToUpper()}";
            barVers.Caption = $"Versiyon :{Program.DeplayVersion()}";
            lblDatasource.Caption = $"Database :{ZenixContext.ConBuilder.DataSource}";
            baruserinfo.Caption = Kullanıcı.Adı.Equals("admin") ? "HOŞGELDİN Admin" : $"HOŞGELDİN {Kullanıcı.Adı.ToUpper()} {Kullanıcı.Soyadı.ToUpper()}";
            disableitemsisexcludemachine = new BarItem[]
            {
                //btnRolKartları,
                //btnKullanıcı,
                //btnPoliSoft,
                //btnsmsgrupları,
                //btnsmsayarları,
                //btntoplusms,
            };
            hideitemsisexcludemachine = new BarItem[]
            {
                btnChangeKullanıcı
            };


            ButtonGizleGoster();
            EventLoad();

        }
        void EventLoad()
        {
            //buttons
            ribbon.Items.ForEach(item =>
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += (obj, e) =>
                        {
                            if (e.Item == btnRolKartları)
                                ShowListForms<RolListForm>.ShowListForm(KartTuru.Rol);
                            else if (e.Item == btnKullanıcı)
                                ShowListForms<KullanıcıListForm>.ShowListForm(KartTuru.Kullanıcı);
                            else if (e.Item == btnŞifreDeğiştir)
                                ShowEditForms<ŞifreDeğiştirEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate);
                            else if (e.Item == btnFirma)
                                ShowListForms<FirmaListFormu>.ShowListForm(KartTuru.Firma);
                            else if (e.Item == btnÜlkeler)
                                ShowListForms<ÜlkeListForm>.ShowListForm(KartTuru.Ülke);
                            else if (e.Item == btnSipariş)
                                ShowListForms<SiparişListForm>.ShowListForm(KartTuru.Sipariş);
                            else if (e.Item == btnMamüller)
                                ShowListForms<MamülListForm>.ShowListForm(KartTuru.Mamül);
                            else if (e.Item == btnReçete)
                                ShowListForms<ReçeteListForm>.ShowListForm(KartTuru.Reçete);
                            else if (e.Item == btnİşemri)
                                ShowListForms<İşemriListForm>.ShowListForm(KartTuru.İşemri);
                            else if (e.Item == btnAmbalajMaddeTipi)
                                ShowListForms<AmbalajMaddeTipiListForm>.ShowListForm(KartTuru.AmbalajMaddeTipi);
                            else if (e.Item == btnAmbalajTipi)
                                ShowListForms<AmbalajTipiListForm>.ShowListForm(KartTuru.AmbalajTipi);
                            else if (e.Item == btnMarkalar)
                                ShowListForms<MarkalarListForm>.ShowListForm(KartTuru.Markalar);
                            else if (e.Item == btnÜrün)
                                ShowListForms<ÜrünListForm>.ShowListForm(KartTuru.Ürün);
                            else if (e.Item == btnSatınAlma)
                                ShowListForms<SatınAlmaListForm>.ShowListForm(KartTuru.SatınAlma);
                            else if (e.Item == btnMalzemeDepo)
                                ShowListForms<MalzemeDepoListform>.ShowListForm(KartTuru.Depo);
                            else if (e.Item == btnÜretim)
                                ShowListForms<ÜretimListForm>.ShowListForm(KartTuru.Üretim );
                            else if (e.Item == btnÜrünDepo)
                                ShowListForms<ÜrünDepoListForm>.ShowListForm(KartTuru.Depo);

                        };
                        break;

                }
            });


            //form
            Shown += (sender, e) =>
            {
                //ShowListForms<FirmaListFormu>.ShowListForm(KayitTuru.Firma);

                //ShowListForms<EkDosyalarListForm>.ShowListForm(KartTuru.Ekdosyalar, (long)2020101119013144500, "araba1"," kadir aygün");
                Thread.Sleep(1000);
                btnMusteri.PerformClick();

            };
            xtraTabbedMdiManager.PageAdded += (sender, e) => { imgBackGround.SendToBack(); };
            xtraTabbedMdiManager.PageRemoved += (sender, e) =>
           {
               if (((XtraTabbedMdiManager)sender).Pages.Count == 0)
                   imgBackGround.BringToFront();
           };

        }


        void ChangeKullanıcı()
        {
            Kullanıcı = Kullanıcı.Change(x => x.Kod == (AnaForm.Kullanıcı.Kod.Contains("admin") ? "özlem" : "admin"));
            baruserinfo.Caption = $"Hoşgeldin:{ Kullanıcı?.Adı.ToUpper()} {Kullanıcı?.Soyadı.ToUpper()}";

            ButtonGizleGoster();

        }
    }
}