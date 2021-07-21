using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaDeAula.Pages
{

    public class IndexModel : PageModel
    {
        public Random aleatorio = new Random(); //criando um objeto Random
        public int numero; //definindo variavel
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            numero = aleatorio.Next(1, 100);
        }

    }
}
