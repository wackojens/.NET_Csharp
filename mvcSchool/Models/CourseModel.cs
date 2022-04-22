namespace mvcSchool.Models
{
    public class CourseModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CourseName { get; set; }
        public int MaxScore { get; set; }

        public static List<CourseModel> Courses = new();

        static CourseModel()
        {
            Courses.Add(new CourseModel() { CourseName = "python", MaxScore = 100 });
            Courses.Add(new CourseModel() { CourseName = ".NET", MaxScore = 80 });
        }
        public static List<CourseModel> GetAll()
        {
            return Courses;
        }
    }
}
