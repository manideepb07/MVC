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

        public ActionResult Index(int departmentID)
        {
            EmployeeContext empContext = new EmployeeContext();
            List<EmployeeModels> empModel = empContext.Employee.Where(emp => emp.DepartmentID == departmentID).ToList();
            return View(empModel);
        }

        public ActionResult Details(int ID)
        {
            EmployeeContext empContext = new EmployeeContext();
            EmployeeModels empModel = empContext.Employee.Single(emp => emp.ID == ID);
            return View(empModel);
        }

    }
}
