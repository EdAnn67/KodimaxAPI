using KodimaxAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KodimaxAPI.Controllers
{
    public class GolosinaController : Controller
    {
        // GET: Golosina
        public ActionResult Golosinas()
        {
            KodimaxContext db = new KodimaxContext();
            return View(db.Golosina.ToList());
        }
    }
}