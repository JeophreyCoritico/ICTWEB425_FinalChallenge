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
    public class C102575814CustomerController : Controller
    {
        private DADEntities1 db = new DADEntities1();

        // GET: C102575814Customer
        public ActionResult Index()
        {
            var c102575814Customer = db.C102575814Customer.Include(c => c.C102575814Interest);
            return View(c102575814Customer.ToList());
        }

        // GET: C102575814Customer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Customer c102575814Customer = db.C102575814Customer.Find(id);
            if (c102575814Customer == null)
            {
                return HttpNotFound();
            }
            return View(c102575814Customer);
        }

        // GET: C102575814Customer/Create
        public ActionResult Create()
        {
            ViewBag.InterestCode = new SelectList(db.C102575814Interest, "InterestCode", "InterestDesc");
            return View();
        }

        // POST: C102575814Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustNo_,CustName,CustAddress,CustPcode,InterestCode")] C102575814Customer c102575814Customer)
        {
            if (ModelState.IsValid)
            {
                db.C102575814Customer.Add(c102575814Customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InterestCode = new SelectList(db.C102575814Interest, "InterestCode", "InterestDesc", c102575814Customer.InterestCode);
            return View(c102575814Customer);
        }

        // GET: C102575814Customer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Customer c102575814Customer = db.C102575814Customer.Find(id);
            if (c102575814Customer == null)
            {
                return HttpNotFound();
            }
            ViewBag.InterestCode = new SelectList(db.C102575814Interest, "InterestCode", "InterestDesc", c102575814Customer.InterestCode);
            return View(c102575814Customer);
        }

        // POST: C102575814Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustNo_,CustName,CustAddress,CustPcode,InterestCode")] C102575814Customer c102575814Customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c102575814Customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InterestCode = new SelectList(db.C102575814Interest, "InterestCode", "InterestDesc", c102575814Customer.InterestCode);
            return View(c102575814Customer);
        }

        // GET: C102575814Customer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C102575814Customer c102575814Customer = db.C102575814Customer.Find(id);
            if (c102575814Customer == null)
            {
                return HttpNotFound();
            }
            return View(c102575814Customer);
        }

        // POST: C102575814Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            C102575814Customer c102575814Customer = db.C102575814Customer.Find(id);
            db.C102575814Customer.Remove(c102575814Customer);
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
