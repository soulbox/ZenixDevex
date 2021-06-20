using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using Zenix.Common.Messages;
using Zenix.WinUI.Functions;
using Zenix.Model.Entities.Base.Interfaces;
using Zenix.WinUI.Forms.BaseForms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Base;
using Zenix.WinUI.Interfaces;
using Zenix.BLL.Interfaces;
using Zenix.Model.Entities.Base;
using Zenix.WinUI.myUserControls.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using Zenix.WinUI.MainForm;

namespace Zenix.WinUI.myUserControls.UserControl.Base
{
    public partial class BaseTablo : XtraUserControl
    {
        bool isloaded;
        bool tablosablonkayitedilicek;
        protected internal GridView baseTablo;
        protected internal bool tablevaluechanged;
        protected internal BaseEditForm ownerform;
        protected internal BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected IList<long> ListeDışıtutulacakkayıtlar;
        protected internal IBaseBLL Bll;
        public BaseTablo()
        {
            InitializeComponent();
        }


        protected void EventsLoad()
        {

            //Buttons Events
            foreach (BarItem button in barManager.Items)
                button.ItemClick += Button_ItemClick;
            foreach (GridColumn col in baseTablo.Columns)
            {
                if (col.ColumnEdit == null) continue;
                var type = col.ColumnEdit.GetType();
                if (type == typeof(RepositoryItemCheckEdit))
                    ((RepositoryItemCheckEdit)col.ColumnEdit).CheckedChanged += CheckEdit_CheckedChanged;
                if (type == typeof(RepositoryItemImageComboBox))
                    ((RepositoryItemImageComboBox)col.ColumnEdit).SelectedValueChanged += ImageComboBox_SelectedValueChanged;
            }


            //Nav Events
            insUpdNavigator.Navigator.ButtonClick += Navigator_ButtonClick;
            //Table Events
            baseTablo.CellValueChanged += Tablo_CellValueChanged;
            baseTablo.MouseUp += Tablo_MouseUp;
            baseTablo.GotFocus += Tablo_GotFocus;
            baseTablo.LostFocus += Tablo_LostFocus;
            baseTablo.KeyDown += Tablo_KeyDown;
            baseTablo.FocusedColumnChanged += Tablo_FocusedColumnChanged;
            baseTablo.ColumnPositionChanged += Tablo_SablonChanged;
            baseTablo.ColumnWidthChanged += Tablo_SablonChanged;
            baseTablo.EndSorting += Tablo_SablonChanged;
            baseTablo.FocusedRowObjectChanged += Tablo_FocusedRowObjectChanged;
            baseTablo.CustomRowFilter += Tablo_CustomRowFilter;
        }

        private void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
        {
            GridView view = sender as GridView;
            bool isDeletes = (bool)view.GetListSourceRowCellValue(e.ListSourceRow, "Delete");
            e.Visible = !isDeletes;
            e.Handled = isDeletes;
        }

        private void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {

            SutunGizleGoster();
            RowCellAllowEdit();
        }

        protected virtual void ImageComboBox_SelectedValueChanged(object sender, EventArgs e) { }
        protected virtual void CheckEdit_CheckedChanged(object sender, EventArgs e) { }

        private void SablonYukle()
        {
            baseTablo.TabloSablonYukle(baseTablo.ViewCaption);
        }
        private void SablonKaydet()
        {
            if (tablosablonkayitedilicek)
                baseTablo.TabloSablonKaydet(baseTablo.ViewCaption);

        }
        private void ButtonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        protected internal virtual void Yukle()
        {
            isloaded = true;
            tablevaluechanged = false;
            ownerform?.ButtonEnableDurumu();
            insUpdNavigator.Navigator.NavigatableControl = baseTablo.GridControl;
            SablonYukle();
            Listele();
            Tablo_Column_listele();
            ButtonGizleGoster();
            Tablo_LostFocus(baseTablo, EventArgs.Empty);
        }
        public virtual void Tablo_Column_listele() { }

        protected internal virtual void Listele() { }


        protected virtual void HareketEkle() { }
        protected virtual void HareketSil()
        {
            if (baseTablo.DataRowCount == 0) return;
            if (Msg.SilMesajı("İşlem Satırı") != DialogResult.Yes) return;
            baseTablo.GetRow<IBaseHaraketEntity>().Delete = true;
            baseTablo.RefreshDataSource();
            ButtonEnableDurum(true);
        }
        protected internal virtual bool HatalıGiriş() { return false; }
        protected virtual void SutunGizleGoster() { }
        protected virtual void RowCellAllowEdit() { }
        protected virtual void TümSeçimleriKaldır() { }
        protected virtual void TümünüSeç() { }
        protected virtual void TümHaraketleriSil() { }

        protected virtual void ButtonEnableDurum(bool durum)
        {
            tablevaluechanged = durum;
            ownerform?.ButtonEnableDurumu();

        }

