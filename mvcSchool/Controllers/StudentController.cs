using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvcSchool.Models;

namespace mvcSchool.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public ActionResult Index()
        {
            return View(StudentModel.GetAll());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            List<CourseModel> courses = CourseModel.GetAll();
            // SelectList coursesList = new SelectList(courses.Select(c => new SelectListItem { Text = c.CourseName, Value = c.Id }).ToList());
            MultiSelectList coursesList = new MultiSelectList(courses, "Id", "CourseName");
            ViewData["courses"] = coursesList;
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                StudentModel newStudent = new();

                newStudent.FirstName = collection["Firstname"];
                newStudent.LastName = collection["LastName"];
                newStudent.Birthdate = collection["Birthdate"];
                newStudent.Gender = collection["Gender"];
                newStudent.Township = collection["Township"];
                newStudent.PostalCode = Int32.Parse(collection["PostalCode"]);
                newStudent.Address = collection["Address"];
                newStudent.PhoneNumber = collection["PhoneNumber"];
                newStudent.Email = collection["Email"];

                StudentModel.AddStudent(newStudent);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(string id)
        {
            return View(StudentModel.GetStudent(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                StudentModel newStudent = new();

                newStudent.Id = id;
                newStudent.FirstName = collection["Firstname"];
                newStudent.LastName = collection["LastName"];
                newStudent.Birthdate = collection["Birthdate"];
                newStudent.Gender = collection["Gender"];
                newStudent.Township = collection["Township"];
                newStudent.PostalCode = Int32.Parse(collection["PostalCode"]);
                newStudent.Address = collection["Address"];
                newStudent.PhoneNumber = collection["PhoneNumber"];
                newStudent.Email = collection["Email"];

                StudentModel.UpdateStudent(newStudent);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(string id)
        {
            StudentModel.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
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
