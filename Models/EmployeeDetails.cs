using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.MobileControls;
using System.Windows.Documents;

namespace Newwebapplication.Models
{
    public class EmployeeDetails
    {
        public int EmpId { get; set; }
        public string Empname { get; set; }
        public int Empsalary { get; set; }

    }

    public class DepartmentDetails
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
       

    }

    public class EmpDep
    {
        public EmployeeDetails Emp { get; set; }
        public DepartmentDetails Dept { get; set; }

    }

    public class EmpDeplist
    {
        public List<EmployeeDetails> Emp { get; set; }
        public List<DepartmentDetails> Dept { get; set; }

    }
}