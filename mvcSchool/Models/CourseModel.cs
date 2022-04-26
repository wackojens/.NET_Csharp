namespace mvcSchool.Models
{
    public class CourseModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }

        public List<string> Students = new();

        public static List<CourseModel> Courses = new();

        static CourseModel()
        {
            Courses.Add(new CourseModel() { CourseName = "python" });
            Courses.Add(new CourseModel() { CourseName = ".NET" });
        }
        public static List<CourseModel> GetAll()
        {
            foreach (var course in Courses)
            { 
                course.CourseTeacher = course.GetTeacher();
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

        public string GetTeacher()
        {
            List<TeacherModel> allTeachers = TeacherModel.GetAll();

            string name = allTeachers.Where(t => t.Courses.Contains(Id)).Select(t =>  t.FirstName + " " + t.LastName).FirstOrDefault();
            if (name == null)
                return "No teacher added.";

            return name;
        }

        public void GetStudents()
        {
            List<StudentModel> allStudents = StudentModel.GetAll();

            Students = allStudents.Where(s => s.Courses.Contains(Id)).Select(s => s.FirstName + " " + s.LastName).ToList();
        }
    }
}
