using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using mvcSchool.Services;

namespace mvcSchool.Models
{
    public class CourseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("courseName")]
        public string CourseName { get; set; }

        [BsonElement("teacher")]
        public TeacherModel Teacher = null;
    }
}