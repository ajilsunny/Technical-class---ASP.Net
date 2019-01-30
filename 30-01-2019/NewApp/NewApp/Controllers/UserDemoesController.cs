using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewApp.Models;

namespace NewApp.Controllers
{
    public class UserDemoesController : Controller
    {
        private UserContext db = new UserContext();

        // GET: UserDemoes
        public ActionResult Index()
        {

        }

        // GET: UserDemoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDemo userDemo = db.UserDemos.Find(id);
            if (userDemo == null)
            {
                return HttpNotFound();
            }
            return View(userDemo);
        }

        // GET: UserDemoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserDemoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserDemoId,Username,Password")] UserDemo userDemo)
        {
            if (ModelState.IsValid)
            {
                db.UserDemos.Add(userDemo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userDemo);
        }

        // GET: UserDemoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDemo userDemo = db.UserDemos.Find(id);
            if (userDemo == null)
            {
                return HttpNotFound();
            }
            return View(userDemo);
        }

        // POST: UserDemoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserDemoId,Username,Password")] UserDemo userDemo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userDemo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userDemo);
        }

        // GET: UserDemoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserDemo userDemo = db.UserDemos.Find(id);
            if (userDemo == null)
            {
                return HttpNotFound();
            }
            return View(userDemo);
        }

        // POST: UserDemoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserDemo userDemo = db.UserDemos.Find(id);
            db.UserDemos.Remove(userDemo);
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
