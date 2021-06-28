using prjMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student {Id=1001,Name="小新",Chinese=80,English=78,Math=88},
                new Student {Id=1002,Name="小葵",Chinese=53,English=67,Math=35},
                new Student {Id=1003,Name="美冴",Chinese=96,English=74,Math=54},
                new Student {Id=1004,Name="小白",Chinese=97,English=86,Math=91},
                new Student {Id=1005,Name="廣志",Chinese=73,English=68,Math=95},
            };
            return View();
        }
    }
}