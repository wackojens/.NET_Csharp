using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvcSchool.Models;

namespace mvcSchool.Controllers
{
    public class CourseController : Controller
    {
        // GET: CourseController
        public ActionResult Index()
        {
            return View(CourseModel.GetAll());
        }

        // GET: CourseController/Details/5
        public ActionResult Details(string id)
        {
            CourseModel newCourse = CourseModel.GetCourse(id);
            /*newCourse.CourseTeacher = */newCourse.GetTeacher();
            newCourse.GetStudents();
            return View(newCourse);
        }

        // POST: CourseController/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(string id, IFormCollection collection)
        {
            try
            {
                CourseModel newCourse = CourseModel.GetCourse(id);
                foreach (StudentModel student in newCourse.Students)
                {
                    student.CourseResults[newCourse.CourseName] = collection[student.Id];
                }

                return View(newCourse);
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
                CourseModel.AddCourse(newCourse);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(string id)
        {
            return View(CourseModel.GetCourse(id));
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

                CourseModel.UpdateCourse(newCourse);

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
            CourseModel.Delete(id);
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
