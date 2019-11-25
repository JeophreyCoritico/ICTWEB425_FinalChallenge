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
    public class C102575814RecordController : Controller
    {
        private DADEntities1 db = new DADEntities1();

        // GET: C102575814Record
        public ActionResult Index()
        {
            return View(db.C102575814Record.ToList());
        }

        // GET: C102575814Record/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Record c102575814Record = db.C102575814Record.Find(id);
            if (c102575814Record == null)
            {
                return HttpNotFound();
            }
            return View(c102575814Record);
        }

        // GET: C102575814Record/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: C102575814Record/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecordID,Title,Performer")] C102575814Record c102575814Record)
        {
            if (ModelState.IsValid)
            {
                db.C102575814Record.Add(c102575814Record);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(c102575814Record);
        }

        // GET: C102575814Record/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Record c102575814Record = db.C102575814Record.Find(id);
            if (c102575814Record == null)
            {
                return HttpNotFound();
            }
            return View(c102575814Record);
        }

        // POST: C102575814Record/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecordID,Title,Performer")] C102575814Record c102575814Record)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c102575814Record).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c102575814Record);
        }

        // GET: C102575814Record/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Record c102575814Record = db.C102575814Record.Find(id);
            if (c102575814Record == null)
            {
                return HttpNotFound();
            }
            return View(c102575814Record);
        }

        // POST: C102575814Record/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            C102575814Record c102575814Record = db.C102575814Record.Find(id);
            db.C102575814Record.Remove(c102575814Record);
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
