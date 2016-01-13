using ClassLibrary1.Models;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary1.Mappings
{
    public class ContactInfoMapping : EntityTypeConfiguration<ContactInfo>
    {
        public ContactInfoMapping()
        {
            HasRequired(ci => ci.Teacher)
                .WithMany(t => t.ContactInfos)
                .HasForeignKey(ci => ci.TeacherId)
                .WillCascadeOnDelete(true);
        }
    }
}
