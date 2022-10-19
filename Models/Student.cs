namespace WebApiEFAssDay1.Models
{
    public class Student : BaseEntity<int>
    {   
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
    }
}