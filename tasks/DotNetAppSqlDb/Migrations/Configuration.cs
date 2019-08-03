namespace DotNetAppSqlDb.Migrations
{
    using System;
 
    using System.Data.Entity.Migrations;
 

    internal sealed class Configuration : DbMigrationsConfiguration<Models.MyDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "DotNetAppSqlDb.Models.MyDatabaseContext";
        }

        protected override void Seed(Models.MyDatabaseContext context)
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
            context.Todoes.AddOrUpdate(
                new Models.Todo { ID=5, CreatedDate = DateTime.Today,Description="fake data"}
                );
        }
    }
}
