using System;


var menu = true;
var opcao_menu = true;


Console.WriteLine("SISTEMA DE GESTÃO DE TURMAS");
Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#");
Console.WriteLine("MENU");

while (menu)
{
    int tamanho;
    string nome;
    string[] alunos = new string[tamanho];

    Console.WriteLine("1 - INSERIR TURMA");
    Console.WriteLine("2 - CADASTRAR ALUNOS");
    Console.WriteLine("0 - SAIR");
    Console.WriteLine("Digite sua opcao: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o nome da turma: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o tamanho da turma: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#");

            Console.WriteLine($"Turma {nome}, máximo de {tamanho} alunos, foi criada com sucesso!!");
            Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#--#");
            Console.WriteLine("DIGITE 0 PARA SAIR");
            var sair = Console.ReadLine();
            if(sair == "0")
            {
                opcao_menu = false;
            }
            break;

        case "2":
            int x = 0;
            while (x < tamanho)
            {
                Console.WriteLine("Digite o nome do Aluno(a): ");
                string nome_aluno = Console.ReadLine();
                alunos[x] = nome_aluno;
                x++;
            }
            break;




    }



}










