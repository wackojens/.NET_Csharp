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
        [DisplayName("first name")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
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
        public int PostalCode { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("phoneNumber")]
        public string PhoneNumber { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("courseResults")]
        public Dictionary<string, string> CourseResults { get; set; } = new();

        [BsonElement("courses")]
        public List<CourseModel> Courses = new();

        public void AddCourses()
        {
            foreach ( CourseModel course in Courses)
            {
                if (!CourseResults.ContainsKey(course.Id))
                    CourseResults.Add(course.Id, null);
            }
        }

        public void RemoveCourses()
        {
            List<string> courseIds = new();
            foreach (CourseModel course in Courses)
                courseIds.Add(course.Id);
            foreach (KeyValuePair<string,string> courseScore in CourseResults)
            {
                if (!courseIds.Contains(courseScore.Key))
                    CourseResults.Remove(courseScore.Key);
            }
        }
    }
}
