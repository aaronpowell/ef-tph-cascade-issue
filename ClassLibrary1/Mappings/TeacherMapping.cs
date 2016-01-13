using ClassLibrary1.Models;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Mappings
{
    public class TeacherMapping : EntityTypeConfiguration<Teacher>
    {
        public TeacherMapping()
        {
            ToTable("Teachers");
        }
    }
}
