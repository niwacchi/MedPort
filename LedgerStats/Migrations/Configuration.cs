namespace LedgerStats.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LedgerStats.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LedgerStats.Models.MyLedgerDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "LedgerStats.Models.MyDB";
        }

        protected override void Seed(LedgerStats.Models.MyLedgerDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Patient.AddOrUpdate(
                new Patient { Id = 1, No = 1, Name = "山田 花子"　},
                new Patient { Id = 2, No = 1, Name = "斉藤 めぐみ"　},
                new Patient { Id = 3, No = 1, Name = "比嘉 愛美"　}
                );
        }
    }
}
