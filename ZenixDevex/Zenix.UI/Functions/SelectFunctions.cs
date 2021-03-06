using System;
using Zenix.Common.Enums;
using Zenix.Model.Entities;
using Zenix.WinUI.myUserControls.Controls;
using Zenix.WinUI.Show;
using Zenix.WinUI.Forms.KullanıcıForms;
using Zenix.Model.DTO;
using Zenix.WinUI.Forms.ÜlkeFormu;
using Zenix.WinUI.Forms.FirmaFormu;
using Zenix.WinUI.Forms.ÜrünlerFormu;
using Zenix.WinUI.Forms.RevizyonFormu;
using Zenix.BLL.General;
using Zenix.BLL.Base;
using Zenix.Model.Entities.Base;
using Zenix.BLL.Interfaces;
using Zenix.WinUI.Forms.AmbalajTipiFormu;
using Zenix.WinUI.Forms.MarkalarFormu;
using Zenix.WinUI.Forms.MamülFormu;
using Zenix.WinUI.Forms.ReçeteFormu;

namespace Zenix.WinUI.Functions
{
    public class SelectFunctions : IDisposable
    {
        myButtonEdit btnedit;
        myButtonEdit prmedit;
        KartTuru KartTuru;
        public void Seç(myButtonEdit btnedit)
        {

            this.btnedit = btnedit;
            SecimYap();
        }

        public void Seç(myButtonEdit btnedit, myButtonEdit prmedit)
        {
            this.btnedit = btnedit;
            this.prmedit = prmedit;
            SecimYap();
        }
        private void SecimYap()
        {
            A GetSingle<T, A>(long? id)
                where T : BaseGenelBLL<A>
                where A : BaseEntity
            {
                using (var item = (T)Activator.CreateInstance(typeof(T)))
                    return (A)item.Single(x => x.Id == id);
            }
            switch (btnedit.Name)
            {

                case "txtRol":
                    {
                        var entity = (Rol)ShowListForms<RolListForm>.ShowDialogListForm(KartTuru.Rol, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.RolAdi;
                        }
                    }
                    break;
                case "txtKullanıcı":
                    {
                        var entity = (KullanıcıL)ShowListForms<KullanıcıListForm>.ShowDialogListForm(KartTuru.Kullanıcı, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = $"{entity.Adı} {entity.Soyadı }";
                        }
                    }
                    break;
                case "txtÜlke":
                    {
                        var entity = (Ülke)ShowListForms<ÜlkeListForm>.ShowDialogListForm(KartTuru.Ülke, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.Adı;
                        }
                    }
                    break;
                case "txtPaketŞekli":
                    {
                        var entity = (AmbalajTipi)ShowListForms<AmbalajTipiListForm>.ShowDialogListForm(KartTuru.AmbalajTipi, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.Adı;
                        }
                    }
                    break;
                case "txtAmbalajMaddesi":
                    {
                        var entity = (AmbalajMaddeTipi)ShowListForms<AmbalajMaddeTipiListForm>.ShowDialogListForm(KartTuru.AmbalajMaddeTipi, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.Adı;
                        }
                    }
                    break;
                case "txtFirmaTipi":
                    {
                        var entity = (FirmaTipi)ShowListForms<FirmaTipiListForm>.ShowDialogListForm(KartTuru.FirmaTipi, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.Adı;
                        }
                    }
                    break;
                case "txtFirma":
                    {
                        var entity = (FirmalarL)ShowListForms<FirmaListFormu>.ShowDialogListForm(KartTuru.Firma, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Tag = entity;
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.FirmaAdi;
                        }
                    }
                    break;
                case "txtMarka":
                    {
                        var entity = (Markalar)ShowListForms<MarkalarListForm>.ShowDialogListForm(KartTuru.Markalar, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.MarkaAdı;
                        }
                    }
                    break;
                case "txtMamül":
                    {
                        var entity = (MamülL)ShowListForms<MamülListForm>.ShowDialogListForm(KartTuru.Mamül, btnedit.Id, true);
                        if (entity != null)
                        {
                            btnedit.Tag = entity;
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.MamülAdı;
                        }
                    }
                    break;
                case "txtÜrün":
                    {
                        var entity = (ÜrünL)ShowListForms<ÜrünListForm>.ShowDialogListForm(KartTuru.Ürün, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Tag = entity;
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = $"[{entity.MarkaAdı}-{entity.MamülAdı}-{entity.GTIN}]";
                        }
                    }
                    break;
                case "txtRevizyon":
                    {

                        var entity = (RevizyonS)ShowListForms<RevizyonListForm>.ShowDialogListForm(KartTuru.Revizyon, btnedit.Id, prmedit.Tag);
                        if (entity != null)
                        {
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.RevKodu;
                        }
                    }
                    break;
                case "txtReçete":
                    {

                        var entity = (ReçeteL)ShowListForms<ReçeteListForm>.ShowDialogListForm(KartTuru.Reçete, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Tag = entity;
                            btnedit.Id = entity.Id;
                            btnedit.Text = entity.ReçeteAdı;
                        }
                    }
                    break;

            }
        }

        #region Dispose
        public void Dispose()
        {

            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
