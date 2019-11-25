using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CM_API.Models;

namespace CM_API.Controllers
{
    public class C102575814InterestController : Controller
    {
        private DADEntities1 db = new DADEntities1();

        // GET: C102575814Interest
        public ActionResult Index()
        {
            return View(db.C102575814Interest.ToList());
        }

        // GET: C102575814Interest/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Interest c102575814Interest = db.C102575814Interest.Find(id);
            if (c102575814Interest == null)
            {
                return HttpNotFound();
            }
            return View(c102575814Interest);
        }

        // GET: C102575814Interest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: C102575814Interest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InterestCode,InterestDesc")] C102575814Interest c102575814Interest)
        {
            if (ModelState.IsValid)
            {
                db.C102575814Interest.Add(c102575814Interest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(c102575814Interest);
        }

        // GET: C102575814Interest/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Interest c102575814Interest = db.C102575814Interest.Find(id);
            if (c102575814Interest == null)
            {
                return HttpNotFound();
            }
            return View(c102575814Interest);
        }

        // POST: C102575814Interest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InterestCode,InterestDesc")] C102575814Interest c102575814Interest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c102575814Interest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c102575814Interest);
        }

        // GET: C102575814Interest/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Interest c102575814Interest = db.C102575814Interest.Find(id);
            if (c102575814Interest == null)
            {
                return HttpNotFound();
            }
            return View(c102575814Interest);
        }

        // POST: C102575814Interest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            C102575814Interest c102575814Interest = db.C102575814Interest.Find(id);
            db.C102575814Interest.Remove(c102575814Interest);
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
