namespace Zenix.WinUI.MainForm
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMusteri = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasaTanımı = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.barVers = new DevExpress.XtraBars.BarStaticItem();
            this.baruserinfo = new DevExpress.XtraBars.BarStaticItem();
            this.lblDatasource = new DevExpress.XtraBars.BarStaticItem();
            this.btnRolKartları = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullanıcı = new DevExpress.XtraBars.BarButtonItem();
            this.btntoplusms = new DevExpress.XtraBars.BarButtonItem();
            this.btnsmsgrupları = new DevExpress.XtraBars.BarButtonItem();
            this.btnPoliSoft = new DevExpress.XtraBars.BarButtonItem();
            this.btnSigortaŞirketleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnSigortaTürü = new DevExpress.XtraBars.BarButtonItem();
            this.btnSigortalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangeKullanıcı = new DevExpress.XtraBars.BarButtonItem();
            this.btnŞifreler = new DevExpress.XtraBars.BarButtonItem();
            this.btnŞifreDeğiştir = new DevExpress.XtraBars.BarButtonItem();
            this.btnSmsŞablon = new DevExpress.XtraBars.BarButtonItem();
            this.btnTümKrediKartları = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirma = new DevExpress.XtraBars.BarButtonItem();
            this.btnÜlkeler = new DevExpress.XtraBars.BarButtonItem();
            this.btnSipariş = new DevExpress.XtraBars.BarButtonItem();
            this.btnMamüller = new DevExpress.XtraBars.BarButtonItem();
            this.btnReçete = new DevExpress.XtraBars.BarButtonItem();
            this.btnKazan = new DevExpress.XtraBars.BarButtonItem();
            this.btnİşemri = new DevExpress.XtraBars.BarButtonItem();
            this.btnAmbalajTipi = new DevExpress.XtraBars.BarButtonItem();
            this.btnAmbalajMaddeTipi = new DevExpress.XtraBars.BarButtonItem();
            this.btnMarkalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnÜrün = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonYönetim = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.riibontanımlamalar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonMüş = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonKullanıcı = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.imgBackGround = new DevExpress.XtraEditors.PictureEdit();
            this.btnSatınAlma = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackGround.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnMusteri,
            this.btnKasaTanımı,
            this.btnKasa,
            this.barVers,
            this.baruserinfo,
            this.lblDatasource,
            this.btnRolKartları,
            this.btnKullanıcı,
            this.btntoplusms,
            this.btnsmsgrupları,
            this.btnPoliSoft,
            this.btnSigortaŞirketleri,
            this.btnSigortaTürü,
            this.btnSigortalar,
            this.btnChangeKullanıcı,
            this.btnŞifreler,
            this.btnŞifreDeğiştir,
            this.btnSmsŞablon,
            this.btnTümKrediKartları,
            this.btnFirma,
            this.btnÜlkeler,
            this.btnSipariş,
            this.btnMamüller,
            this.btnReçete,
            this.btnKazan,
            this.btnİşemri,
            this.btnAmbalajTipi,
            this.btnAmbalajMaddeTipi,
            this.btnMarkalar,
            this.btnÜrün,
            this.btnSatınAlma});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 46;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsAnimation.PageCategoryShowAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.OptionsPageCategories.ShowCaptions = false;
            this.ribbon.OptionsTouch.ShowTouchUISelectorInSearchMenu = false;
            this.ribbon.PageAnimationLength = 100;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonMüş});
            this.ribbon.QuickToolbarItemLinks.Add(this.baruserinfo);
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1020, 185);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Below;
            // 
            // btnMusteri
            // 
            this.btnMusteri.Caption = "Müşteri Kartları";
            this.btnMusteri.Id = 12;
            this.btnMusteri.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.customers_16x16;
            this.btnMusteri.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.customers_32x32;
            this.btnMusteri.Name = "btnMusteri";
            // 
            // btnKasaTanımı
            // 
            this.btnKasaTanımı.Caption = "Kasa Tanım Kartları";
            this.btnKasaTanımı.Id = 13;
            this.btnKasaTanımı.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.groupfieldcollection_16x16;
            this.btnKasaTanımı.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.groupfieldcollection_32x32;
            this.btnKasaTanımı.Name = "btnKasaTanımı";
            // 
            // btnKasa
            // 
            this.btnKasa.Caption = "Kasa Kartları";
            this.btnKasa.Id = 14;
            this.btnKasa.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.costanalysis_16x16;
            this.btnKasa.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.costanalysis_32x32;
            this.btnKasa.Name = "btnKasa";
            // 
            // barVers
            // 
            this.barVers.Caption = "Versiyon :";
            this.barVers.Id = 15;
            this.barVers.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barVers.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon;
            this.barVers.ItemAppearance.Normal.Options.UseFont = true;
            this.barVers.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barVers.Name = "barVers";
            // 
            // baruserinfo
            // 
            this.baruserinfo.Caption = "Userinfo";
            this.baruserinfo.Id = 17;
            this.baruserinfo.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.user_16x16;
            this.baruserinfo.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.user_32x32;
            this.baruserinfo.Name = "baruserinfo";
            this.baruserinfo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // lblDatasource
            // 
            this.lblDatasource.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblDatasource.Caption = "Database:";
            this.lblDatasource.Id = 18;
            this.lblDatasource.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDatasource.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon;
            this.lblDatasource.ItemAppearance.Normal.Options.UseFont = true;
            this.lblDatasource.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblDatasource.Name = "lblDatasource";
            // 
            // btnRolKartları
            // 
            this.btnRolKartları.Caption = "Rol Kartları";
            this.btnRolKartları.Id = 19;
            this.btnRolKartları.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.Monarch_16px;
            this.btnRolKartları.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.Monarch_32px;
            this.btnRolKartları.Name = "btnRolKartları";
            // 
            // btnKullanıcı
            // 
            this.btnKullanıcı.Caption = "Kullanıcı Kartları";
            this.btnKullanıcı.Id = 20;
            this.btnKullanıcı.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.usergroup_16x162;
            this.btnKullanıcı.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.usergroup_32x322;
            this.btnKullanıcı.Name = "btnKullanıcı";
            // 
            // btntoplusms
            // 
            this.btntoplusms.Caption = "Toplu Sms Gönder";
            this.btntoplusms.Id = 22;
            this.btntoplusms.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.topic_moved_16px;
            this.btntoplusms.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.topic_moved_32px;
            this.btntoplusms.Name = "btntoplusms";
            // 
            // btnsmsgrupları
            // 
            this.btnsmsgrupları.Caption = "Sms Grupları";
            this.btnsmsgrupları.Id = 23;
            this.btnsmsgrupları.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.collaboration_16px;
            this.btnsmsgrupları.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.collaboration_32px;
            this.btnsmsgrupları.Name = "btnsmsgrupları";
            // 
            // btnPoliSoft
            // 
            this.btnPoliSoft.Caption = "Polisoft";
            this.btnPoliSoft.Id = 24;
            this.btnPoliSoft.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.polisoftx16;
            this.btnPoliSoft.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.polisoftx32;
            this.btnPoliSoft.Name = "btnPoliSoft";
            // 
            // btnSigortaŞirketleri
            // 
            this.btnSigortaŞirketleri.Caption = "Sigorta Şirketleri";
            this.btnSigortaŞirketleri.Id = 25;
            this.btnSigortaŞirketleri.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.skyscrapers_16px;
            this.btnSigortaŞirketleri.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.skyscrapers_32px;
            this.btnSigortaŞirketleri.Name = "btnSigortaŞirketleri";
            // 
            // btnSigortaTürü
            // 
            this.btnSigortaTürü.Caption = "Sigorta Türleri";
            this.btnSigortaTürü.Id = 26;
            this.btnSigortaTürü.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.car_insurance_16px;
            this.btnSigortaTürü.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.car_insurance_32px;
            this.btnSigortaTürü.Name = "btnSigortaTürü";
            // 
            // btnSigortalar
            // 
            this.btnSigortalar.Caption = "Tüm Sigortalar";
            this.btnSigortalar.Id = 28;
            this.btnSigortalar.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.combo_chart_16px;
            this.btnSigortalar.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.combo_chart_32px;
            this.btnSigortalar.Name = "btnSigortalar";
            // 
            // btnChangeKullanıcı
            // 
            this.btnChangeKullanıcı.Caption = "Change Kullanıcı";
            this.btnChangeKullanıcı.Id = 29;
            this.btnChangeKullanıcı.Name = "btnChangeKullanıcı";
            // 
            // btnŞifreler
            // 
            this.btnŞifreler.Caption = "Şifreler";
            this.btnŞifreler.Id = 30;
            this.btnŞifreler.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.show_password_16px;
            this.btnŞifreler.Name = "btnŞifreler";
            // 
            // btnŞifreDeğiştir
            // 
            this.btnŞifreDeğiştir.Caption = "Şifre Değiştir";
            this.btnŞifreDeğiştir.Id = 31;
            this.btnŞifreDeğiştir.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.editcontact_16x16;
            this.btnŞifreDeğiştir.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.editcontact_32x32;
            this.btnŞifreDeğiştir.Name = "btnŞifreDeğiştir";
            // 
            // btnSmsŞablon
            // 
            this.btnSmsŞablon.Caption = "Sms Şablon Kartları";
            this.btnSmsŞablon.Id = 32;
            this.btnSmsŞablon.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.smsşablon16;
            this.btnSmsŞablon.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.smsşablon32;
            this.btnSmsŞablon.Name = "btnSmsŞablon";
            // 
            // btnTümKrediKartları
            // 
            this.btnTümKrediKartları.Caption = "Tüm Kredi Kartları";
            this.btnTümKrediKartları.Id = 33;
            this.btnTümKrediKartları.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.mastercard_credit_card_40px;
            this.btnTümKrediKartları.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.mastercard_credit_card_40px;
            this.btnTümKrediKartları.Name = "btnTümKrediKartları";
            // 
            // btnFirma
            // 
            this.btnFirma.Caption = "Firmalar";
            this.btnFirma.Id = 34;
            this.btnFirma.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.manufacturing_16px;
            this.btnFirma.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.manufacturing_32px;
            this.btnFirma.Name = "btnFirma";
            // 
            // btnÜlkeler
            // 
            this.btnÜlkeler.Caption = "Ülkeler";
            this.btnÜlkeler.Id = 35;
            this.btnÜlkeler.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.countries_16x;
            this.btnÜlkeler.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.countries_32x1;
            this.btnÜlkeler.Name = "btnÜlkeler";
            // 
            // btnSipariş
            // 
            this.btnSipariş.Caption = "Siparişler";
            this.btnSipariş.Id = 36;
            this.btnSipariş.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.salesanalysis_16x16;
            this.btnSipariş.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.salesanalysis_32x32;
            this.btnSipariş.Name = "btnSipariş";
            // 
            // btnMamüller
            // 
            this.btnMamüller.Caption = "Malzemeler";
            this.btnMamüller.Id = 37;
            this.btnMamüller.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.commodity_16px;
            this.btnMamüller.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.commodity_32px;
            this.btnMamüller.Name = "btnMamüller";
            // 
            // btnReçete
            // 
            this.btnReçete.Caption = "Reçeteler";
            this.btnReçete.Id = 38;
            this.btnReçete.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.syringe_16px;
            this.btnReçete.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.syringe_32px;
            this.btnReçete.Name = "btnReçete";
            // 
            // btnKazan
            // 
            this.btnKazan.Caption = "Kazan Kartları";
            this.btnKazan.Id = 39;
            this.btnKazan.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.whisky_still_16px;
            this.btnKazan.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.whisky_still_32px;
            this.btnKazan.Name = "btnKazan";
            // 
            // btnİşemri
            // 
            this.btnİşemri.Caption = "İş Emirleri";
            this.btnİşemri.Id = 40;
            this.btnİşemri.ImageOptions.DisabledImage = global::Zenix.WinUI.Properties.Resources.work_16px;
            this.btnİşemri.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.work_32px;
            this.btnİşemri.Name = "btnİşemri";
            // 
            // btnAmbalajTipi
            // 
            this.btnAmbalajTipi.Caption = "Ambalaj Tipleri";
            this.btnAmbalajTipi.Id = 41;
            this.btnAmbalajTipi.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.box_settings_16px;
            this.btnAmbalajTipi.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.box_settings_32px;
            this.btnAmbalajTipi.Name = "btnAmbalajTipi";
            // 
            // btnAmbalajMaddeTipi
            // 
            this.btnAmbalajMaddeTipi.Caption = "Ambalaj Maddeleri";
            this.btnAmbalajMaddeTipi.Id = 42;
            this.btnAmbalajMaddeTipi.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.layers_16px;
            this.btnAmbalajMaddeTipi.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.layers_32px;
            this.btnAmbalajMaddeTipi.Name = "btnAmbalajMaddeTipi";
            // 
            // btnMarkalar
            // 
            this.btnMarkalar.Caption = "Markalar";
            this.btnMarkalar.Id = 43;
            this.btnMarkalar.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.icons8_gg_16px;
            this.btnMarkalar.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.gg_32px_3;
            this.btnMarkalar.Name = "btnMarkalar";
            // 
            // btnÜrün
            // 
            this.btnÜrün.Caption = "Ürünler";
            this.btnÜrün.Id = 44;
            this.btnÜrün.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.handle_with_care_16px;
            this.btnÜrün.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.handle_with_care_32px;
            this.btnÜrün.Name = "btnÜrün";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonYönetim,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Yönetim";
            // 
            // ribbonYönetim
            // 
            this.ribbonYönetim.ItemLinks.Add(this.btnİşemri);
            this.ribbonYönetim.ItemLinks.Add(this.btnFirma);
            this.ribbonYönetim.ItemLinks.Add(this.btnSipariş);
            this.ribbonYönetim.ItemLinks.Add(this.btnMamüller);
            this.ribbonYönetim.ItemLinks.Add(this.btnReçete);
            this.ribbonYönetim.ItemLinks.Add(this.btnÜrün);
            this.ribbonYönetim.ItemLinks.Add(this.btnSatınAlma);
            this.ribbonYönetim.Name = "ribbonYönetim";
            this.ribbonYönetim.Text = "Yönetim";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnÜlkeler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKazan);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.riibontanımlamalar});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tanımlamalar";
            // 
            // riibontanımlamalar
            // 
            this.riibontanımlamalar.ItemLinks.Add(this.btnFirma, true);
            this.riibontanımlamalar.ItemLinks.Add(this.btnMarkalar);
            this.riibontanımlamalar.ItemLinks.Add(this.btnAmbalajTipi);
            this.riibontanımlamalar.ItemLinks.Add(this.btnAmbalajMaddeTipi);
            this.riibontanımlamalar.ItemLinks.Add(this.btnMamüller);
            this.riibontanımlamalar.ItemLinks.Add(this.btnÜlkeler);
            this.riibontanımlamalar.ItemLinks.Add(this.btnKazan);
            this.riibontanımlamalar.Name = "riibontanımlamalar";
            // 
            // ribbonMüş
            // 
            this.ribbonMüş.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonKullanıcı});
            this.ribbonMüş.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.newitem_16x161;
            this.ribbonMüş.Name = "ribbonMüş";
            this.ribbonMüş.Text = "Kullanıcı Ayarları";
            // 
            // ribbonKullanıcı
            // 
            this.ribbonKullanıcı.ItemLinks.Add(this.btnRolKartları);
            this.ribbonKullanıcı.ItemLinks.Add(this.btnKullanıcı);
            this.ribbonKullanıcı.ItemLinks.Add(this.btnŞifreDeğiştir);
            this.ribbonKullanıcı.Name = "ribbonKullanıcı";
            this.ribbonKullanıcı.Text = "Kullanıcı Ayarları";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barVers);
            this.ribbonStatusBar.ItemLinks.Add(this.lblDatasource);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 664);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1020, 24);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // imgBackGround
            // 
            this.imgBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBackGround.EditValue = global::Zenix.WinUI.Properties.Resources.back;
            this.imgBackGround.Location = new System.Drawing.Point(0, 185);
            this.imgBackGround.MenuManager = this.ribbon;
            this.imgBackGround.Name = "imgBackGround";
            this.imgBackGround.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgBackGround.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imgBackGround.Size = new System.Drawing.Size(1020, 479);
            this.imgBackGround.TabIndex = 7;
            // 
            // btnSatınAlma
            // 
            this.btnSatınAlma.Caption = "Satın Alma";
            this.btnSatınAlma.Id = 45;
            this.btnSatınAlma.ImageOptions.Image = global::Zenix.WinUI.Properties.Resources.buy_16x16;
            this.btnSatınAlma.ImageOptions.LargeImage = global::Zenix.WinUI.Properties.Resources.buy_32x32;
            this.btnSatınAlma.Name = "btnSatınAlma";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 688);
            this.Controls.Add(this.imgBackGround);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("AnaForm.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Tag = "";
            this.Text = "Zenix Solution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackGround.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonMüş;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarButtonItem btnMusteri;
        private DevExpress.XtraBars.BarButtonItem btnKasaTanımı;
        private DevExpress.XtraBars.BarButtonItem btnKasa;
        private DevExpress.XtraBars.BarStaticItem barVers;
        private DevExpress.XtraBars.BarStaticItem baruserinfo;
        private DevExpress.XtraBars.BarStaticItem lblDatasource;
        private DevExpress.XtraEditors.PictureEdit imgBackGround;
        private DevExpress.XtraBars.BarButtonItem btnRolKartları;
        private DevExpress.XtraBars.BarButtonItem btnKullanıcı;
        private DevExpress.XtraBars.BarButtonItem btntoplusms;
        private DevExpress.XtraBars.BarButtonItem btnsmsgrupları;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonKullanıcı;
        private DevExpress.XtraBars.BarButtonItem btnPoliSoft;
        private DevExpress.XtraBars.BarButtonItem btnSigortaŞirketleri;
        private DevExpress.XtraBars.BarButtonItem btnSigortaTürü;
        private DevExpress.XtraBars.BarButtonItem btnSigortalar;
        private DevExpress.XtraBars.BarButtonItem btnChangeKullanıcı;
        private DevExpress.XtraBars.BarButtonItem btnŞifreler;
        private DevExpress.XtraBars.BarButtonItem btnŞifreDeğiştir;
        private DevExpress.XtraBars.BarButtonItem btnSmsŞablon;
        private DevExpress.XtraBars.BarButtonItem btnTümKrediKartları;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonYönetim;
        private DevExpress.XtraBars.BarButtonItem btnFirma;
        private DevExpress.XtraBars.BarButtonItem btnÜlkeler;
        private DevExpress.XtraBars.BarButtonItem btnSipariş;
        private DevExpress.XtraBars.BarButtonItem btnMamüller;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnReçete;
        private DevExpress.XtraBars.BarButtonItem btnKazan;
        private DevExpress.XtraBars.BarButtonItem btnİşemri;
        private DevExpress.XtraBars.BarButtonItem btnAmbalajTipi;
        private DevExpress.XtraBars.BarButtonItem btnAmbalajMaddeTipi;
        private DevExpress.XtraBars.BarButtonItem btnMarkalar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup riibontanımlamalar;
        private DevExpress.XtraBars.BarButtonItem btnÜrün;
        private DevExpress.XtraBars.BarButtonItem btnSatınAlma;
    }
}