using _2.PassDataFromControllerToView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2.PassDataFromControllerToView.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Student
        public ActionResult GetStudent()
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    StudentID = 1,
                    StudentName = "John Biden",
                    Address = "London"
                },
                new Student()
                {
                    StudentID = 2,
                    StudentName = "Jo Trump",
                    Address = "London"
                },
                new Student()
                {
                    StudentID = 3,
                    StudentName = "Jorge Smith",
                    Address = "London"
                },
                new Student()
                {
                    StudentID = 4,
                    StudentName = "Lara Biden",
                    Address = "London"
                },
                new Student()
                {
                    StudentID = 5,
                    StudentName = "Joseph Biden",
                    Address = "London"
                },
            };
            return View(students);
        }
    }
}