using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            EmployeeModels employee = new EmployeeModels();
            employee.EmployeeID = 1;
            employee.Name = "Mani";
            employee.City = "Hyderabad";
            employee.sex = "Male";
            return View(employee);
        }

    }
}
