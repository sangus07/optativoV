using Soporte.Context;
using Soporte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace Soporte.Controllers
{
     
    public class ClienteController : Controller
    {
        private SoporteContext db = new SoporteContext();
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = db.Cliente.Include(p => p.Categoria);

            return View(cliente.ToList());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.IdCategoria = new SelectList(db.Categorias, "IdCategoria", "Descripcion");
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente Cliente)
        {
            try
            {
                ViewBag.IdCategoria = new SelectList(db.Categorias, "IdCategoria", "Descripcion");

                // TODO: Add insert logic here
                db.Cliente.Add(Cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(Cliente);
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            Cliente cliente = db.Cliente.Find(id);
             
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente Cliente)
        {
            try
            {
                db.Entry(Cliente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View(Cliente);
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
