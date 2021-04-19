namespace TecgurusAdvanced2021.MVC_Prueba.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TecgurusAdvanced2021.MVC_Prueba.CodeFirstExample.DBContextCodeFirst>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TecgurusAdvanced2021.MVC_Prueba.CodeFirstExample.DBContextCodeFirst context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
