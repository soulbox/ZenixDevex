using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Zenix.Common.Enums;
using Zenix.Common.Function;
using Zenix.Data.Context;
using Zenix.Model.Entities;

namespace Zenix.Data.ServerMigration
{
    public class Configuration : DbMigrationsConfiguration<ZenixContext>
    {
        public Configuration()
        {
            //migrationa izin ver
            AutomaticMigrationsEnabled = true;
            // migration işlemi yaparken veri kaybına izin ver
            //-örn long tipinde alanını int tipine dönüştürdüğünde longda iken db de veri varsa int dönüşümünde veri kaybı olur.
            AutomaticMigrationDataLossAllowed = true;

        }
        protected override void Seed(ZenixContext context)
        {
            SeedKullanıcı(context);

        }

        void SeedKullanıcı(ZenixContext db)
        {
            void Rol()
            {
                db.Rol.AddOrUpdate(x => x.Id, new Rol
                {
                    Id = 1,
                    Kod = "Rol-0001",
                    RolAdi = "Yönetici",
                    Açıklama = "Sistem Tarafından Oluşturuldu",
                    Durum = true,
                });
            }
            void RolYetki()
            {
                var rollist = db.RolYetkileri.Where(x => x.RolId == 1).Select(x => x.KartTuru).ToList();
                var list = (KartTuru[])Enum.GetValues(typeof(KartTuru));

                byte görebiliriseaktif(KartTuru kart)
                {
                    //if (kart == KartTuru.PolisoftVeriAlma || kart == KartTuru.SmsGönder || kart == KartTuru.TümKrediKartları)
                    //    return 2;
                    //else
                    return 1;

                }
                foreach (var item in list.Where(x => !rollist.Contains(x)).ToList())
                    db.RolYetkileri.AddOrUpdate(a => a.Id, new RolYetkileri
                    {
                        Id = (int)item,
                        RolId = 1,
                        KartTuru = item,
                        Görebilir = görebiliriseaktif(item),
                        Değiştirebilir = görebiliriseaktif(item),
                        Ekleyebilir = görebiliriseaktif(item),
                        Silebilir = görebiliriseaktif(item)
                    });

            }

            Rol();
            RolYetki();
            if (db.Kullanici.Any(x => x.Id == 1)) return;
            db.Kullanici.AddOrUpdate(x => x.Id, new Kullanici
            {
                Id = (long)1,
                Durum = true,
                Kod = "admin",
                Şifre = "admin".Md5Şifrele(),
                Adı = "admin",
                Soyadı = "admin",
                Açıklama = "admin",
                Email = "kadir2008@hotmail.com",
                RolId = 1,
            });
        }




    }
}
