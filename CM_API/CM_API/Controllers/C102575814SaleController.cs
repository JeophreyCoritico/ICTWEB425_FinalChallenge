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
    public class C102575814SaleController : Controller
    {
        private DADEntities1 db = new DADEntities1();

        // GET: C102575814Sale
        public ActionResult Index()
        {
            var c102575814Sale = db.C102575814Sale.Include(c => c.C102575814Customer).Include(c => c.C102575814Record);
            return View(c102575814Sale.ToList());
        }

        // GET: C102575814Sale/Details/5
        public ActionResult Details(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Sale c102575814Sale = db.C102575814Sale.Find(id);
            if (c102575814Sale == null)
            {
                return HttpNotFound();
            }
            return View(c102575814Sale);
        }

        // GET: C102575814Sale/Create
        public ActionResult Create()
        {
            ViewBag.CustNo_ = new SelectList(db.C102575814Customer, "CustNo_", "CustName");
            ViewBag.RecordID = new SelectList(db.C102575814Record, "RecordID", "Title");
            return View();
        }

        // POST: C102575814Sale/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DateRecorded,Price,CustNo_,RecordID,InterestCode")] C102575814Sale c102575814Sale)
        {
            if (ModelState.IsValid)
            {
                db.C102575814Sale.Add(c102575814Sale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustNo_ = new SelectList(db.C102575814Customer, "CustNo_", "CustName", c102575814Sale.CustNo_);
            ViewBag.RecordID = new SelectList(db.C102575814Record, "RecordID", "Title", c102575814Sale.RecordID);
            return View(c102575814Sale);
        }

        // GET: C102575814Sale/Edit/5
        public ActionResult Edit(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Sale c102575814Sale = db.C102575814Sale.Find(id);
            if (c102575814Sale == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustNo_ = new SelectList(db.C102575814Customer, "CustNo_", "CustName", c102575814Sale.CustNo_);
            ViewBag.RecordID = new SelectList(db.C102575814Record, "RecordID", "Title", c102575814Sale.RecordID);
            return View(c102575814Sale);
        }

        // POST: C102575814Sale/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DateRecorded,Price,CustNo_,RecordID,InterestCode")] C102575814Sale c102575814Sale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c102575814Sale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustNo_ = new SelectList(db.C102575814Customer, "CustNo_", "CustName", c102575814Sale.CustNo_);
            ViewBag.RecordID = new SelectList(db.C102575814Record, "RecordID", "Title", c102575814Sale.RecordID);
            return View(c102575814Sale);
        }

        // GET: C102575814Sale/Delete/5
        public ActionResult Delete(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Sale c102575814Sale = db.C102575814Sale.Find(id);
            if (c102575814Sale == null)
            {
                return HttpNotFound();
            }
            return View(c102575814Sale);
        }

        // POST: C102575814Sale/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(DateTime id)
        {
            C102575814Sale c102575814Sale = db.C102575814Sale.Find(id);
            db.C102575814Sale.Remove(c102575814Sale);
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
