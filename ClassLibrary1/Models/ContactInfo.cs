namespace ClassLibrary1.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
    }
}
