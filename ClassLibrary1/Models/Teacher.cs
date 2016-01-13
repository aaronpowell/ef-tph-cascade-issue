using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public class Teacher : Person
    {
        public int TeacherId { get; set; }
        public string Department { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<ContactInfo> ContactInfos { get; set; }
    }
}
