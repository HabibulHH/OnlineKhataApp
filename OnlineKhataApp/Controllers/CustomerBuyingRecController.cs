using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineKhataApp.Models;
using OnlineKhataApp.Context;

namespace OnlineKhataApp.Controllers
{
    public class CustomerBuyingRecController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: /CustomerBuyingRec/
        public ActionResult Index()
        {
            var customer = db.CustomersBuyingRecords.ToList();
            
            return View(customer.OrderByDescending(x => x.Date.Day));
        }

        // GET: /CustomerBuyingRec/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomersBuyingRecord customersbuyingrecord = db.CustomersBuyingRecords.Find(id);
            if (customersbuyingrecord == null)
            {
                return HttpNotFound();
            }
            return View(customersbuyingrecord);
        }

        // GET: /CustomerBuyingRec/Create
        public ActionResult Create()
        {
            ViewBag.Customers = db.Customers.ToList();
            return View();
        }

        // POST: /CustomerBuyingRec/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Date,CustomerId,Amount")] CustomersBuyingRecord customersbuyingrecord)
        {
            if (ModelState.IsValid)
            {
                db.CustomersBuyingRecords.Add(customersbuyingrecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customersbuyingrecord);
        }

        // GET: /CustomerBuyingRec/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomersBuyingRecord customersbuyingrecord = db.CustomersBuyingRecords.Find(id);
            if (customersbuyingrecord == null)
            {
                return HttpNotFound();
            }
            return View(customersbuyingrecord);
        }

        // POST: /CustomerBuyingRec/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Date,CustomerId,Amount")] CustomersBuyingRecord customersbuyingrecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customersbuyingrecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customersbuyingrecord);
        }

        // GET: /CustomerBuyingRec/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomersBuyingRecord customersbuyingrecord = db.CustomersBuyingRecords.Find(id);
            if (customersbuyingrecord == null)
            {
                return HttpNotFound();
            }
            return View(customersbuyingrecord);
        }

        // POST: /CustomerBuyingRec/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomersBuyingRecord customersbuyingrecord = db.CustomersBuyingRecords.Find(id);
            db.CustomersBuyingRecords.Remove(customersbuyingrecord);
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
