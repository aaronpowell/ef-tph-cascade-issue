using ClassLibrary1.Models;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Mappings
{
    public class StudentMapping : EntityTypeConfiguration<Student>
    {
        public StudentMapping()
        {
            ToTable("Students");
        }
    }
}
