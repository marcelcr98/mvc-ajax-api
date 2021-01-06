using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Service;
using System.Web.Mvc;
using MvcAjax.Models;

namespace MvcAjax.Controllers
{
    public class StudentController : Controller
    {
        private StudentService service = new StudentService();

        // GET: Student

        public ActionResult IndexRazor()
        {
            var model = (from c in service.Get()
                         select new StudentModel
                         {
                             ID = c.studentID,
                             Address = c.studentAddress,
                             Code = c.studentCode,
                             LastName = c.studentLastName,
                             Name = c.studentName
                         }
                         ).ToList();

            return View(model);
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getStudent(string id)
        {
            return Json(service.Get(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult getStudentById(int id)
        {
            return Json(service.GetById(id), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult createStudent(Student std)
        {
            service.Insert(std);
            string message = "SUCCESS";
            return Json(new{ Message = message, JsonRequestBehavior.AllowGet });
        }

        [HttpPost]
        public JsonResult updateStudent(Student std, int id)
        {
            service.Update(std, id);
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        [HttpPost]
        public JsonResult deleteStudent(int id)
        {
            service.Delete(id);
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

    }
}