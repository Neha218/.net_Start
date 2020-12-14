using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2.PassDataFromControllerToView.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int MaritalStatus { get; set; }
        public bool IsEligibleForLoad { get; set; }
        public decimal Salary { get; set; }
    }
}