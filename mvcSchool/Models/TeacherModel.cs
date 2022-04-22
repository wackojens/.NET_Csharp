namespace mvcSchool.Models
{
    public class TeacherModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public string Gender { get; set; }
        public string Township { get; set; }
        public int PostalCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> Courses { get; set; } = new();
    }
}
