namespace mvcSchool.Models
{
    public class StudentModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public string Gender { get; set; }
        public string Township { get; set; }
        public int PostalCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Dictionary<string, int> CourseResults { get; set; } = new();



        public List<string> CourseIds = new();

        private static List<StudentModel> Students = new();



        static StudentModel()
        {
            Students.Add(new StudentModel() { FirstName = "Jens", LastName = "Coomans", Birthdate = "19/01/1990", Gender = "Male", Township = "Hechtel-Eksel", PostalCode = 3990, Address = "Klaverstraat 9", PhoneNumber = "0475358177", Email = "Jens.Coomans@outlook.be"});
            Students.Add(new StudentModel() { FirstName = "Dario", LastName = "Van Hasselt", Birthdate = "20/02/2002", Gender = "Male", Township = "Mol", PostalCode = 2400, Address = "Dariostraat 202", PhoneNumber = "0496215487", Email = "Dario@Xerio.com" });
        }

        public void AddCourse(string courseId)
        {
            CourseIds.Add(courseId);
        }

        public void SetScore(string courseId, int score)
        {
            CourseResults[courseId] = score;
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
                }
            }
        }
    }
}
