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
    public class StudentdeptsController : Controller
    {
        private Studentcontext db = new Studentcontext();

        // GET: Studentdepts
        public ActionResult Index()
        {
            return View(db.Studentdepts.ToList());
        }

        // GET: Studentdepts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studentdept studentdept = db.Studentdepts.Find(id);
            if (studentdept == null)
            {
                return HttpNotFound();
            }
            return View(studentdept);
        }

        // GET: Studentdepts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studentdepts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentdeptId,Deptname")] Studentdept studentdept)
        {
            if (ModelState.IsValid)
            {
                db.Studentdepts.Add(studentdept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentdept);
        }

        // GET: Studentdepts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studentdept studentdept = db.Studentdepts.Find(id);
            if (studentdept == null)
            {
                return HttpNotFound();
            }
            return View(studentdept);
        }

        // POST: Studentdepts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentdeptId,Deptname")] Studentdept studentdept)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentdept).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentdept);
        }

        // GET: Studentdepts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Studentdept studentdept = db.Studentdepts.Find(id);
            if (studentdept == null)
            {
                return HttpNotFound();
            }
            return View(studentdept);
        }

        // POST: Studentdepts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Studentdept studentdept = db.Studentdepts.Find(id);
            db.Studentdepts.Remove(studentdept);
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
