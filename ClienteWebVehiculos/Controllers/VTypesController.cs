using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClienteWebVehiculos.Models;
using PracticaVehiculos.Dominio;

namespace ClienteWebVehiculos.Controllers
{
    public class VTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: VTypes
        public ActionResult Index()
        {
            return View(db.VTypes.ToList());
        }

        // GET: VTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VType vType = db.VTypes.Find(id);
            if (vType == null)
            {
                return HttpNotFound();
            }
            return View(vType);
        }

        // GET: VTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] VType vType)
        {
            if (ModelState.IsValid)
            {
                db.VTypes.Add(vType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vType);
        }

        // GET: VTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VType vType = db.VTypes.Find(id);
            if (vType == null)
            {
                return HttpNotFound();
            }
            return View(vType);
        }

        // POST: VTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] VType vType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vType);
        }

        // GET: VTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VType vType = db.VTypes.Find(id);
            if (vType == null)
            {
                return HttpNotFound();
            }
            return View(vType);
        }

        // POST: VTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VType vType = db.VTypes.Find(id);
            db.VTypes.Remove(vType);
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
