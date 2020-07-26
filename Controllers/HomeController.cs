using Newwebapplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Newwebapplication.Controllers
{
    public class HomeController : Controller // controller is a class
    {
        // GET: Home
        // [NonAction--- will not be used as url]
        [Route("srilekha/mvc")]
        public string Index()  ///Index action Methods
        {
            return "Hello world";
        }
        public string Aboutus()  
        {
            return "About us page";
        }
        public ActionResult Contactus() /// action result is abstract class(parent) which can return multiple o/p
        {
            return View();  // used to return view pages
        }
        public ViewResult Career() /// view result is abstract class(child) which can return only view pages
        {
            return View();  // used to return view pages
        }

        public ActionResult About()
        {
            ViewBag.EmployeeName = "srilekha"; ///dynamic property, passing the value from controller to view
            ViewBag.EmployeeID = 333;
            return View();
        }
        public ActionResult Employee()
        {
            List<EmployeeDetails> listobj = new List<EmployeeDetails>(); //// for multiple employedetails we use list
          //  List<int> listobj = new List<int>();  stores only int values

            EmployeeDetails obj = new EmployeeDetails();
            obj.EmpId = 222;
            obj.Empname = "srilekha";
            obj.Empsalary = 30000;

            EmployeeDetails obj1 = new EmployeeDetails();
            obj1.EmpId = 333;
            obj1.Empname = "srikanth";
            obj1.Empsalary = 40000;

            EmployeeDetails obj2 = new EmployeeDetails();
            obj2.EmpId = 444;
            obj2.Empname = "sandeep";
            obj2.Empsalary = 50000;

            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);

            ViewBag.EmployeeDetails = listobj;

            return View();
        }




    }
}