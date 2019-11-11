using HRMS_Web_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMS_Web_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TableDBContext DB = new TableDBContext();
            EmployeeDetails emp = new EmployeeDetails();
            emp.EmpName = "Ashwin Kumar";
            emp.Division = "ADM";
            emp.DesignationId = "701";
            emp.Designation = "HR";
            emp.Password = "pass";
            emp.Location = "Bangalore";
            emp.Email = "ashwin@ecanrys.com";
            DB.Employee1.Add(emp);
            DB.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}