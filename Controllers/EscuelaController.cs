using System;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace Curso_ASP.NET_Core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = ---;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Cens 65";
            escuela.Ciudad = "Villa Devoto - Ciudad de Buenos Aires";
            escuela.Pais = "Argentina";
            escuela.Dirección = "Mercedes 4002";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            ViewBag.CosaDinamica = "Villa Devoto";

            return View(escuela);
        }
    }
}