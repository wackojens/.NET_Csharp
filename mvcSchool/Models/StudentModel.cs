using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;

namespace mvcSchool.Models
{
    public class StudentModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("firstName")]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [BsonElement("fullName")]
        public string FullName { get; set; }

        [BsonElement("birthdate")]
        public string Birthdate { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; }

        [BsonElement("township")]
        public string Township { get; set; }

        [BsonElement("postalCode")]
        [DisplayName("Postal code")]
        public int PostalCode { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("phoneNumber")]
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("courseResults")]
        public Dictionary<string, string> CourseResults { get; set; } = new();

        [BsonElement("courses")]
        public List<CourseModel> Courses = new();
    }
}
