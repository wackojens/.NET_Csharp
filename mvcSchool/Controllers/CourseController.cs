using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvcSchool.Models;
using mvcSchool.Services;

namespace mvcSchool.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseService courseService;
        private readonly StudentService studentService;
        private readonly TeacherService teacherService;

        public CourseController(CourseService courseService, StudentService studentService, TeacherService teacherService)
        {
            this.courseService = courseService;
            this.studentService = studentService;
            this.teacherService = teacherService;
        }

        // GET: CourseController
        public ActionResult Index()
        {
            ViewBag.teachers = teacherService.Get();
            return View(courseService.Get());
        }

        // GET: CourseController/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tempCourse = courseService.Get(id);
            if (tempCourse == null)
            {
                return NotFound();
            }
            List<StudentModel> students = courseService.GetCourseStudents(id);
            ViewBag.students = students;
            TeacherModel teacher = courseService.GetCourseTeacher(id);
            ViewBag.teacher = teacher;

            return View(tempCourse);
        }

        // POST: CourseController/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(string id, IFormCollection collection)
        {
            try
            {
                var tempCourse = courseService.Get(id);


                List<StudentModel> students = courseService.GetCourseStudents(id);
                ViewBag.students = students;
                TeacherModel teacher = courseService.GetCourseTeacher(id);
                ViewBag.teacher = teacher;

                foreach (StudentModel student in students)
                {
                    student.CourseResults[id] = collection[student.Id];
                    studentService.Update(student.Id, student);
                }

                return View(tempCourse);
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                CourseModel newCourse = new();

                newCourse.CourseName = collection["CourseName"];
                courseService.Create(newCourse);
                
                return RedirectToAction("Index");
        }
            catch
            {
                return View();
    }
}

        // GET: CourseController/Edit/5
        public ActionResult Edit(string id)
        {
            return View(courseService.Get(id));
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                CourseModel tempCourse = new();

                tempCourse.Id = id;
                tempCourse.CourseName = collection["CourseName"];

                courseService.Update(id, tempCourse);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(string id)
        {
            courseService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
