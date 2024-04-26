using System.Data.Entity.Migrations;

namespace HowEntityFrameworkWorks.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<HowEntityFrameworkWorks.MyDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HowEntityFrameworkWorks.MyDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
