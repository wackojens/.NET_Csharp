using System.ComponentModel;

namespace mvcSchool.Models
{
    public class StudentModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [DisplayName("test")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public string Gender { get; set; }
        public string Township { get; set; }
        public int PostalCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Dictionary<string, int> CourseResults { get; set; } = new() { { "python", 10 },{ ".NET", 20 } };

        public List<string> Courses = new();

        private static List<StudentModel> Students = new();



        static StudentModel()
        {
            Students.Add(new StudentModel() { FirstName = "Jens", LastName = "Coomans", Birthdate = "19/01/1990", Gender = "Male", Township = "Hechtel-Eksel", PostalCode = 3990, Address = "Klaverstraat 9", PhoneNumber = "0475/358177", Email = "Jens.Coomans@outlook.be"});
            Students.Add(new StudentModel() { FirstName = "Dario", LastName = "Van Hasselt", Birthdate = "20/02/2002", Gender = "Male", Township = "Mol", PostalCode = 2400, Address = "Dariostraat 202", PhoneNumber = "0496/215487", Email = "Dario@xerio.com" });
        }

        //public void AddCourse(string courseId)
        //{
        //    Courses.Add(courseId);
        //}

        //public void ShowScore(string courseId, int score)
        //{
        //    CourseResults[courseId] = score;
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
        //    List<CourseModel> allCourses = CourseModel.GetAll();

        //    var courseList = from course in allCourses
        //                     where Courses.Contains(course.Id)
        //                     select course.CourseName;

        //    foreach (string course in courseList)
        //        courseNames += course + separator;

        //    courseNames = courseNames.Trim(separator.ToCharArray());

        //    return courseNames;
        //}

        public string GetCourseName(string id)
        {
            List<CourseModel> allCourses = CourseModel.GetAll();

            string name = allCourses.Where(c => c.Id == id).Select(c => c.CourseName).First();

            return name;
        }

            public static List<StudentModel> GetAll()
        {
            return Students;
        }

        public static StudentModel GetStudent(string id)
        {
            foreach (StudentModel student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public static void Delete(string id)
        {
            foreach (StudentModel student in Students)
            {
                if (student.Id == id)
                {
                    Students.Remove(student);
                    break;
                }
            }
        }

        public static void AddStudent(StudentModel student)
        {
            Students.Add(student);
        }

        public static void UpdateStudent(StudentModel newStudent)
        {
            foreach (StudentModel student in Students)
            {
                if (student.Id == newStudent.Id)
                {
                    student.FirstName = newStudent.FirstName;
                    student.LastName = newStudent.LastName;
                    student.Birthdate = newStudent.Birthdate;
                    student.Gender = newStudent.Gender;
                    student.Township = newStudent.Township;
                    student.PostalCode = newStudent.PostalCode;
                    student.Address = newStudent.Address;
                    student.PhoneNumber = newStudent.PhoneNumber;
                    student.Email = newStudent.Email;
                    student.Courses = newStudent.Courses;
                    break;
                }
            }
        }
    }
}
