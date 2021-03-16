using KodimaxAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KodimaxAPI.Controllers
{
    public class BoletoController : Controller
    {
        // GET: Boleto
        public ActionResult Boletos()
        {
            KodimaxContext db = new KodimaxContext();
            return View(db.Boleto.ToList());
        }
        public ActionResult ComprarBoleto()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult ComprarBoleto(Boleto B)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            try
            {
                using (var db = new KodimaxContext())
                {
                    db.Boleto.Add(B);
                    db.SaveChanges();
                    return RedirectToAction("Boletos");


                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al comprar boletos " + ex.Message);
                return View();
            }
        }
    }
}