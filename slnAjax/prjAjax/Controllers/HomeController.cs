using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using prjAjax.Models;

namespace prjAjax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
            public ActionResult Cross()
        {
            var webClient = new WebClient();
            byte[] bResult = webClient.DownloadData(@"https://data.coa.gov.tw/Service/OpenData/ODwsv/ODwsvAttractions.aspx");
            string json = Encoding.UTF8.GetString(bResult);
            List<Farm> farms = JsonConvert.DeserializeObject<List<Farm>>(json);
            return View(farms);
        }
    }
}