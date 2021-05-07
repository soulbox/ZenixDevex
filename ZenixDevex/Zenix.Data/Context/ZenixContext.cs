using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Zenix.Common.Function;
using Zenix.Data.ServerMigration;
using Zenix.Model.Entities;

namespace Zenix.Data.Context
{
    public class ZenixContext : BaseDbContext<ZenixContext, Configuration>
    {
        public ZenixContext() : base() { Init(); }
        public ZenixContext(string constr) : base(constr) { Init(); }
        void Init()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreContext, ContextInitializer>());
            //this.Database.Initialize(new MigrateDatabaseToLatestVersion<ZenixContext,>)


        }

        public DbSet<Filtre> Filtre { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolYetkileri> RolYetkileri { get; set; }
        public DbSet<Firma> Firma { get; set; }
        public DbSet<Ülke> Ülke { get; set; }
        public DbSet<Ürün> Ürün { get; set; }
        public DbSet<Revizyon> Revizyon { get; set; }
        public DbSet<Paketleme> Paketleme { get; set; }
        public DbSet<Sipariş> Sipariş { get; set; }
        public DbSet<Reçete> Reçete { get; set; }
        public DbSet<SiparişÜrünleri> ReçeteMalzemeler { get; set; }
        public DbSet<Kazan> Kazan { get; set; }
        public DbSet<Markalar> Markalar { get; set; }
        public DbSet<AmbalajTipi> AmbalajTipi { get; set; }
        public DbSet<AmbalajMaddeTipi> AmbalajMaddeTipi { get; set; }

        public DbSet<İşemri> İşemri { get; set; }
        public DbSet<Mamül > Mamül { get; set; }
        public DbSet<Satınalma> Satınalma { get; set; }
        public DbSet<SatınAlmaMalzemeler> SatınAlmaMalzemeler { get; set; }

















        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Rol>()
                .HasMany(x => x.RolYetkileri)//rolün birden çok rolyetkileri vardır
                .WithRequired()
                .WillCascadeOnDelete(true); //rolün rolyetkilerini kademeli olarak sil



        }





        static SqlConnectionStringBuilder LocalPC = new SqlConnectionStringBuilder()
        {

            DataSource = ".",
            UserID = "sa",
            Password = "63792958",
            InitialCatalog = "ZENIX",
        };

        static SqlConnectionStringBuilder Sunucu = new SqlConnectionStringBuilder()
        {

            DataSource = "213.142.144.186",
            UserID = "ZENIX",
            Password = "Zenix2021!",
            InitialCatalog = "ZENIX",
        };

        static List<SqlConnectionStringBuilder> datasources = datasources ?? new List<SqlConnectionStringBuilder>()
        {
            //HWIDEngine.isExcludeMachine ?LocalPC:  Sunucu,
            Sunucu,
            //LocalPC//server          
        };
        static SqlConnectionStringBuilder FirstOrDefaultConnections()
        {
            //return SimpaşGlobalIP;

            foreach (SqlConnectionStringBuilder x in datasources.Where(x => x != null).ToList())
            {
                //if (x.DataSource  != "213.14.174.241") continue;
                //x.IntegratedSecurity = true; // windows auth için aktif olması gerek
                x.ApplicationIntent = ApplicationIntent.ReadOnly;
                x.ConnectTimeout = 10;
                x.MultipleActiveResultSets = true;
                using (var con = new SqlConnection(x.ConnectionString))
                {
                    try
                    {
                        con.Open();

                        if (con.State == System.Data.ConnectionState.Open)
                            return x;
                        break;
                    }
                    catch (System.Exception ex)
                    {
                        if (x == Sunucu)
                        {
                            MessageBox.Show($"Sunucuya Bağlanılamadı!\r\n{ex}");
                            System.Environment.Exit(0);
                        }
                    }
                }

            }
            return LocalPC;
        }

        public static SqlConnectionStringBuilder ConBuilder = ConBuilder ?? FirstOrDefaultConnections();

    }
}
