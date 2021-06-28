using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prj_Linq.Models;

namespace prj_Linq.Controllers
{
    public class LinqController : Controller
    {
        // GET: Linq
        public ActionResult ShowEmployeeByArea(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                var db = new NorthwindEntities();
                var result = db.員工
                    .Where(m => m.行政區.Contains(keyword))
                    .Select(m => new ViewEmployee()
                    {
                        EmpID = m.員工編號,
                        EmpName = m.姓名,
                        EmpGender = m.稱呼,
                        EmpTitle = m.職稱,
                        EmpArea = m.行政區
                    });
                return View(result.ToList());
            }
            else
            {
                return View(new List<ViewEmployee>());
            }
        }
    }
}
