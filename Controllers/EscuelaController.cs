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
            escuela.Nombre = "Facu Academy";
            escuela.AñoDeCreación = 2022;

            ViewBag.CosaDinamica = "La Monja";
            
            return View(escuela);

        }
    }
}