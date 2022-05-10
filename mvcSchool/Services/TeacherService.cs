using Microsoft.Extensions.Options;
using MongoDB.Driver;
using mvcSchool.Models;

namespace mvcSchool.Services
{
    public class TeacherService
    {
        private readonly IMongoCollection<TeacherModel> teachers;

        public TeacherService(IOptions<mvcSchoolDBModel> dbSettings)
        {
            MongoClient client = new MongoClient(dbSettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(dbSettings.Value.DatabaseName);
            teachers = database.GetCollection<TeacherModel>("Teachers");
        }

        public List<TeacherModel> Get()
        {
            return teachers.Find(teacher => true).ToList();
        }

        public TeacherModel Get(string id)
        {
            return teachers.Find(teacher => teacher.Id == id).FirstOrDefault();
        }

        public TeacherModel Create(TeacherModel teacher)
        {
            teachers.InsertOne(teacher);
            return teacher;
        }

        public void Update(string id, TeacherModel tempTeacher)
        {
            teachers.ReplaceOne(teacher => teacher.Id == id, tempTeacher);
        }

        //public void Remove(TeacherModel tempTeacher)
        //{
        //    teacher.DeleteOne(teacher => teacher.Id == tempTeacher.Id);
        //}

        public void Remove(string id)
        {
            teachers.DeleteOne(teacher => teacher.Id == id);
        }

        public List<CourseModel> freeCourses(List<CourseModel> allCourses, List<TeacherModel> allTeachers)
        {
            List<CourseModel> selectedCourses = new();

            foreach (CourseModel course in allCourses)
            {
                foreach (TeacherModel teacher in allTeachers)
                {
                    if (teacher.Courses.Contains(course.Id))
                        selectedCourses.Add(course);
                }
            }
            foreach (CourseModel selectedCourse in selectedCourses)
            {
                allCourses.Remove(selectedCourse);
            }

            return allCourses;
        } 
    }
}
