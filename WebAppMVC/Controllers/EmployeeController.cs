using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        static List<Employee> employees = new List<Employee>()
        {
            new Employee{ Id=1,Name="Sam",Designation="Manager",Salary=98000,DOJ=new DateTime(day:23,month:11,year:2019)},
            new Employee{ Id=2,Name="Ram",Designation="Manager",Salary=97000,DOJ=new DateTime(day:29,month:11,year:2018)},
            new Employee{ Id=3,Name="Ritu",Designation="Developer",Salary=76000,DOJ=new DateTime(day:28,month:11,year:2022)},
            new Employee{ Id=4,Name="Gaja",Designation="Tester",Salary=45000,DOJ=new DateTime(day:30,month:11,year:2022)},
            new Employee{ Id=5,Name="Sanju",Designation="Developer",Salary=38000,DOJ=new DateTime(day:12,month:11,year:2020)},
            new Employee{ Id=6,Name="Aditi",Designation="Developer",Salary=48000,DOJ=new DateTime(day:25,month:11,year:2021)},
            new Employee{ Id=9,Name="Srushti",Designation="HR",Salary=68000,DOJ=new DateTime(day:12,month:03,year:2022)},
            new Employee{ Id=10,Name="vikas",Designation="Developer",Salary=76000,DOJ=new DateTime(day:15,month:10,year:2023)},
            
        };
        public ActionResult Index()
        {
            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                employees.Add(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }
    }
}