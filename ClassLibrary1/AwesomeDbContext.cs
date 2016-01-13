using ClassLibrary1.Mappings;
using ClassLibrary1.Models;
using System.Data.Entity;

namespace ClassLibrary1
{
    public class AwesomeDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
