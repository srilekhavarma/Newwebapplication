using Newwebapplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Newwebapplication.Controllers
{
    public class EmployerController : Controller
    {
        // GET: Employer
        public ActionResult Index()
        {
            return View();
        }
        public string GetName() 
        {
            return "Helo srilekha";
        }
        public int GetNumber()
        {
            return 111;

        }
        public ActionResult Getmydata()
        {

            return View();
        
        }

        public string Getmedata( int id) // gets the o/p as hello1 if we give the id as 1 in the url
        {
            return "Hello" + id;
        }

        public string Getmevalue(int? id=null) //gets string hello o/p and id is null value
        {
            return "Hello" + id;
        }

        // By using the query string we can add multiple parameters if I dont want to add in route.config file

        public string Getmedetails(string id , string name) // gets the o/p as hello1 if we give the id as 1 in the url
        {
            return id+ "," + Request.QueryString["name"]+"," + Request.QueryString["designation"];
        }


        public ActionResult GetmeView() // different method to acces another view page
        {
            return View("Getmedetails");
        }

        public ActionResult senddata()
        {
            List < EmployeeDetails > listobj = new List<EmployeeDetails>();

            EmployeeDetails obj = new EmployeeDetails();
            obj.EmpId = 1111;
            obj.Empname = "siri";
            obj.Empsalary = 100000;

            EmployeeDetails obj1 = new EmployeeDetails();
            obj1.EmpId = 2222;
            obj1.Empname = "srikanth";
            obj1.Empsalary = 200000;

            EmployeeDetails obj2= new EmployeeDetails();
            obj2.EmpId = 3333;
            obj2.Empname = "trinnu";
            obj2.Empsalary = 300000;

            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);
            
            ViewBag.EmpDetails = listobj;
            return View();
        }

        public ActionResult GetDataViewModel()
        {
            EmpDep objedt = new EmpDep();
            EmployeeDetails objsiri = new EmployeeDetails();
            objsiri.EmpId = 1111;
            objsiri.Empname = "siri";
            objsiri.Empsalary = 100000;

            DepartmentDetails dt = new DepartmentDetails();
            dt.DeptId = 1212;
            dt.DeptName = "Dotnet";

            objedt.Emp = objsiri;
            objedt.Dept = dt;

            return View(objedt);
        }

        public ActionResult GetMultipleDataViewModel()
        {

            List<EmployeeDetails> listempobj = new List<EmployeeDetails>();
            List<DepartmentDetails> listdeptobj = new List<DepartmentDetails>();



            EmpDeplist objedt = new EmpDeplist();
            EmployeeDetails objsiri = new EmployeeDetails();
            objsiri.EmpId = 1111;
            objsiri.Empname = "siri";
            objsiri.Empsalary = 100000;

            EmployeeDetails objprasanna = new EmployeeDetails();
            objprasanna.EmpId = 2222;
            objprasanna.Empname = "Prasanna";
            objprasanna.Empsalary = 200000;

            DepartmentDetails dt = new DepartmentDetails();
            dt.DeptId = 1212;
            dt.DeptName = "Dotnet";

            DepartmentDetails dt1 = new DepartmentDetails();
            dt1.DeptId = 1213;
            dt1.DeptName = "Java";

            listempobj.Add(objsiri);
            listempobj.Add(objprasanna);
            listdeptobj.Add(dt);
            listdeptobj.Add(dt1);

            objedt.Emp = listempobj;
            objedt.Dept = listdeptobj;

            return View(objedt);
        }




    }
    }