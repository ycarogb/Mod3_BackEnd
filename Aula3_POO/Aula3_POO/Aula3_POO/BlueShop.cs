using System;
using System.Collections.Generic;

namespace Aula3_POO
{
    public class BlueShop
    {
        List<Produto> produtos = new List<Produto>();
        public void Iniciar()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Cadastrar um produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("0 - Sair da aplicação");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrodeProdutos();
                    break;
                case "2":
                    ListarProdutos();
                    break;
                case "0":
                    break;
                default:
                    return;
            }

            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadKey(); //pega qualquer tecla digitada
            Console.Clear(); // Limpa a tela
            Iniciar();
        }

        void CadastrodeProdutos()
        {
            Produto produto = new Produto();

            Console.WriteLine("Infome um nome para o novo produto:");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Infome um preço para o novo produto:");
            produto.Preco = Convert.ToDouble(Console.ReadLine());

            produtos.Add(produto);
            Console.WriteLine($"O produto {produto.Nome} foi adicionado com sucesso!! ");
        }

        void ListarProdutos()
        {
            foreach (Produto p in produtos)
            {
                Console.WriteLine("--");
                Console.WriteLine(p.Descricao);
            }
        }
    }
}
