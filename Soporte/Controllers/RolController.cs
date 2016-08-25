using Microsoft.AspNet.Identity.EntityFramework;
using Soporte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soporte.Controllers
{
    public class RolController : Controller
    {
        ApplicationDbContext context;

        public RolController()
        {
            context = new ApplicationDbContext();
        }

        //

            [Authorize]
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }


        // GET: Rol/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rol/Create
     //   [Authorize(Roles ="ADMINISTRADOR")]
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }
        // POST: Rol/Create
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            try
            {
                if (User.IsInRole("ADMINISTRADOR"))
                {
                    context.Roles.Add(Role);
                    context.SaveChanges();
                   
                }
                else {
                    ViewBag.Error = "No Posee autorizacion";
                    return View(Role);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rol/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rol/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rol/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rol/Delete/5
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
