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
    public class KidsTodoesController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        // GET: KidsTodoes
        public ActionResult Index()
        {
            return View(db.KidsTodoes.ToList());
        }

        // GET: KidsTodoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KidsTodo kidsTodo = db.KidsTodoes.Find(id);
            if (kidsTodo == null)
            {
                return HttpNotFound();
            }
            return View(kidsTodo);
        }

        // GET: KidsTodoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KidsTodoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Description,CreatedDate,UpBy550,GodSpokeToMyHeart,JohnWentRun,JamesWentRun,PhilipWentRun,PhilipDidWeights,PhilipDid100WordsInMorning,PhilipDid1000Words,TwinsFightSchool,James100WordsStudy,John100WordsStudy,James5SkillsIXL,Hannah10SkillsIXL,HannahPiano,JamesRecord1PiecePiano,JohnRecord1PiecePiano,JamesRecordPianoScale130,JohnRecordPianoScale130")] KidsTodo kidsTodo)
        {
            if (ModelState.IsValid)
            {
                db.KidsTodoes.Add(kidsTodo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kidsTodo);
        }

        // GET: KidsTodoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KidsTodo kidsTodo = db.KidsTodoes.Find(id);
            if (kidsTodo == null)
            {
                return HttpNotFound();
            }
            return View(kidsTodo);
        }

        // POST: KidsTodoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Description,CreatedDate,UpBy550,GodSpokeToMyHeart,JohnWentRun,JamesWentRun,PhilipWentRun,PhilipDidWeights,PhilipDid100WordsInMorning,PhilipDid1000Words,TwinsFightSchool,James100WordsStudy,John100WordsStudy,James5SkillsIXL,Hannah10SkillsIXL,HannahPiano,JamesRecord1PiecePiano,JohnRecord1PiecePiano,JamesRecordPianoScale130,JohnRecordPianoScale130")] KidsTodo kidsTodo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kidsTodo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kidsTodo);
        }

        // GET: KidsTodoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KidsTodo kidsTodo = db.KidsTodoes.Find(id);
            if (kidsTodo == null)
            {
                return HttpNotFound();
            }
            return View(kidsTodo);
        }

        // POST: KidsTodoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KidsTodo kidsTodo = db.KidsTodoes.Find(id);
            db.KidsTodoes.Remove(kidsTodo);
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
