using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjMVC2020.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Div(float height, float weight)
        {
            
            height /= 100;
            ViewBag.height = height;
            ViewBag.weight = weight;
            ViewBag.op = "/";
            ViewBag.Result = weight/(height*height);
            return View("index");
        }
    }
}