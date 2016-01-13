using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public ICollection<ContactInfo> ContactInfos { get; set; }
    }
}
