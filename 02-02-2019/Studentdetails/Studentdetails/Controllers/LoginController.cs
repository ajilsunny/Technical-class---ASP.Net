using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Studentdetails.Models;

namespace Studentdetails.Controllers
{
    public class LoginController : Controller
    {
        public Studentcontext db = new Studentcontext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Studentlogin sl)
        {
            var u = db.studentRegs.Where(x => x.Username == sl.Username & x.password == sl.password).FirstOrDefault();
            if (u == null)
            {
                ModelState.AddModelError("", "invalid username& password");
                return View();
            }
            return RedirectToAction("Index", "Studentdepts");
        }
    }
}