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
                return (A)item.Single(x=>x.Id==id);
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
                case "txtÜrün":
                    {

                        var entity = (Ürün)ShowListForms<ÜrünListForm>.ShowDialogListForm(KartTuru.Ürün, btnedit.Id);
                        if (entity != null)
                        {
                            btnedit.Tag = entity;
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.Adı;
                        }
                    }
                    break;
                case "txtRevizyon":
                    {
                        
                        var ürün = prmedit.Tag;
                        if (prmedit.Tag == null)
                            ürün = GetSingle<ÜrünBll, Ürün>(prmedit.Id);
                        var entity = (Revizyon)ShowListForms<ReziyonListForm>.ShowDialogListForm(KartTuru.Revizyon, btnedit.Id, ürün);
                        if (entity != null)
                        {
                            btnedit.Id = entity.Id;
                            btnedit.EditValue = entity.RevKodu;
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
