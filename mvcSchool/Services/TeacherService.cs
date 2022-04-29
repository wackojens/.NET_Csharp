using MongoDB.Driver;
using mvcSchool.Models;

namespace mvcSchool.Services
{
    public class TeacherService
    {
        private readonly IMongoCollection<TeacherModel> teachers;

        public TeacherService(IConfiguration config)
        {
            MongoClient client = new MongoClient("mongodb+srv://m001-student:m001-mongodb-basics@sandbox.4d5t5.mongodb.net/Sandbox?retryWrites=true&w=majority");
            IMongoDatabase database = client.GetDatabase("mvcSchool");
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
    }
}
