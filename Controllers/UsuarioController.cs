using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SejaHeroi.Models;

namespace SejaHeroi.Controllers
{
    public class UsuarioController : BaseController
    {  
        // GET: Usuarios
        public override ActionResult Index()
        {
            
            return View(_SejaHeroiContext.Usuarios.ToList());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = _SejaHeroiContext.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            ViewBag.Perfil = TempData["Perfil"];
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioID,PerfilUsuario,Login,Senha,Email")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.UsuarioID = Guid.NewGuid();
                _SejaHeroiContext.Usuarios.Add(usuario);
                _SejaHeroiContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = _SejaHeroiContext.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioID,PerfilUsuario,Login,Senha,Email")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _SejaHeroiContext.Entry(usuario).State = EntityState.Modified;
                _SejaHeroiContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = _SejaHeroiContext.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Usuario usuario = _SejaHeroiContext.Usuarios.Find(id);
            _SejaHeroiContext.Usuarios.Remove(usuario);
            _SejaHeroiContext.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _SejaHeroiContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
