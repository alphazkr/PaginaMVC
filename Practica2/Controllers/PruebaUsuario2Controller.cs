using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica2.Models.Entity;

namespace Practica2.Controllers
{
    public class PruebaUsuario2Controller : Controller
    {
        // GET: PruebaUsuario2
        private UsuarioServices usu = new UsuarioServices();

        public ActionResult Index()
        {
            var lst = usu.mostrarUsuarios();
            return View(lst);
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        public ActionResult Mision()
        {
            return View();
        }


    }
}