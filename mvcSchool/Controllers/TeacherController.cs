using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvcSchool.Models;
using mvcSchool.Services;

namespace mvcSchool.Controllers
{
    public class TeacherController : Controller
    {
        private readonly TeacherService teacherService;
        private readonly CourseService courseService;

        public TeacherController(TeacherService teacherService, CourseService courseService)
        {
            this.teacherService = teacherService;
            this.courseService = courseService;
        }

        // GET: TeacherController
        public ActionResult Index() => View(teacherService.Get());

        // GET: TeacherController/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tempTeacher = teacherService.Get(id);
            if (tempTeacher == null)
            {
                return NotFound();
            }

            return View(tempTeacher);
        }

        // GET: TeacherController/Create
        public ActionResult Create()
        {
            List<CourseModel> courses = courseService.Get();
            MultiSelectList coursesList = new MultiSelectList(courses, "Id", "CourseName");
            ViewData["courses"] = coursesList;
            return View();
        }

        // POST: TeacherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                TeacherModel newTeacher = new();

                newTeacher.FirstName = collection["Firstname"];
                newTeacher.LastName = collection["LastName"];
                newTeacher.Birthdate = collection["Birthdate"];
                newTeacher.Gender = collection["Gender"];
                newTeacher.Township = collection["Township"];
                newTeacher.PostalCode = Int32.Parse(collection["PostalCode"]);
                newTeacher.Address = collection["Address"];
                newTeacher.PhoneNumber = collection["PhoneNumber"];
                newTeacher.Email = collection["Email"];
                newTeacher.FullName = newTeacher.FirstName + " " + newTeacher.LastName;

                List<string> courseIds = collection["Courses"].ToList();
                foreach (string courseId in courseIds)
                {
                    CourseModel course = courseService.Get(courseId);
                    newTeacher.Courses.Add(course);
                }

                teacherService.Create(newTeacher);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeacherController/Edit/5
        public ActionResult Edit(string id)
        {
            List<CourseModel> courses = courseService.Get();
            MultiSelectList coursesList = new MultiSelectList(courses, "Id", "CourseName");
            ViewData["courses"] = coursesList;
            return View(teacherService.Get(id));
        }

        // POST: TeacherController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                TeacherModel tempTeacher = teacherService.Get(id);

                tempTeacher.Id = id;
                tempTeacher.FirstName = collection["Firstname"];
                tempTeacher.LastName = collection["LastName"];
                tempTeacher.Birthdate = collection["Birthdate"];
                tempTeacher.Gender = collection["Gender"];
                tempTeacher.Township = collection["Township"];
                tempTeacher.PostalCode = Int32.Parse(collection["PostalCode"]);
                tempTeacher.Address = collection["Address"];
                tempTeacher.PhoneNumber = collection["PhoneNumber"];
                tempTeacher.Email = collection["Email"];
                tempTeacher.FullName = tempTeacher.FirstName + " " + tempTeacher.LastName;

                tempTeacher.Courses.Clear();

                List<string> courses = collection["Courses"].ToList();
                foreach (string course in courses)
                {
                    tempTeacher.Courses.Add(courseService.Get(course));
                }

                teacherService.Update(id, tempTeacher);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeacherController/Delete/5
        public ActionResult Delete(string id)
        {
            teacherService.Remove(id);

            return RedirectToAction(nameof(Index));
        }

        // POST: TeacherController/Delete/5
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
