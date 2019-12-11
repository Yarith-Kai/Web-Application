using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        EmployeeDB empDB = new EmployeeDB();
        public JsonResult List()
        {
            return Json(empDB.ListAll(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Add_new()
        {
            return View();
        }
        public JsonResult Add(Employee emp)
        {
            return Json(empDB.Add(emp), JsonRequestBehavior.AllowGet);
        }
    }
}