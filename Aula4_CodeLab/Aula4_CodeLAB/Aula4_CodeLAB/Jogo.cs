using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_CodeLAB
{
    class Jogo
    {
        public void Iniciar() // o public é o que permite os métodos desse jogo serem acessados em outro lugar
        {
            Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#");
            Console.WriteLine("--- BEM-VINDO AO JOGO ---");
            Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#");
            Console.WriteLine("Digite o nome do personagem:");
            Heroi heroi = new Heroi(Console.ReadLine());


 
            Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#");
            Console.WriteLine("CARACTERÍSTICAS DO HERÓI");
            Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#");
            Console.WriteLine($"NOME: {heroi.nome}");
            Console.WriteLine($"EXPERIÊNCIA: {heroi.experiencia}");
            Console.WriteLine($"NÍVEL: {heroi.nivel}");
            Console.WriteLine($"VIDA: {heroi.vida}");
            Console.WriteLine($"ATAQUE: {heroi.ataqueBase}");

            var playing = true;

            while (playing)
            {
            Console.WriteLine("AGORA CHEGOU A HORA DE BATALHAR!!");
            Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#");
            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
            //Criando Objetos da classe Monstro
            Monstro orc = new Monstro("Orc", 2 * heroi.nivel, 2 * heroi.nivel + heroi.nivel, heroi.nivel);
            Monstro troll = new Monstro("Troll", 5 * heroi.nivel, 5 * heroi.nivel + 2 * heroi.nivel, 2 * heroi.nivel);
            Monstro goblin = new Monstro("Goblin", 10 * heroi.nivel, 10 * heroi.nivel + 4 * heroi.nivel, 4 * heroi.nivel);


            //Escolher Monstro
            Console.WriteLine("Escolha um oponente");
            Console.WriteLine("1 - ORC");
            Console.WriteLine("2 - TROLL");
            Console.WriteLine("3 - GOBLIN");
            Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#");
            Console.WriteLine("DIGITE SUA OPÇÃO:");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Você vai enfrentar o {orc.nome}!!");
                    Console.WriteLine($"ESCOLHA UMA OPÇÃO");
                    Console.WriteLine($"1 - FUGIR");
                    Console.WriteLine($"2 - LUTAR");
                    string opcao_batalha = Console.ReadLine();

                    switch (opcao_batalha)
                    {
                        case "1":
                            break;
                        case "2":
                            Lutar(orc);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine($"Você vai enfrentar o {troll.nome}!!");
                    Console.WriteLine($"ESCOLHA UMA OPÇÃO");
                    Console.WriteLine($"1 - FUGIR");
                    Console.WriteLine($"2 - LUTAR");
                    string opcao_batalha2 = Console.ReadLine();

                    switch (opcao_batalha2)
                    {
                        case "1":
                            break;
                        case "2":
                            Lutar(troll);
                            break;

                    }
                    break;
                case "3":
                    Console.WriteLine($"Você vai enfrentar o {goblin.nome}!!");
                    Console.WriteLine($"ESCOLHA UMA OPÇÃO");
                    Console.WriteLine($"1 - FUGIR");
                    Console.WriteLine($"2 - LUTAR");
                    string opcao_batalha3 = Console.ReadLine();

                    switch (opcao_batalha3)
                    {
                        case "1":
                            break;
                        case "2":
                            Lutar(goblin);
                            break;
                    }
                    break;
                }
                Console.WriteLine("Pressione alguma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

           
            

            void Lutar(Monstro monstro)
            {
                Console.Clear();
                monstro.vida -= heroi.ataqueBase;
                Console.WriteLine($"Você causou {monstro.vida - heroi.ataqueBase} de dano no monstro!");
                heroi.vida -= monstro.ataque;
                Console.WriteLine($"Você sofreu {heroi.vida - monstro.ataque} de dano!");

                if (monstro.vida > heroi.vida)
                {
                    Console.WriteLine("Você Morreu!");
                    playing = false;
                    return;
                }
                else
                {
                    heroi.experiencia = heroi.ganhaXP(monstro.experiencia);
                    int novo_nivel = (heroi.experiencia / 10) + 1;// analisar se o heroi sobre ou não de nível
                    if (novo_nivel > heroi.nivel)
                    {
                       heroi.nivel = novo_nivel;
                    }
                }
            }
        }
    }
}
