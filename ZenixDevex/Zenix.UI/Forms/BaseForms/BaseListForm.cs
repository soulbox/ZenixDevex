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
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using Zenix.WinUI.Show.Interfaces;
using Zenix.Common.Enums;
using DevExpress.XtraGrid.Views.Grid;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities.Base;
using DevExpress.XtraBars.Ribbon;
using Zenix.BLL.Interfaces;
using Zenix.WinUI.Show;
using Zenix.WinUI.Forms.FiltreFormu;
using Zenix.Model.Entities;
using Zenix.Model.Entities.Base.Interfaces;
using Zenix.Common.Messages;

namespace Zenix.WinUI.Forms.BaseForms
{
    public partial class BaseListForm : RibbonForm
    {
        bool FormSablonKayitEdilecek;
        bool TablosablonKayitEdilicek;

        protected IBaseFormShow FormShow;
        protected KartTuru KartTuru;
        protected internal GridView tablo;
        protected internal bool AktifKayitlariGoster = true;
        protected internal bool AktifPasifButonGoster = false;
        protected internal bool isMultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected IBaseBLL Bll;
        protected ControlNavigator Navigator;
        protected internal long? SeciliGelecekId;
        protected internal long FiltreId;
        protected internal IList<long> ListeDışıBırakılıcakKayıtlar;
        protected internal SelectRowFunctions rowselect;
        protected internal bool EkelenebilecekEntityVar = false;
        protected internal IList<BaseEntity> SelectedEntities;
        protected internal bool iserror;
        protected internal BarItem[] ShowItems;
        protected BarItem[] HideItems;

        public BaseListForm()
        {

            InitializeComponent();



        }

