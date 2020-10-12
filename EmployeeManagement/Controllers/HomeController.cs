using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
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
        //public string Index()
        public ViewResult Index()
        {
            //return "hello from MVC";
            //return _employeeRepository.GetEmployee(1).Name;
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }
        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(1),
                PageTitle = "Employee Details"
            }; 
            Employee model = _employeeRepository.GetEmployee(1);
            //ViewData["Employee"] = model;
            //ViewData["PageTitle"] = "Employee Details";
            //ViewBag.Employee = model;
            //ViewBag.PageTitle = "Employee Details";
            //return View(model);
            return View(homeDetailsViewModel);
            //return View("Test");
            //return View("MyViews/Test.cshtml");
            //return View("~/MyViews/Test.cshtml");
        }
        //public JsonResult Index()
        //{
        //    return Json(new { id = 1, name = "Vasil"});            
        //}
    }
}
