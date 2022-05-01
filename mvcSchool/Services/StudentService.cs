using MongoDB.Driver;
using mvcSchool.Models;

namespace mvcSchool.Services
{
    public class StudentService
    {
        private readonly IMongoCollection<StudentModel> students;

        public StudentService(IConfiguration config)
        {
            MongoClient client = new MongoClient("mongodb+srv://m001-student:m001-mongodb-basics@sandbox.4d5t5.mongodb.net/Sandbox?retryWrites=true&w=majority");
                    IMongoDatabase database = client.GetDatabase("mvcSchool");
            students = database.GetCollection<StudentModel>("Students");
        }

        public List<StudentModel> Get()
        {
            return students.Find(student => true).ToList();
        }

        public StudentModel Get(string id)
        {
            return students.Find(student => student.Id == id).FirstOrDefault();
        }

        public StudentModel Create(StudentModel student)
        {
            students.InsertOne(student);

            return student;
        }

        public void Update(string id, StudentModel tempStudent)
        {
            students.ReplaceOne(student => student.Id == id, tempStudent);
        }

        //public void Remove(StudentModel tempStudent)
        //{
        //    students.DeleteOne(student => student.Id == tempStudent.Id);
        //}

        public void Remove(string id)
        {
            students.DeleteOne(student => student.Id == id);
        }

        public void AddCourses(StudentModel student)
        {
            foreach (CourseModel course in student.Courses)
            {
                if (!student.CourseResults.ContainsKey(course.Id))
                    student.CourseResults.Add(course.Id, null);
            }
        }

        public void RemoveCourses(StudentModel student)
        {
            List<string> courseIds = new();
            foreach (CourseModel course in student.Courses)
                courseIds.Add(course.Id);
            foreach (KeyValuePair<string, string> courseScore in student.CourseResults)
            {
                if (!courseIds.Contains(courseScore.Key))
                    student.CourseResults.Remove(courseScore.Key);
            }
        }
    }
}
