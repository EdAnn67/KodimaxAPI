using KodimaxAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KodimaxAPI.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Usuarios()
        {
            KodimaxContext db = new KodimaxContext();
            return View(db.Usuario.Where(u => u.Cargo == 1).ToList());
        }
        public ActionResult Empleados()
        {
            KodimaxContext db = new KodimaxContext();
            return View(db.Usuario.Where(u => u.Cargo == 2).ToList());
        }
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Registrar(Usuario a)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            try
            {
                using (var db = new KodimaxContext())
                {
                    db.Usuario.Add(a);
                    db.SaveChanges();
                    return RedirectToAction("Usuarios");


                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al agregar Usuario " + ex.Message);
                return View();
            }
        }

        public ActionResult detalleUsuario(int id)
        {
            using (var db = new KodimaxContext())
            {
                Usuario U = db.Usuario.Find(id);
                return View(U);
            }
        }

        public ActionResult EditarUsuario(int id)
        {
            try
            {
                using (var db = new KodimaxContext())
                {
                    Usuario U = db.Usuario.Find(id);
                    return View(U);
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarUsuario(Usuario a)
        {
            try
            {
                using (var db = new KodimaxContext())
                {
                    Usuario D = db.Usuario.Find(a.Id);
                    

                    db.SaveChanges();
                    return View(D);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }



        public ActionResult EliminarUsuario(int id)
        {

            using (var db = new KodimaxContext())
            {
                Usuario D = db.Usuario.Find(id);
                db.Usuario.Remove(D);
                db.SaveChanges();
                return RedirectToAction("Usuarios");
            }


        }

    }
}