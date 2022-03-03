using System;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace Curso_ASP.NET_Core.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre="Programación"
            };

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View(asignatura);
        }
    }
}