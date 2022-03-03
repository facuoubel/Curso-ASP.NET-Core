using System;
using System.Collections.Generic;

namespace Curso_ASP.NET_Core.Controllers
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}