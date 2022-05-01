using MongoDB.Bson;
using MongoDB.Driver;
using mvcSchool.Models;

namespace mvcSchool.Services
{
    public class CourseService
    {
        private readonly IMongoCollection<CourseModel> courses;
        private readonly IMongoCollection<StudentModel> students;
        private readonly IMongoCollection<TeacherModel> teachers;

        public CourseService(IConfiguration config)
        {
            MongoClient client = new MongoClient("mongodb+srv://m001-student:m001-mongodb-basics@sandbox.4d5t5.mongodb.net/Sandbox?retryWrites=true&w=majority");
                    IMongoDatabase database = client.GetDatabase("mvcSchool");
            courses = database.GetCollection<CourseModel>("Courses");
            students = database.GetCollection<StudentModel>("Students");
            teachers = database.GetCollection<TeacherModel>("Teachers");
        }

        public List<CourseModel> Get()
        {
            return courses.Find(course => true).ToList();
        }

        public CourseModel Get(string id)
        {
            return courses.Find(course => course.Id == id).FirstOrDefault();
        }

        public CourseModel Create(CourseModel course)
        {
            courses.InsertOne(course);
            return course;
        }

        public void Update(string id, CourseModel tempCourse)
        {
            courses.ReplaceOne(course => course.Id == id, tempCourse);

            var updateStudent = Builders<StudentModel>.Update.Set("courses.$[c].courseName", tempCourse.CourseName);

            var arrayFiltersStudent = new[]
            {
                new BsonDocumentArrayFilterDefinition<BsonDocument>(
                    new BsonDocument("c._id", new BsonDocument(
                        "$eq", ObjectId.Parse(id)))),
            };
            students.UpdateMany(x => true, updateStudent, new UpdateOptions {ArrayFilters = arrayFiltersStudent});

            var updateTeacher = Builders<TeacherModel>.Update.Set("courses.$[c].courseName", tempCourse.CourseName);

            var arrayFiltersTeacher = new[]
            {
                new BsonDocumentArrayFilterDefinition<BsonDocument>(
                    new BsonDocument("c._id", new BsonDocument(
                        "$eq", ObjectId.Parse(id)))),
            };
            teachers.UpdateMany(x => true, updateTeacher, new UpdateOptions { ArrayFilters = arrayFiltersTeacher});
        }

        //public void Remove(CourseModel tempCourse)
        //{
        //    courses.DeleteOne(course => course.Id == tempCourse.Id);
        //}

        public void Remove(string id)
        {
            var pullCourseStudent = Builders<StudentModel>.Update.PullFilter(s => s.Courses, c => c.Id == id );
            var unsetCourseStudent = Builders<StudentModel>.Update.Unset("courseResults." + id);
            var removeCourseStudent = Builders<StudentModel>.Update.Combine(pullCourseStudent, unsetCourseStudent);

            var pullCourseTeacher = Builders<TeacherModel>.Update.PullFilter(s => s.Courses, c => c.Id == id);

            teachers.UpdateMany(x => true, pullCourseTeacher);
            students.UpdateMany(x => true, removeCourseStudent);
            courses.DeleteOne(course => course.Id == id);
        }

        public List<StudentModel> GetCourseStudents(string id)
        {
            List<StudentModel> studentList = students.Find(s => s.CourseResults.ContainsKey(id)).ToList();
            if (studentList != null)
            {
                return studentList;
            }
            else
            {
                return new List<StudentModel>();
            }
        }

        public TeacherModel GetCourseTeacher(string id)
        {
            CourseModel course = courses.Find(course => course.Id == id).FirstOrDefault();
            TeacherModel teacher = teachers.Find(t => t.Courses.Contains(course)).FirstOrDefault();
            if (teacher != null)
                return teacher;
            else
                return new TeacherModel();
        }
    }
}
