using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TallerAppServices.Models;

namespace TallerAppServices.Controllers
{
    public class ConfiguracionController :  tiposDocumentosController
    {
        // GET: Configuracion
        private inv001Entities db = new inv001Entities();


        public ActionResult  creTD(int guardado =3)
        {

            ViewBag.AlertaGuardad = guardado;
            return View();
        }
    }
}