        protected virtual void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogEditForm(this.KartTuru, id);
            ShowEditFormDefault(result);
        }
        protected void ShowEditFormDefault(long id)
        {
            if (id <= 0) return;
            AktifKayitlariGoster = true;
            FormCaptionAyarla();
            tablo.RowFocus("Id", id);

        }
        protected void ShowHideButtons(bool visible, params BarItem[] prm)
        {
            prm?.Where(x => x != null).ToList().ForEach(x => x.Visibility = visible ? BarItemVisibility.Always : BarItemVisibility.Never);
        }
        void EventLoad()
        {
            //Button Events
            ribbonControl.Items.ForEach(btn =>
            {
                btn.ItemClick += (sender, e) =>
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (e.Item == btnGonder)
                    {
                        var link = (BarSubItemLink)e.Item.Links[0];
                        link.Focus();
                        link.OpenMenu();
                        link.Item.ItemLinks[0].Focus();
                    }
                    else if (e.Item == btnExcelStandart)
                        tablo.TabloDisariAktar(DosyaTuru.ExcelStandart, e.Item.Caption, Text);
                    else if (e.Item == btnExcelFormatli)
                        tablo.TabloDisariAktar(DosyaTuru.ExcelFormatli, e.Item.Caption, Text);
                    else if (e.Item == btnExcelFormatsiz)
                        tablo.TabloDisariAktar(DosyaTuru.ExcelFormatsiz, e.Item.Caption);
                    else if (e.Item == btnWord)
                        tablo.TabloDisariAktar(DosyaTuru.Word, e.Item.Caption, Text);
                    else if (e.Item == btnPdf)
                        tablo.TabloDisariAktar(DosyaTuru.PDF, e.Item.Caption, Text);
                    else if (e.Item == btnTxtDosyası)
                        tablo.TabloDisariAktar(DosyaTuru.TXT, e.Item.Caption, Text);
                    else if (e.Item == btnYeni)
                    {
                        if (!KartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir)) return;
                        ShowEditForm(-1);
                    }
                    else if (e.Item == btnDüzelt)
                        ShowEditForm(tablo.GetRowId());
                    else if (e.Item == btnSil)
                    {
                        if (!KartTuru.YetkiKontrolu(YetkiTuru.Silebilir)) return;
                        EntityDelete();
                    }
                    else if (e.Item == btnSeç)
                        SelectEntity();
                    else if (e.Item == btnYenile)
                        Listele();
                    else if (e.Item == btnFiltrele)
                        FilitreSec();
                    else if (e.Item == btnKolonlar)
                    {
                        if (tablo.CustomizationForm == null)
                            tablo.ShowCustomization();

                        else
                            tablo.HideCustomization();
                    }
                    else if (e.Item == btnŞarz)
                        ŞarjAc();
                    else if (e.Item == btnPaketleme)
                        PaketlemeAc();
                    else if (e.Item == btnSigortaları)
                        SigortalarıAç();
                    else if (e.Item == btnBağlıKayıtları)
                        BağlıKayıtlarAc();
                    else if (e.Item == btnEkDosyalar)
                        EkDosyalarAc();
                    else if (e.Item == btnDosyaGrub)
                        DosyaGrubAc();
                    else if (e.Item == btnPolisoftExcel)
                        PolisoftExcelimport();
                    else if (e.Item == btnSmsGönder)
                        SmsGönder();
                    else if (e.Item == btnYazdır)
                        Yazdir();
                    else if (e.Item == btnCikis)
                        Close();
                    else if (e.Item == btnAktifPasifKartlar)
                    {
                        AktifKayitlariGoster = !AktifKayitlariGoster;
                        FormCaptionAyarla();
                    }

                    Cursor.Current = DefaultCursor;

                };
            });
            //Table Events
            tablo.DoubleClick += (sender, e) =>
            {
                Cursor.Current = Cursors.WaitCursor;
                islemTuruSec();
                Cursor.Current = DefaultCursor;

            };
            tablo.KeyDown += (sender, e) =>
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        islemTuruSec();
                        break;
                    case Keys.Escape:
                        Close();
                        break;
                }
            };
            tablo.MouseUp += (sender, e) =>
            {
                e.SagMenuGoster(sagMenu);
            };
            tablo.ColumnWidthChanged += (sender, e) => TablosablonKayitEdilicek = true;
            tablo.ColumnPositionChanged += (sender, e) => TablosablonKayitEdilicek = true;
            tablo.EndSorting += (sender, e) => TablosablonKayitEdilicek = true;
            //tablo.colum
            tablo.FilterEditorCreated += (sender, e) =>
            {
                if (!Common.Enums.KartTuru.Filtre.YetkiKontrolu(YetkiTuru.Değiştirebilir)) return;

                e.ShowFilterEditor = false;
                new ShowEditForms<FiltreEditForm>().ShowDialogEditForm(KartTuru.Filtre, FiltreId, KartTuru, tablo.GridControl);
            };
            tablo.ColumnFilterChanged += (sender, e) =>
            {
                if (string.IsNullOrEmpty(tablo.ActiveFilterString))
                    FiltreId = 0;
            };
            tablo.CustomDrawFooterCell += (sender, e) =>
            {
                if (!tablo.OptionsView.ShowFooter) return;
                if (e.Column.Summary.Count > 0)
                    e.Appearance.TextOptions.HAlignment = e.Column.ColumnEdit.Appearance.HAlignment;
            };
            tablo.Columns.ForEach(x =>
            {

            });
            //navigator
            Navigator.ButtonClick += (sender, e) =>
            {
                switch (e.Button.ButtonType)
                {
                    case NavigatorButtonType.Append:
                        ShowEditForm(-1);
                        break;
                    case NavigatorButtonType.Remove:
                        EntityDelete();
                        break;
                }

            };
            //Form Events

            this.Shown += (sender, e) =>
            {

                tablo.Focus();
                ButtonGizleGoster();
                SutunGizleGoster();

                if (IsMdiChild || !SeciliGelecekId.HasValue) return;
                tablo.RowFocus("Id", SeciliGelecekId);
            };
            this.Load += (sender, e) =>
            {
                //if (KartTuru == KartTuru.Kasa || KartTuru==KartTuru.Sigortalar)
                //{
                //    TablosablonKayitEdilicek = true;
                //    SablonKaydet();
                //    TablosablonKayitEdilicek = false;
                //}
                SablonYukle();

            };
            this.FormClosed += (sender, e) =>
            {
                SablonKaydet();
            };
            this.LocationChanged += (sender, e) => FormSablonKayitEdilecek = true;
            this.SizeChanged += (sender, e) => FormSablonKayitEdilecek = true;

        }

        private void EntityDelete()
        {
            var entity = tablo.GetRow<BaseEntity>();
            if (entity == null) return;
            if (!((IBaseCommonBLL)Bll).Delete(entity)) return;
            tablo.DeleteSelectedRows();
            tablo.RowFocus(tablo.FocusedRowHandle);
        }
        protected virtual void SelectEntity()
        {
            if (isMultiSelect)
            {
                SelectedEntities = new List<BaseEntity>();
                if (rowselect.SelectedRowCount() == 0)
                {
                    Msg.KayıtSecmemeUyariMesajı();
                    return;
                }
                SelectedEntities = rowselect.GetSelectedRows();
            }
            else
                SelectedEntity = tablo.GetRow<BaseEntity>();

            DialogResult = DialogResult.OK;
            Close();
        }
        private void FilitreSec()
        {
            if (!Common.Enums.KartTuru.Filtre.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var entity = (Filtre)ShowListForms<FiltreListForm>.ShowDialogListForm(KartTuru.Filtre, FiltreId, this.KartTuru, tablo.GridControl);
            if (entity == null) return;
            FiltreId = entity.Id;
            tablo.ActiveFilterString = entity.FiltreMetni;
        }
        private void FormCaptionAyarla()
        {
            if (btnAktifPasifKartlar == null)
            {
                Listele();
                return;
            }
            if (AktifKayitlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                tablo.ViewCaption = Text;
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                tablo.ViewCaption = Text + " -Pasif Kartlar";
            }
            Listele();

        }
        private void islemTuruSec()
        {
            if (!IsMdiChild)
            {

                SelectEntity();
            }
            else
                btnDüzelt.PerformClick();
        }
        protected virtual void SutunGizleGoster() { }

        protected virtual void Listele() { }
        protected virtual void ŞarjAc() { }
        protected virtual void PaketlemeAc() { }
        protected virtual void BağlıKayıtlarAc() { }
        protected virtual void EkDosyalarAc() { }
        protected virtual void DosyaGrubAc() { }
        protected virtual void Degiskenleridoldur() { }
        protected virtual void SigortalarıAç() { }
        protected virtual void PolisoftExcelimport() { }
        protected virtual void SmsGönder() { }

        protected virtual void CihazlariAc(BarItem ıtem) { }
        protected virtual void Yazdir()
        {
            TablePrintingFunctions.Yazdir(tablo, tablo.ViewCaption, "");
        }

        protected internal void Yukle()
        {
            if (iserror) return;
            Degiskenleridoldur();
            tablo.OptionsSelection.MultiSelect = isMultiSelect;

            Navigator.NavigatableControl = tablo.GridControl;
            EventLoad();

            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;

        }

        private void ButtonGizleGoster()
        {

            btnSeç.Visibility = AktifPasifButonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnter.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnterAciklama.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            btnAktifPasifKartlar.Visibility = AktifPasifButonGoster ? BarItemVisibility.Always : IsMdiChild ? BarItemVisibility.Always : BarItemVisibility.Never;
            Navigator.Buttons.Append.Visible = false;
            Navigator.Buttons.Remove.Visible = false;
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);



        }
        void SablonKaydet()
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
            if (TablosablonKayitEdilicek)
                tablo.TabloSablonKaydet(IsMdiChild ? Name + " Tablosu" : Name + " Tablosu Mdi");

        }


        void SablonYukle()
        {
            if (IsMdiChild)
                tablo.TabloSablonYukle(Name + " Tablosu");
            else
            {
                Name.FormSablonYukle(this);
                tablo.TabloSablonYukle(Name + " Tablosu Mdi");

            }
        }


    }
}