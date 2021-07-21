using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWorld.NovaPasta;

namespace HelloWorld.Pages.NovaPasta
{
    public class IndexModel : PageModel
    {
        public List<Produto> produtos = new List<Produto>();
        public void OnGet()
        {
            carregarProdutos();
        }

        public void carregarProdutos()
        {
            var produto = new Produto {
                Nome = "Camisa",
                Preco = 100,
                Descricao = "Camisa de Praia"
            };
            var produto2 = new Produto {
                Nome = "Camisa",
                Preco = 100,
                Descricao = "Camisa de Praia"
            };
            produtos.Add(produto);
            produtos.Add(produto2);
        }
    }
}
