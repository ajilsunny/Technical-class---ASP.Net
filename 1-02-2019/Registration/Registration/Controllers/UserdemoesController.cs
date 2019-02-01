using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class UserdemoesController : Controller
    {
        private Usercontext db = new Usercontext();

        // GET: Userdemoes
        public ActionResult Index()
        {
            return View(db.userdemos.ToList());
        }

        // GET: Userdemoes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userdemo userdemo = db.userdemos.Find(id);
            if (userdemo == null)
            {
                return HttpNotFound();
            }
            return View(userdemo);
        }

        // GET: Userdemoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Userdemoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserdemoId,uname,email,phone,password")] Userdemo userdemo)
        {
            if (ModelState.IsValid)
            {
                db.userdemos.Add(userdemo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userdemo);
        }

        // GET: Userdemoes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userdemo userdemo = db.userdemos.Find(id);
            if (userdemo == null)
            {
                return HttpNotFound();
            }
            return View(userdemo);
        }

        // POST: Userdemoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserdemoId,uname,email,phone,password")] Userdemo userdemo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userdemo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userdemo);
        }

        // GET: Userdemoes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userdemo userdemo = db.userdemos.Find(id);
            if (userdemo == null)
            {
                return HttpNotFound();
            }
            return View(userdemo);
        }

        // POST: Userdemoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Userdemo userdemo = db.userdemos.Find(id);
            db.userdemos.Remove(userdemo);
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
