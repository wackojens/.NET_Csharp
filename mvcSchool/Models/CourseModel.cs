using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using mvcSchool.Services;
using System.ComponentModel;

namespace mvcSchool.Models
{
    public class CourseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("courseName")]
        [DisplayName("Course")]
        public string CourseName { get; set; }
    }
}