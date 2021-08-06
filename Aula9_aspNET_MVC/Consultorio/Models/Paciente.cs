using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Paciente
    {
        [Display (Name = "#")] //Mostra este nome em todos os métodos que utilizam/mostram este parâmetro
        public int Id { get; set; }

        [Display(Name = "Nome do Paciente")]
        public string Nome { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)] //Muda o formato da data
        public DateTime? Nascimento { get; set; }
    }
}
