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
using Zenix.Common.Enums;
using DevExpress.XtraBars.Ribbon;
using Zenix.WinUI.Show.Interfaces;
using DevExpress.Utils.Extensions;
using Zenix.WinUI.myUserControls.Controls;
using Zenix.BLL.Interfaces;
using Zenix.Model.Entities.Base;
using Zenix.WinUI.Functions;
using DevExpress.Utils.Drawing.Helpers;
using Zenix.Common.Messages;
using System.Collections;
using DevExpress.XtraBars;
using Zenix.WinUI.myUserControls.Grid;
using Zenix.WinUI.Interfaces;
using Zenix.Model.Entities.Base.Interfaces;
using DevExpress.XtraLayout;

namespace Zenix.WinUI.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        bool FormSablonKayitEdilecek;
        protected myDataLayoutControl DataLayoutControl;
        protected myDataLayoutControl[] DataLayoutControls;
        protected IBaseBLL Bll;
        protected KartTuru KartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool isLoaded;
        protected bool KayitsonrasiFormuKapat = true;
        protected internal BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected internal IslemTuru BaseIslemTuru;
        protected internal long Id;
        protected internal bool RefreshYapilacak;
        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected void EventsLoad()
        {
            //button events
            ribbonControl.Items.ForEach(btn =>
            {
                btn.ItemClick += (sender, e) =>
                {
                    if (e.Item == btnYeni)
                    {
                        if (!KartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir )) return ;

                        BaseIslemTuru = IslemTuru.EntityInsert;
                        Yukle();
                    }
                    else if (e.Item == btnKaydet)
                        Kaydet(false);
                    else if (e.Item == btnFarkliKaydet)
                    {
                        if (!KartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir )) return;
                        FarkliKaydet();

                    }
                    else if (e.Item == btnGeriAl)
                        GeriAl();
                    else if (e.Item == btnSil)
                    {
                        if (!KartTuru.YetkiKontrolu(YetkiTuru.Silebilir )) return;

                        EntityDelete();
                    }
                    else if (e.Item == btnSmsGonder )
                        SmsGönder();
                    else if (e.Item == btnUygula)
                        FiltreUygula();
                    else if (e.Item == btnYazdir)
                        Yazdir();
                    else if (e.Item == btnBaskiOnizleme)
                        BaskiOnizleme();
                    else if (e.Item == btnŞifreSıfırla)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        ŞifreSıfırla();
                        Cursor.Current = Cursors.Default ;
                    }
                    else if (e.Item == btnCikis)
                        Close();


                };
            });
            //Forms Events
            this.Load += (sender, e) =>
             {
                 isLoaded = true;
                 GuncelNesneOluştur();
                 SablonYukle();
                 ButtonGizleGoster();
                 Id = BaseIslemTuru.IdOlustur(OldEntity);

             };
            this.LocationChanged += (sender, e) => FormSablonKayitEdilecek = true;
            this.SizeChanged += (sender, e) => FormSablonKayitEdilecek = true;

            this.FormClosing += BaseEditForm_FormClosing;
            ;

            void ControlEvents(Control control)
            {
                control.KeyDown += (sender, e) =>
                {
                    if (e.KeyCode == Keys.Escape) Close();
                    if (sender is myButtonEdit edt)
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.Delete when e.Control && e.Shift:
                                edt.Id = null;
                                edt.EditValue = null;
                                break;
                            case Keys.Delete:
                                edt.Id = null;
                                edt.EditValue = null;
                                break;
                            case Keys.F4:
                            case Keys.Down when e.Modifiers == Keys.Alt:
                                SeçimYap(edt);
                                break;
                        }
                    }

                };
                control.GotFocus += (sender, e) =>
                {
                    var type = sender.GetType();
                    if (
                        type == typeof(myButtonEdit) ||
                        type == typeof(myGridview) ||
                        type == typeof(myComboBoxEdit) ||
                        type == typeof(myDateEdit) ||
                        type == typeof(myCalcEdit)
                        )
                    {
                        statusbarKisayol.Visibility = BarItemVisibility.Always;
                        statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

                        statusbarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
                        statusbarKisayol.Caption = ((IStatusBarKisayol)sender).StatusBarKisayol;
                        statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;
                    }
                    else if (sender is IStatusBarAciklama ctr)
                    {
                        statusbarAciklama.Caption = ctr.StatusBarAciklama;

                    }
                };
                control.Leave += (sender, e) =>
                {
                    statusbarKisayol.Visibility = BarItemVisibility.Never;
                    statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;

                };


                switch (control)
                {
                    case FilterControl edt:
                        edt.FilterChanged += EditValueChanged;
                        break;
                    case ComboBoxEdit edt:
                        edt.EditValueChanged += EditValueChanged;
                        edt.SelectedValueChanged += Control_SelectedValueChanged;
                        break;
                    case myButtonEdit edt:
                        edt.IdChanged += EditValueChanged;
                        edt.EnabledChange += Control_EnabledChange;
                        edt.ButtonClick += (sender, e) =>
                        {
                            SeçimYap(sender);
                        };
                        edt.DoubleClick += (sender, e) =>
                        {
                            SeçimYap(sender);
                        };

                        break;
                    case BaseEdit edt:
                        edt.EditValueChanged += EditValueChanged;
                        break;

                }
            }


            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;
                foreach (Control control in DataLayoutControl.Controls)
                    ControlEvents(control);
            }
            else
                foreach (var control in DataLayoutControls)
                    foreach (Control ctr in control.Controls)
                        ControlEvents(ctr);



        }


        protected virtual void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            {

                SablonKaydet();
                if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;
                if (!Kaydet(true))
                    e.Cancel = true;
            }
        }

        protected virtual void EditValueChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            GuncelNesneOluştur();
        }
        protected virtual void ŞifreSıfırla() { }
        protected virtual void SmsGönder() { }


        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }
        protected virtual void Control_EnabledChange(object sender, EventArgs e) { }

        protected virtual void TabloYükle() { }
        private void SablonYukle()
        {
            Name.FormSablonYukle(this);
        }
        private void FarkliKaydet()
        {
            if (Msg.EvetSeciliEvetHayir("Bu Filitre Referans Alınarak Yeni Bir Filitre Oluşturulacaktır. Onaylıyor musunuz?", "Kayıt Onay") != DialogResult.Yes) return;
            BaseIslemTuru = IslemTuru.EntityInsert;
            Yukle();
            if (Kaydet(true))
                Close();
        }
        private void ButtonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }
        protected void LayoutGizleGoster(bool visible, params BaseLayoutItem[] param) 
        {
            param?.Where(x => x != null).ToList()
                .ForEach(x => x.Visibility = visible ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never);
        }
        private void EntityDelete()
        {
            if (!((IBaseCommonBLL)Bll).Delete(OldEntity)) return;
            RefreshYapilacak = true;
            Close();
        }
        private void GeriAl()
        {
            if (Msg.HayirSeciliEvetHayir("Yapılan Değişiklikler Geri Alınacaktır. Onaylıyor musunuz?", "Geri AL Onay") != DialogResult.Yes) return;
            if (BaseIslemTuru == IslemTuru.EntityUpdate)
                Yukle();
            else
                Close();

        }
        protected virtual  bool Kaydet(bool kapanis)
        {

            bool KayıtIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (BaseIslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                            return KayıtSonrasiIslemler();
                        break;
                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                            return KayıtSonrasiIslemler();
                        break;

                }
                bool KayıtSonrasiIslemler()
                {
                    OldEntity = CurrentEntity;
                    RefreshYapilacak = true;
                    ButtonEnableDurumu();
                    if (KayitsonrasiFormuKapat)
                        Close();
                    else
                        BaseIslemTuru = BaseIslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;

                    return true;
                }
                return false;
            }
            var result = kapanis ? Msg.KapanisMesajVer() : Msg.KayıtMesaj();
            switch (result)
            {
                case DialogResult.Yes:
                    return KayıtIslemi();
                case DialogResult.No:
                    if (kapanis)
                        btnKaydet.Enabled = false;
                    return true;
                case DialogResult.Cancel:
                    return false;
            }
            return false;

        }
        protected void SablonKaydet()
        {
            if (FormSablonKayitEdilecek)
                this.Name.FormSablonKaydet(new FileFunctions.FormSettings
                {
                    Left = this.Left,
                    Height = this.Height,
                    Top = this.Top,
                    Width = this.Width,
                    State = this.WindowState,
                });
        }
        protected virtual void FiltreUygula() { }
        protected virtual void BaskiOnizleme() { }
        protected virtual void Yazdir() { }
        protected virtual void SeçimYap(object sender) { }
        protected virtual void NesneyiKontrollereBagla() { }
        protected virtual void GuncelNesneOluştur() { }
        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)Bll).Update(OldEntity, CurrentEntity);
        }
        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)Bll).Insert(CurrentEntity);
        }
        protected internal virtual void Yukle() { }
        protected internal virtual IBaseEntity ReturnEntity() { return null; }
        protected internal virtual void ButtonEnableDurumu()
        {
            if (!isLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGeriAl, btnSil, OldEntity, CurrentEntity);
        }


    }

}