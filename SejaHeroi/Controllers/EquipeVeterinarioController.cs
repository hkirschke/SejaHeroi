using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SejaHeroi.Data;
using SejaHeroi.Models;

namespace SejaHeroi.Controllers
{
    public class EquipeVeterinarioController : Controller
    {
        private SejaHeroiContext db = new SejaHeroiContext();

        // GET: EquipeVeterinario
        public ActionResult Index()
        {
            return View(db.EquipeVeterinarios.ToList());
        }

        // GET: EquipeVeterinario/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipeVeterinario equipeVeterinario = db.EquipeVeterinarios.Find(id);
            if (equipeVeterinario == null)
            {
                return HttpNotFound();
            }
            return View(equipeVeterinario);
        }

        // GET: EquipeVeterinario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipeVeterinario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EquipeVeterinarioID,Nome")] EquipeVeterinario equipeVeterinario)
        {
            if (ModelState.IsValid)
            {
                equipeVeterinario.EquipeVeterinarioID = Guid.NewGuid();
                db.EquipeVeterinarios.Add(equipeVeterinario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipeVeterinario);
        }

        // GET: EquipeVeterinario/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipeVeterinario equipeVeterinario = db.EquipeVeterinarios.Find(id);
            if (equipeVeterinario == null)
            {
                return HttpNotFound();
            }
            return View(equipeVeterinario);
        }

        // POST: EquipeVeterinario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EquipeVeterinarioID,Nome")] EquipeVeterinario equipeVeterinario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipeVeterinario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipeVeterinario);
        }

        // GET: EquipeVeterinario/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipeVeterinario equipeVeterinario = db.EquipeVeterinarios.Find(id);
            if (equipeVeterinario == null)
            {
                return HttpNotFound();
            }
            return View(equipeVeterinario);
        }

        // POST: EquipeVeterinario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            EquipeVeterinario equipeVeterinario = db.EquipeVeterinarios.Find(id);
            db.EquipeVeterinarios.Remove(equipeVeterinario);
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
