using Zenix.Model.Entities;
using Zenix.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zenix.Model.DTO
{
    public interface IPersonel
    {
        string AdSoyad { get; set; }
        string Personel { get; }
    }

    [NotMapped]
    public class KullanıcıS : Kullanici
    {
        public string RolAdı { get; set; }
    }
    [NotMapped]
    public class KullanıcıL : BaseEntity
    {
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string Email { get; set; }
        public string RolAdı { get; set; }
        public string Açıklama { get; set; }

    }
}
