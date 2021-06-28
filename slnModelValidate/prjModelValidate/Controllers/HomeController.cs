using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjModelValidate.Models;

namespace prjModelValidate.Controllers
{
    public class HomeController : Controller
    {
        dbStudentEntities db = new dbStudentEntities();
        // GET: Home
        public ActionResult Index()
        {
            var students = db.tStudent.ToList();
            return View(students);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tStudent stu)
        {
            if (ModelState.IsValid)
            {
                db.tStudent.Add(stu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stu);
        }
        public ActionResult Delete(string id)
        {
            var stu = db.tStudent
                .Where(m => m.fStuId == id).FirstOrDefault();
            db.tStudent.Remove(stu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string id)
        {
            var stu = db.tStudent
                .Where(m => m.fStuId == id).FirstOrDefault();
            return View(stu);
        }
        [HttpPost]
        public ActionResult Edit
            (string fStuId, string fName, string fEmail, int fScore)
        {
            var stu = db.tStudent
                 .Where(m => m.fStuId == fStuId).FirstOrDefault();
            stu.fStuId = fStuId;
            stu.fName = fName;
            stu.fEmail = fEmail;
            stu.fScore = fScore;
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
