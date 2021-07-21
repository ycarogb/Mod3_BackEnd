using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SalaDeAula.Models;

namespace SalaDeAula.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        public List<Aluno> listaAlunos = new List<Aluno> ();
        public void OnGet()
        {
            carregarAlunos();
        }


        void carregarAlunos()
        {
            listaAlunos.Add(new Aluno
            {
                Id = 1,
                Nome = "João Rafael",
                Nascimento = "30/09/1995"
            });listaAlunos.Add(new Aluno
            {
                Id = 2,
                Nome = "Maria Eduarda",
                Nascimento = "15/04/1995"
            });

        }
    }
}
