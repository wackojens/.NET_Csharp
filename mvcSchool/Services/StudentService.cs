using Microsoft.Extensions.Options;
using MongoDB.Driver;
using mvcSchool.Models;

namespace mvcSchool.Services
{
    public class StudentService
    {
        private readonly IMongoCollection<StudentModel> students;

        public StudentService(IOptions<mvcSchoolDBModel> dbSettings)
        {
            MongoClient client = new MongoClient(dbSettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(dbSettings.Value.DatabaseName);
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

        public void AddCourses(List<string> courseIds, StudentModel student)
        {
            foreach (string courseId in courseIds)
            {
                if (!student.CourseResults.ContainsKey(courseId))
                    student.CourseResults.Add(courseId, null);
            }
        }

        public void RemoveCourses(List<string> courseIds, StudentModel student)
        {
            foreach (KeyValuePair<string, string> courseScore in student.CourseResults)
            {
                if (!courseIds.Contains(courseScore.Key))
                    student.CourseResults.Remove(courseScore.Key);
            }
        }
    }
}
