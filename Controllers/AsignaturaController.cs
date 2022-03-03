using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Curso_ASP.NET_Core.Models;

namespace Curso_ASP.NET_Core.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación",
            };

            ViewBag.CosaDinamica = "La Monja";
            
            return View(asignatura);

        }
    }
}