using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Data.Context
{
    public class BaseDbContext<TContext, TConfiguartion> : DbContext
        where TContext : DbContext
        where TConfiguartion : DbMigrationsConfiguration<TContext>, new()
    {
        public static string nameOrConnectionString { get; set; } = typeof(TContext).Name;
        public BaseDbContext() : base(nameOrConnectionString)
        {

        }
        public BaseDbContext(string constring) : base(constring)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TContext, TConfiguartion>());
            nameOrConnectionString = constring;
        }

    }
}
