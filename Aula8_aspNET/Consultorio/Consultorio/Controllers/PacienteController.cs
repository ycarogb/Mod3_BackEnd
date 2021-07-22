using Consultorio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    public class PacienteController : Controller
    {
        public List<Paciente> pacientes = new List<Paciente>();
        public IActionResult Index()
        {
            pacientes.Add(new Paciente { Id = 1, Nome = "Mauro Rodriguez" });
            pacientes.Add(new Paciente { Id = 2, Nome = "Blanca Evangelista" });
            ViewBag.pacientes = pacientes;
            return View();
        }
    }
}
