using _2.PassDataFromControllerToView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2.PassDataFromControllerToView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeID = 1,
                    EmployeeName = "Mark Smith",
                    Address = "London",
                    DateOfJoining = System.DateTime.Now,
                    MaritalStatus = 1,
                    IsEligibleForLoad = true,
                    Salary = 15000.00m
                },
                new Employee()
                {
                    EmployeeID = 2,
                    EmployeeName = "John Smith",
                    Address = "London",
                    DateOfJoining = System.DateTime.Now,
                    MaritalStatus = 0,
                    IsEligibleForLoad = true,
                    Salary = 25000.00m
                },
                new Employee()
                {
                    EmployeeID = 3,
                    EmployeeName = "Brain Lara",
                    Address = "London",
                    DateOfJoining = System.DateTime.Now,
                    MaritalStatus = 1,
                    IsEligibleForLoad = true,
                    Salary = 20000.00m
                },
                new Employee()
                {
                    EmployeeID = 4,
                    EmployeeName = "Jo Biden",
                    Address = "London",
                    DateOfJoining = System.DateTime.Now,
                    MaritalStatus = 1,
                    IsEligibleForLoad = true,
                    Salary = 300000.00m
                },
                new Employee()
                {
                    EmployeeID = 5,
                    EmployeeName = "Ben Dunk",
                    Address = "London",
                    DateOfJoining = System.DateTime.Now,
                    MaritalStatus = 0,
                    IsEligibleForLoad = true,
                    Salary = 15000.00m
                }
            };
            ViewBag.Employees = employees;
            return View();
        }
    }
}