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
    public class DailyCashFlowController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: /DailyCashFlow/
        public ActionResult Index()
        {
            return View(db.DailyCashFlows.ToList());
        }

        // GET: /DailyCashFlow/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyCashFlow dailycashflow = db.DailyCashFlows.Find(id);
            if (dailycashflow == null)
            {
                return HttpNotFound();
            }
            return View(dailycashflow);
        }

        // GET: /DailyCashFlow/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /DailyCashFlow/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Date,DailyShopCost,BariKhoroch,TransportLabourCost,CompanyPayment,PublicLoanBankPayment,PublicCashIn,DailySells")] DailyCashFlow dailycashflow)
        {
            if (ModelState.IsValid)
            {
                db.DailyCashFlows.Add(dailycashflow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailycashflow);
        }

        // GET: /DailyCashFlow/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyCashFlow dailycashflow = db.DailyCashFlows.Find(id);
            if (dailycashflow == null)
            {
                return HttpNotFound();
            }
            return View(dailycashflow);
        }

        // POST: /DailyCashFlow/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Date,DailyShopCost,BariKhoroch,TransportLabourCost,CompanyPayment,PublicLoanBankPayment,PublicCashIn,DailySells")] DailyCashFlow dailycashflow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailycashflow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailycashflow);
        }

        // GET: /DailyCashFlow/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyCashFlow dailycashflow = db.DailyCashFlows.Find(id);
            if (dailycashflow == null)
            {
                return HttpNotFound();
            }
            return View(dailycashflow);
        }

        // POST: /DailyCashFlow/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DailyCashFlow dailycashflow = db.DailyCashFlows.Find(id);
            db.DailyCashFlows.Remove(dailycashflow);
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
