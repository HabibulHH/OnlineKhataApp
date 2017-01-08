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
    public class DailySellsRecordController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: /DailySellsRecord/
        public ActionResult Index()
        {
            return View(db.DailySellsRecords.ToList());
        }

        // GET: /DailySellsRecord/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailySellsRecord dailysellsrecord = db.DailySellsRecords.Find(id);
            if (dailysellsrecord == null)
            {
                return HttpNotFound();
            }
            return View(dailysellsrecord);
        }

        // GET: /DailySellsRecord/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /DailySellsRecord/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Date,TotalSell,SellOnCash,SellsOnDue,Collection,AccountRecivable")] DailySellsRecord dailysellsrecord)
        {
            if (ModelState.IsValid)
            {
                db.DailySellsRecords.Add(dailysellsrecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailysellsrecord);
        }

        // GET: /DailySellsRecord/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailySellsRecord dailysellsrecord = db.DailySellsRecords.Find(id);
            if (dailysellsrecord == null)
            {
                return HttpNotFound();
            }
            return View(dailysellsrecord);
        }

        // POST: /DailySellsRecord/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Date,TotalSell,SellOnCash,SellsOnDue,Collection,AccountRecivable")] DailySellsRecord dailysellsrecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailysellsrecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailysellsrecord);
        }

        // GET: /DailySellsRecord/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailySellsRecord dailysellsrecord = db.DailySellsRecords.Find(id);
            if (dailysellsrecord == null)
            {
                return HttpNotFound();
            }
            return View(dailysellsrecord);
        }

        // POST: /DailySellsRecord/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DailySellsRecord dailysellsrecord = db.DailySellsRecords.Find(id);
            db.DailySellsRecords.Remove(dailysellsrecord);
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
