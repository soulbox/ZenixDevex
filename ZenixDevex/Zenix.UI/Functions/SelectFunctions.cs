using System;
using Zenix.Common.Enums;
using Zenix.Model.Entities;
using Zenix.WinUI.myUserControls.Controls;
using Zenix.WinUI.Show;
using Zenix.WinUI.Forms.KullanıcıForms;
using Zenix.Model.DTO;
using Zenix.WinUI.Forms.ÜlkeFormu;

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
