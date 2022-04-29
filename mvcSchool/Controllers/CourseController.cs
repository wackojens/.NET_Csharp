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

        public CourseController(CourseService courseService, StudentService studentService)
        {
            this.courseService = courseService;
            this.studentService = studentService;
        }

        // GET: CourseController
        public ActionResult Index() => View(courseService.Get());

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

                foreach (StudentModel student in ViewBag.students)
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
                CourseModel newCourse = new();

                newCourse.Id = id;
                newCourse.CourseName = collection["CourseName"];

                courseService.Update(id, newCourse);

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

        //// POST: CourseController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
