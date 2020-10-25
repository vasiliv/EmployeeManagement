using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    //[Route("Home")]
    //[Route("[controller]")]
    //[Route("[controller]/[action]")]
    
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        //[Route("")]
        //[Route("~/")]
        //[Route("~/Home")]
        //[Route("Home")]
        //[Route("Home/Index")]
        //[Route("Index")]
        //[Route("[action]")]
        //public string Index()
        public ViewResult Index()
        {
            //return "hello from MVC";
            //return _employeeRepository.GetEmployee(1).Name;
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }
        //[Route("Home/Details/{id?}")]
        //[Route("Details/{id?}")]
        //[Route("[action]/{id?}")]
        //[Route("{id?}")]
        //public ViewResult Details()
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                //Employee = _employeeRepository.GetEmployee(1),
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };
            //Employee model = _employeeRepository.GetEmployee(id);
            //Employee model = _employeeRepository.GetEmployee(1);
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
        public ViewResult Create()
        {
            return View();
        }
    }
}
