using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Studentdetails.Models;

namespace Studentdetails.Controllers
{
    public class StudentinfoesController : Controller
    {
        private Studentcontext db = new Studentcontext();

        // GET: Studentinfoes
        public ActionResult Index()
        {
            var studentinfoes = db.Studentinfoes.Include(s => s.Studentdept);
            return View(studentinfoes.ToList());
        }

        // GET: Studentinfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studentinfo studentinfo = db.Studentinfoes.Find(id);
            if (studentinfo == null)
            {
                return HttpNotFound();
            }
            return View(studentinfo);
        }

        // GET: Studentinfoes/Create
        public ActionResult Create()
        {
            ViewBag.StudentdeptId = new SelectList(db.Studentdepts, "StudentdeptId", "Deptname");
            return View();
        }

        // POST: Studentinfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentinfoId,StudentdeptId,studsubject,studmark")] Studentinfo studentinfo)
        {
            if (ModelState.IsValid)
            {
                db.Studentinfoes.Add(studentinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentdeptId = new SelectList(db.Studentdepts, "StudentdeptId", "Deptname", studentinfo.StudentdeptId);
            return View(studentinfo);
        }

        // GET: Studentinfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studentinfo studentinfo = db.Studentinfoes.Find(id);
            if (studentinfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentdeptId = new SelectList(db.Studentdepts, "StudentdeptId", "Deptname", studentinfo.StudentdeptId);
            return View(studentinfo);
        }

        // POST: Studentinfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentinfoId,StudentdeptId,studsubject,studmark")] Studentinfo studentinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentdeptId = new SelectList(db.Studentdepts, "StudentdeptId", "Deptname", studentinfo.StudentdeptId);
            return View(studentinfo);
        }

        // GET: Studentinfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studentinfo studentinfo = db.Studentinfoes.Find(id);
            if (studentinfo == null)
            {
                return HttpNotFound();
            }
            return View(studentinfo);
        }

        // POST: Studentinfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Studentinfo studentinfo = db.Studentinfoes.Find(id);
            db.Studentinfoes.Remove(studentinfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
