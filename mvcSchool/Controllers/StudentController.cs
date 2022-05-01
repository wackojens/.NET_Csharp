using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvcSchool.Models;
using mvcSchool.Services;

namespace mvcSchool.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService studentService;
        private readonly CourseService courseService;

        public StudentController(StudentService studentService, CourseService courseService)
        {
            this.studentService = studentService;
            this.courseService = courseService;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            return View(studentService.Get());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tempStudent = studentService.Get(id);
            if (tempStudent == null)
            {
                return NotFound();
            }

            return View(tempStudent);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            List<CourseModel> courses = courseService.Get();
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
                List<string> courseIds = new();

                newStudent.FirstName = collection["Firstname"];
                newStudent.LastName = collection["LastName"];
                newStudent.Birthdate = collection["Birthdate"];
                newStudent.Gender = collection["Gender"];
                newStudent.Township = collection["Township"];
                newStudent.PostalCode = Int32.Parse(collection["PostalCode"]);
                newStudent.Address = collection["Address"];
                newStudent.PhoneNumber = collection["PhoneNumber"];
                newStudent.Email = collection["Email"];
                newStudent.FullName = newStudent.FirstName + " " + newStudent.LastName;
                
                courseIds = collection["Courses"].ToList();
                foreach (string courseId in courseIds)
                {
                    CourseModel course = courseService.Get(courseId);
                    newStudent.Courses.Add(course);
                }
                studentService.AddCourses(newStudent);
                
                studentService.Create(newStudent);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(string id)
        {
            List<CourseModel> courses = courseService.Get();
            MultiSelectList coursesList = new MultiSelectList(courses, "Id", "CourseName");
            ViewData["courses"] = coursesList;
            return View(studentService.Get(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                StudentModel tempStudent = studentService.Get(id);

                tempStudent.FirstName = collection["Firstname"];
                tempStudent.LastName = collection["LastName"];
                tempStudent.Birthdate = collection["Birthdate"];
                tempStudent.Gender = collection["Gender"];
                tempStudent.Township = collection["Township"];
                tempStudent.PostalCode = Int32.Parse(collection["PostalCode"]);
                tempStudent.Address = collection["Address"];
                tempStudent.PhoneNumber = collection["PhoneNumber"];
                tempStudent.Email = collection["Email"];
                tempStudent.FullName = tempStudent.FirstName + " " + tempStudent.LastName;

                tempStudent.Courses.Clear();

                List<string> courses = collection["Courses"].ToList();
                foreach (string course in courses)
                {
                        tempStudent.Courses.Add(courseService.Get(course)); 
                }

                studentService.AddCourses(tempStudent);
                studentService.RemoveCourses(tempStudent);

                studentService.Update(id, tempStudent);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(string id)
        {
            studentService.Remove(id);

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
