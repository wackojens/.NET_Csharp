using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvcSchool.Models;

namespace mvcSchool.Controllers
{
    public class TeacherController : Controller
    {
        // GET: TeacherController
        public ActionResult Index()
        {
            return View(TeacherModel.GetAll());
        }

        // GET: TeacherController/Details/5
        public ActionResult Details(string id)
        {
            TeacherModel newTeacher = TeacherModel.GetTeacher(id);
            //ViewData["courseNames"] = newTeacher.StringCourseNames();
            return View(newTeacher);
        }

        // GET: TeacherController/Create
        public ActionResult Create()
        {
            List<CourseModel> courses = CourseModel.GetAll();
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
                newTeacher.Courses = collection["Courses"].ToList();

                TeacherModel.AddTeacher(newTeacher);

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
            List<CourseModel> courses = CourseModel.GetAll();
            MultiSelectList coursesList = new MultiSelectList(courses, "Id", "CourseName");
            ViewData["courses"] = coursesList;
            return View(TeacherModel.GetTeacher(id));
        }

        // POST: TeacherController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                TeacherModel newTeacher = new();

                newTeacher.Id = id;
                newTeacher.FirstName = collection["Firstname"];
                newTeacher.LastName = collection["LastName"];
                newTeacher.Birthdate = collection["Birthdate"];
                newTeacher.Gender = collection["Gender"];
                newTeacher.Township = collection["Township"];
                newTeacher.PostalCode = Int32.Parse(collection["PostalCode"]);
                newTeacher.Address = collection["Address"];
                newTeacher.PhoneNumber = collection["PhoneNumber"];
                newTeacher.Email = collection["Email"];
                newTeacher.Courses = collection["Courses"].ToList();

                TeacherModel.UpdateTeacher(newTeacher);

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
            TeacherModel.Delete(id);
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
