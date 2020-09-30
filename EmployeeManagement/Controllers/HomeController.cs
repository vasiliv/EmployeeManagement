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
        public HomeController()
        {

        }
        //public string Index()
        //{
        //    return "hello from MVC";
        //}
        public JsonResult Index()
        {
            return Json(new { id = 1, name = "Vasil"});
        }
    }
}
