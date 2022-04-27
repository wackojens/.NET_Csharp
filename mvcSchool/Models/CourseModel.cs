namespace mvcSchool.Models
{
    public class CourseModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CourseName { get; set; }
        //public string CourseTeacher { get; set; }
        public TeacherModel Teacher { get; set; }

        public List<StudentModel> Students = new();

        public static List<CourseModel> Courses = new();

        static CourseModel()
        {
            Courses.Add(new CourseModel() { CourseName = "python" });
            Courses.Add(new CourseModel() { CourseName = ".NET" });
        }
        public static List<CourseModel> GetAll()
        {
            foreach (CourseModel course in Courses)
            {
               /* course.CourseTeacher = */course.GetTeacher();
            }
            return Courses;
        }

        public static CourseModel GetCourse(string id)
        {
            foreach (CourseModel course in Courses)
            {
                if (course.Id == id)
                {
                    return course;
                }
            }
            return null;
        }

        public static void Delete(string id)
        {
            foreach (CourseModel course in Courses)
            {
                if (course.Id == id)
                {
                    Courses.Remove(course);
                    break;
                }
            }
        }

        public static void AddCourse(CourseModel course)
        {
            Courses.Add(course);
        }

        public static void UpdateCourse(CourseModel newCourse)
        {
            foreach (CourseModel course in Courses)
            {
                if (course.Id == newCourse.Id)
                {
                    course.CourseName = newCourse.CourseName;
                    break;
                }
            }
        }

        public /*string*/ void GetTeacher()
        {
            List<TeacherModel> allTeachers = TeacherModel.GetAll();

            //string teacherName = allTeachers.Where(t => t.Courses.Contains(Id)).Select(t => t.FirstName + " " + t.LastName).FirstOrDefault();
            //if (teacherName == null)
            //    return "No teacher added.";
            //string teacherId = allTeachers.Where(t => t.Courses.Contains(Id)).Select(t => t.Id).First();

            //return teacherName;
            Teacher = allTeachers.Where(t => t.Courses.Contains(Id)).Select(t => t).FirstOrDefault();
            if (Teacher == null)
            {
                TeacherModel dummy = new();
                dummy.FullName = "No teacher added.";
                Teacher = dummy;
            }
        }

        public void GetStudents()
        {
            List<StudentModel> allStudents = StudentModel.GetAll();

            //Students = allStudents.Where(s => s.Courses.Contains(Id)).Select(s => s.FirstName + " " + s.LastName).ToList();
            Students = allStudents.Where(s => s.Courses.Contains(Id)).Select(s => s).ToList();
        }
    }
}
