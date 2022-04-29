using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mvcSchool.Models
{
    public class TeacherModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

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

        [BsonElement("fullName")]
        public string FullName { get; set; }

        public List<CourseModel> Courses = new();

        //private static List<TeacherModel> Teachers = new();

        //static TeacherModel()
        //{
        //    Teachers.Add(new TeacherModel() { FirstName = "Bert", LastName = "Vriens", Birthdate = "01/01/1985", Gender = "Male", Township = "Heusden-Zolder", PostalCode = 3550, Address = "Bert baan 20", PhoneNumber = "0478/123456", Email = "BV@gmail.com", FullName = "Bert Vriens" });
        //    Teachers.Add(new TeacherModel() { FirstName = "Danny", LastName = "Drijvers", Birthdate = "01/01/1985", Gender = "Male", Township = "Houthalen-Helchteren", PostalCode = 3530, Address = "Danny dreef 15", PhoneNumber = "0497/987654", Email = "DannyD@hotmail.com", FullName = "Danny Drijvers" });
        //}

        //public static List<TeacherModel> GetAll()
        //{
        //    return Teachers;
        //}

        //public static TeacherModel GetTeacher(string id)
        //{
        //    foreach (TeacherModel teacher in Teachers)
        //    {
        //        if (teacher.Id == id)
        //        {
        //            return teacher;
        //        }
        //    }
        //    return null;
        //}

        //public static void Delete(string id)
        //{
        //    foreach (TeacherModel teacher in Teachers)
        //    {
        //        if (teacher.Id == id)
        //        {
        //            Teachers.Remove(teacher);
        //            break;
        //        }
        //    }
        //}

        //public static void AddTeacher(TeacherModel teacher)
        //{
        //    Teachers.Add(teacher);
        //}

        //public static void UpdateTeacher(TeacherModel newTeacher)
        //{
        //    foreach (TeacherModel teacher in Teachers)
        //    {
        //        if (teacher.Id == newTeacher.Id)
        //        {
        //            teacher.FirstName = newTeacher.FirstName;
        //            teacher.LastName = newTeacher.LastName;
        //            teacher.Birthdate = newTeacher.Birthdate;
        //            teacher.Gender = newTeacher.Gender;
        //            teacher.Township = newTeacher.Township;
        //            teacher.PostalCode = newTeacher.PostalCode;
        //            teacher.Address = newTeacher.Address;
        //            teacher.PhoneNumber = newTeacher.PhoneNumber;
        //            teacher.Email = newTeacher.Email;
        //            teacher.Courses = newTeacher.Courses;
        //            teacher.FullName = newTeacher.FullName;
        //            break;
        //        }
        //    }
        //}

        //public List<string> GetCourseNamesList()
        //{
        //    List<string> courseNames = new();
        //    List<CourseModel> allCourses = CourseModel.GetAll();

        //    var courseList = from course in allCourses
        //                     where Courses.Contains(course.Id)
        //                     select course.CourseName;

        //    foreach (string course in courseList)
        //        courseNames.Add(course);

        //    return courseNames;
        //}

        //public string StringCourseNames()
        //{
        //    string courseNames = "";
        //    string separator = ", ";
        //    List<string> courseList = GetCourseNamesList();

        //    foreach (string course in courseList)
        //        courseNames += course + separator;
        //    courseNames = courseNames.Trim(separator.ToCharArray());
        //    return courseNames;
        //}

        //public string GetCourseName(string id)
        //{
        //    List<CourseModel> allCourses = CourseModel.GetAll();

        //    //var courseName = from course in allCourses
        //    //                 where course.Id == id
        //    //                 select course.CourseName;
        //    //foreach (string name in courseName)
        //    //    return name;
        //    //return null;
        //    string name = allCourses.Where(c => c.Id == id).Select(c => c.CourseName).First();
        //    return name;

        //}
    }
}