        protected internal bool Kaydet()
        {
            insUpdNavigator.Navigator.Buttons.DoClick(insUpdNavigator.Navigator.Buttons.EndEdit);
            var source = baseTablo.DataController.ListSource.Cast<IBaseHaraketEntity>().ToList();
            var insert = source.Where(x => x.Insert && !x.Delete).Cast<BaseEntityHaraket>().ToList();
            var update = source.Where(x => x.Update && !x.Delete).Cast<BaseEntityHaraket>().ToList();
            var delete = source.Where(x => x.Delete && !x.Insert).Cast<BaseEntityHaraket>().ToList();
            if (insert.Any())
                if (!((IBaseHareketGenelBLL)Bll).Insert(insert))
                {
                    Msg.HataMesajı($"{baseTablo.ViewCaption} Tablosundaki Haraketler Eklenemedi");
                    return false;
                }
            if (update.Any())
                if (!((IBaseHareketGenelBLL)Bll).Update(update))
                {
                    Msg.HataMesajı($"{baseTablo.ViewCaption} Tablosundaki Haraketler Güncellenemedi");
                    return false;

                }
            if (delete.Any())
                if (!((IBaseHareketGenelBLL)Bll).Delete(delete))
                {
                    Msg.HataMesajı($"{baseTablo.ViewCaption} Tablosundaki Haraketler Silinemedi.");
                    return false;

                }
            ButtonEnableDurum(false);



            return true;

        }
        protected virtual void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (ownerform == null) return;
            ownerform.statusbarKisayol.Visibility = BarItemVisibility.Never;
            ownerform.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
            if (!e.FocusedColumn.OptionsColumn.AllowEdit)
                Tablo_GotFocus(sender, EventArgs.Empty);
            else if (((IStatusBarKisayol)e.FocusedColumn).StatusBarKisayol != null)
            {
                ownerform.statusbarKisayol.Visibility = BarItemVisibility.Always;
                ownerform.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

                ownerform.statusbarAciklama.Caption = ((IStatusBarAciklama)e.FocusedColumn).StatusBarAciklama;
                ownerform.statusbarKisayol.Caption = ((IStatusBarKisayol)e.FocusedColumn).StatusBarKisayol;
                ownerform.statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)e.FocusedColumn).StatusBarKisayolAciklama;
            }
            else if (((IStatusBarKisayol)e.FocusedColumn).StatusBarAciklama != null)
                ownerform.statusbarAciklama.Caption = ((IStatusBarKisayol)e.FocusedColumn).StatusBarAciklama;

        }

        private void Tablo_SablonChanged(object sender, EventArgs e)
        {

            tablosablonkayitedilicek = true;
            SablonKaydet();
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (baseTablo.IsEditorFocused)
                        insUpdNavigator.Navigator.Buttons.DoClick(insUpdNavigator.Navigator.Buttons.CancelEdit);
                    else
                        ownerform?.Close();
                    break;
                case Keys.Tab:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                    insUpdNavigator.Navigator.Buttons.DoClick(insUpdNavigator.Navigator.Buttons.EndEdit);
                    break;
                case Keys.Insert when e.Shift:
                    HareketEkle();
                    break;
                case Keys.Delete when e.Modifiers == Keys.Shift:
                    HareketSil();
                    break;
                default:
                    break;
            }
        }

        private void Tablo_LostFocus(object sender, EventArgs e)
        {
            if (ownerform == null) return;
            ownerform.statusbarKisayol.Visibility = BarItemVisibility.Never;
            ownerform.statusBarKisayolAciklama.Visibility = BarItemVisibility.Never;
        }

        private void Tablo_GotFocus(object sender, EventArgs e)
        {
            if (ownerform == null) return;

            ownerform.statusbarKisayol.Visibility = BarItemVisibility.Always;
            ownerform.statusBarKisayolAciklama.Visibility = BarItemVisibility.Always;

            ownerform.statusbarAciklama.Caption = ((IStatusBarAciklama)sender).StatusBarAciklama;
            ownerform.statusbarKisayol.Caption = ((IStatusBarKisayol)sender).StatusBarKisayol;
            ownerform.statusBarKisayolAciklama.Caption = ((IStatusBarKisayol)sender).StatusBarKisayolAciklama;
        }

        protected virtual void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (popupMenu == null) return;
            if (e.Button != MouseButtons.Right) return;
            btnHareketSil.Enabled = baseTablo.RowCount > 0;
            btnTümSeçimleriKaldır.Enabled = baseTablo.RowCount > 0;
            btnTümünüSeç.Enabled = baseTablo.RowCount > 0;
            btnTümHareketSil.Enabled = baseTablo.RowCount > 0;
            e.SagMenuGoster(popupMenu);
        }

        protected virtual void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!isloaded) return;
            var ent = baseTablo.GetRow<IBaseHaraketEntity>();
            if (!ent.Insert)
                ent.Update = true;
            ButtonEnableDurum(true);
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {


            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnHareketEkle)
                HareketEkle();
            else if (e.Item == btnHareketSil)
                HareketSil();
            else if (e.Item == btnTümünüSeç)
                TümünüSeç();
            else if (e.Item == btnTümSeçimleriKaldır)
                TümSeçimleriKaldır();
            else if (e.Item == btnTümHareketSil)
                TümHaraketleriSil();
            Cursor.Current = Cursors.Default;

        }



        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            var buttons = insUpdNavigator.Navigator.Buttons;
            if (e.Button == buttons.Append)
                HareketEkle();
            else if (e.Button == buttons.Remove)
                HareketSil();
            if (e.Button == buttons.Append || e.Button == buttons.Remove)
                e.Handled = true;
            Cursor.Current = Cursors.Default;

        }

    }
}
