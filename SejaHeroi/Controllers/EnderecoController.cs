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
    public class EnderecoController : BaseController
    {
        // GET: Endereco
        public override ActionResult Index()
        {
            return View(_SejaHeroiContext.Enderecoes.ToList());
        }

        // GET: Endereco/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endereco endereco = _SejaHeroiContext.Enderecoes.Find(id);
            if (endereco == null)
            {
                return HttpNotFound();
            }
            return View(endereco);
        }

        // GET: Endereco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Endereco/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioID,Bairro,Rua,CEP,Numero,Telefone,Celular,complemento")] Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                //endereco.UsuarioID = Guid.NewGuid();
                _SejaHeroiContext.Enderecoes.Add(endereco);
                _SejaHeroiContext.SaveChanges();
                AddNotificacaoSucesso("Endereço cadastrado");
                return RedirectToAction("Index");
            }

            return View(endereco);
        }

        // GET: Endereco/Edit/
        public ActionResult Edit()
        {
            var id = new Guid(Session["UsuarioID"].ToString());
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endereco endereco = _SejaHeroiContext.Enderecoes.Find(id);
            if (endereco == null)
            {
                endereco = new Endereco(id);
            }
            return View(endereco);
        }

        // POST: Endereco/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioID,Bairro,Rua,CEP,Numero,Telefone,Celular,complemento")] Endereco endereco)
        {
            var id = new Guid(Session["UsuarioID"].ToString());

            Endereco enderecoEncontrado = _SejaHeroiContext.Enderecoes.Find(id);
            if (ModelState.IsValid)
            {
                if (enderecoEncontrado == null)
                {
                    _SejaHeroiContext.Enderecoes.Add(endereco);
                    _SejaHeroiContext.SaveChanges();
                    AddNotificacaoSucesso("Endereço cadastrado");
                    return RedirectToAction("Edit");
                }
                else
                {
                    _SejaHeroiContext.SaveChanges();
                    AddNotificacaoSucesso("Endereço atualizado");
                    return RedirectToAction("Edit");
                }
            }

            return View(endereco);
        }

        public ActionResult Delete()
        {
            var id = new Guid(Session["UsuarioID"].ToString());
            Endereco endereco = _SejaHeroiContext.Enderecoes.Find(id);
            if (endereco == null)
            { 
                    AddNotificacaoAviso("Não há endereço cadastrado!");
                    return RedirectToAction("Edit"); 
            } 
            _SejaHeroiContext.Enderecoes.Remove(endereco);
            _SejaHeroiContext.SaveChanges();
            AddNotificacaoSucesso("Endereço excluído");
            return RedirectToAction("Edit");
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
