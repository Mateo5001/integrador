using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerAppServices.Models;

namespace TallerAppServices.Controllers
{
    public class ElementosController : Controller
    {

        private inv001Entities db = new inv001Entities();
        // GET: Elementos
        public ActionResult lineas()
        {
            return View();
        }

        public ActionResult Tintas()
        {

            ViewBag.idLinea = new SelectList(db.lineas, "idLinea", "nombreLinea");
            return View();
        }
    }
}