using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    //public class HomeController
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            //return "hello from MVC";
            return _employeeRepository.GetEmployee(1).Name;
        }
        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            //return View(model);
            //return View("Test");
            //return View("MyViews/Test.cshtml");
            return View("~/MyViews/Test.cshtml");
        }
        //public JsonResult Index()
        //{
        //    return Json(new { id = 1, name = "Vasil"});            
        //}
    }
}
