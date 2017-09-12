using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarbageCollection.Models
{
    public class Employees
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "Route Number")]
        public int RouteNumber { get; set; }
    }
}