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
    public class Todo2Controller : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        // GET: Todo2
        public ActionResult Index()
        {
            return View(db.Todos2.ToList());
        }

        // GET: Todo2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Todo2 todo2 = db.Todos2.Find(id);
            if (todo2 == null)
            {
                return HttpNotFound();
            }
            return View(todo2);
        }

        // GET: Todo2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todo2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Description,CreatedDate,Done,Done2")] Todo2 todo2)
        {
            if (ModelState.IsValid)
            {
                db.Todos2.Add(todo2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todo2);
        }

        // GET: Todo2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Todo2 todo2 = db.Todos2.Find(id);
            if (todo2 == null)
            {
                return HttpNotFound();
            }
            return View(todo2);
        }

        // POST: Todo2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Description,CreatedDate,Done,Done2")] Todo2 todo2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(todo2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todo2);
        }

        // GET: Todo2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Todo2 todo2 = db.Todos2.Find(id);
            if (todo2 == null)
            {
                return HttpNotFound();
            }
            return View(todo2);
        }

        // POST: Todo2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Todo2 todo2 = db.Todos2.Find(id);
            db.Todos2.Remove(todo2);
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
