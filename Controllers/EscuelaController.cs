using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Curso_ASP.NET_Core.Models;

namespace Curso_ASP.NET_Core.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Cens 65";
            escuela.AñoDeCreación = 2022;
            escuela.Ciudad = "Buenos Aires";
            escuela.Pais = "Argentina";
            escuela.Dirección = "Salvador María del Carril 4172";
            escuela.TipoEscuela = TiposEscuela.Secundaria;


            ViewBag.CosaDinamica = "La Monja";
            
            return View(escuela);

        }
    }
}