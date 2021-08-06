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

        public IActionResult Create()
        {
            return View(getPacientes());
        }

        [HttpPost]
        public IActionResult Create(Paciente p) //Este método pega os dados de um objeto instanciado, que pertence a um modelo, e pode utilizá-lo 
        {
            List<Paciente> novoPaciente = getPacientes(); //cria uma lista com os componentes estáticos que estamos trabalhando
            novoPaciente.Add(p);
            return View("Index", novoPaciente); //o método retorna o método View com os dados da nova lista criada
        }

        public IActionResult Index(int id) // Pacientes/Index/3
        {
            //List<Paciente> TodosPacientes = getPacientes();
            //List<Paciente> pacientesFiltrados = new List<Paciente>();

            //foreach (Paciente p in TodosPacientes)
            //{
            //    if(p.Id == id)
            //    {
            //        pacientesFiltrados.Add(p);
            //    }
            //}
            //ViewBag.lista = id == 0 ? TodosPacientes : pacientesFiltrados;

            //Exemplo 2
            //List<Paciente> TodosPacientes = getPacientes();
            //ViewBag.lista = id == 0 ? TodosPacientes : TodosPacientes.FindAll(x => x.Id == id);

            //ViewBag.lista = id == 0 ? getPacientes() : getPacientes().FindAll(x => x.Id == id);
            return View(id == 0 ? getPacientes() : getPacientes().FindAll(x => x.Id == id));
        }

        List<Paciente> getPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();
            listaPacientes.Add(new Paciente { Id = 1, Nome = "Italo", Nascimento = new DateTime(2000, 7, 5)});
            listaPacientes.Add(new Paciente { Id = 2, Nome = "Eduardo", Nascimento = new DateTime(1995, 8, 30) });
            listaPacientes.Add(new Paciente { Id = 3, Nome = "Janio", Nascimento = new DateTime(2003, 1, 15) });
            return listaPacientes;
        }
    }
}
