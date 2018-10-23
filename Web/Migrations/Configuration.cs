namespace Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Web.Models.SchoolContext";
        }

        protected override void Seed(Web.Models.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            // uncomment the below code for seeding and take care of auto-increments in db by resetting it (wasiq).
            //
            //context.Students.AddOrUpdate(
            //  new Student { StudentID = 1, Name="Kamran", FatherName="abc", Class="1"},
            //  new Student { StudentID = 2, Name = "Asif", FatherName = "abc", Class = "1" },
            //  new Student { StudentID = 3, Name = "Ali", FatherName = "abc", Class = "1" }
            //);

            //
        }
    }
}
