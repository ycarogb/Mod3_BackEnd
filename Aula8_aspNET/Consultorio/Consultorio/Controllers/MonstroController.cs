using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio.Models;

namespace Consultorio.Controllers
{
    public class MonstroController : Controller
    {
        public List<Monstro> listaMonstros = new List<Monstro>();
        public IActionResult Index()
        {
            listaMonstros.Add(new Monstro { Id = 1, Nome = "BestaFera" });
            listaMonstros.Add(new Monstro { Id = 2, Nome = "Godzilla" });
            ViewBag.monstros = listaMonstros;
            return View();
        }
    }
}
