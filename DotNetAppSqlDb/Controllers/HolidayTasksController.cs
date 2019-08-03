using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DotNetAppSqlDb.Models;

namespace DotNetAppSqlDb.Controllers
{
    public class HolidayTasksController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        // GET: HolidayTasks
        public ActionResult Index()
        {
            var holidayTasks = db.HolidayTasks.Include(h => h.User);
            return View(holidayTasks.ToList());
        }

        // GET: HolidayTasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HolidayTask holidayTask = db.HolidayTasks.Find(id);
            if (holidayTask == null)
            {
                return HttpNotFound();
            }
            return View(holidayTask);
        }

        // GET: HolidayTasks/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName");



            ViewBag.DateToday = DateTime.Now;
        



            return View();
        }

        // POST: HolidayTasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UpBy815,EntryDate,PhilipWordQuantity,JamesWordQuantity,JohnWordQuantity,PhilipLastRunDate,PhilipLastWeightsDate,PhilipLastCycleDate,UserID")] HolidayTask holidayTask)
        {
            if (ModelState.IsValid)
            {
                db.HolidayTasks.Add(holidayTask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", holidayTask.UserID);
            return View(holidayTask);
        }

        // GET: HolidayTasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HolidayTask holidayTask = db.HolidayTasks.Find(id);
            if (holidayTask == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", holidayTask.UserID);
            return View(holidayTask);
        }

        // POST: HolidayTasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UpBy815,EntryDate,PhilipWordQuantity,JamesWordQuantity,JohnWordQuantity,PhilipLastRunDate,PhilipLastWeightsDate,PhilipLastCycleDate,UserID")] HolidayTask holidayTask)
        {
            if (ModelState.IsValid)
            {
                db.Entry(holidayTask).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", holidayTask.UserID);
            return View(holidayTask);
        }

        // GET: HolidayTasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HolidayTask holidayTask = db.HolidayTasks.Find(id);
            if (holidayTask == null)
            {
                return HttpNotFound();
            }
            return View(holidayTask);
        }

        // POST: HolidayTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HolidayTask holidayTask = db.HolidayTasks.Find(id);
            db.HolidayTasks.Remove(holidayTask);
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
