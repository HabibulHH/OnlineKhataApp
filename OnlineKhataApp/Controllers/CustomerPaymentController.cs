using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineKhataApp.Models;
using OnlineKhataApp.Context;

namespace OnlineKhataApp.Controllers
{
    public class CustomerPaymentController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: /CustomerPayment/
        public ActionResult Index()
        {
            return View(db.CustomerPayments.ToList());
        }

        // GET: /CustomerPayment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerPayment customerpayment = db.CustomerPayments.Find(id);
            if (customerpayment == null)
            {
                return HttpNotFound();
            }
            return View(customerpayment);
        }

        // GET: /CustomerPayment/Create
        public ActionResult Create()
        {
            ViewBag.Customers = db.Customers.ToList();
            return View();
        }

        // POST: /CustomerPayment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Date,CustomerId,Amount")] CustomerPayment customerpayment)
        {
            if (ModelState.IsValid)
            {
                db.CustomerPayments.Add(customerpayment);
                db.SaveChanges();
                Customer customer = db.Customers.Find(customerpayment.CustomerId);
                customer.AccountRecivable = customer.AccountRecivable - customerpayment.Amount;
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerpayment);
        }

        // GET: /CustomerPayment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerPayment customerpayment = db.CustomerPayments.Find(id);
            if (customerpayment == null)
            {
                return HttpNotFound();
            }
            return View(customerpayment);
        }

        // POST: /CustomerPayment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Date,CustomerId,Amount")] CustomerPayment customerpayment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerpayment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerpayment);
        }

        // GET: /CustomerPayment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerPayment customerpayment = db.CustomerPayments.Find(id);
            if (customerpayment == null)
            {
                return HttpNotFound();
            }
            return View(customerpayment);
        }

        // POST: /CustomerPayment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerPayment customerpayment = db.CustomerPayments.Find(id);
            db.CustomerPayments.Remove(customerpayment);
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
