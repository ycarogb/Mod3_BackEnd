using System;
using System.Collections.Generic;

//É necessário definir o tipo de variável antes de declaralá-la;
//Não dá pra mudar o tipo da variável declarada

double valor= 10.33;
double taxaVenda = 1.00;
//É necessário transformar o tipo da variável para string
string mensagem = "O valor do produto é";

//Write Linr imprime um texto no console
Console.WriteLine(mensagem);

//Outr forma de imprimir
//Console.WriteLine($"{mensagem} : {valor + taxaVenda}");

//Obtendo input do usuário
//Console.WriteLine("Digite um produto: ");
//string produto = Console.ReadLine();

//Console.WriteLine("O produto digitado foi " + produto);
//Console.WriteLine("Informe o nome do produto: ");
//string produto = Console.ReadLine();

//Console.WriteLine("Informe o preço do produto: ");
//Toda a informção vinda do terminal, vem como string. É necessário converter para tipo double
//double valor = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"O produto digitado foi: {produto}. Que tem vale {valor}R$!!");

//arrays são listas no C#
//int [] numeros = new int[] {99, 98, 66, 77};

//Console.WriteLine(numeros[2]);

//List <string> nomes = new List<string> {"Felipe", "Maria", "João"};

//Console.WriteLine(nomes[1]);

//estruturas de controle e repetição
//Console.WriteLine("Informa a sua idade: ");
//string idade = Console.ReadLine();

//if (Convert.ToInt32(idade) >= 18)
//{
  //  Console.WriteLine("Maior de Idade");
    //Enquanto isso você pode incluir mais condições no bloco de comandos
    //if (Convert.ToInt32(idade) > 65)
     //   Console.WriteLine("Além disso, você é idoso!");
//}
//incluindo condições "continuadas"
//&& - equivale ao and
// || - equivale ao or
//else if(Convert.ToInt32(idade) > 12 && Convert.ToInt32(idade) > 16)
//{
//    Console.WriteLine("Você é um adolescente que pode votar");
//}
//else
//{
//    Console.WriteLine("Você é uma criança");
//}

//Operador ternário - condição booleana que me devolve um comando/valor ou outro

//string message = Convert.ToInt32(idade) > 17 ? "Você é maior de idade" : "Você é menor de idade";
//Console.WriteLine($"Sua idade é: {idade}, por isso {message}");

//##Estudar Switch##
//switch (opcao)
//{case: "n":
//comando
//break}

//Estruturas de repetição

//string opcao = " ";


//while (opcao != "1")
//{
    //Console.WriteLine("digite 1");
    //opcao = Console.ReadLine();
//}

//int num = 1;
//do{
    //Console.WriteLine(num);
   // num++;
//} while (num < 10);

//Percorrendo uma lista

//int [] numeros = new int [] {10 , 20 , 30 , 40};
//foreach(int n in numeros)
//{
   // Console.WriteLine(n);
//}

//utilizando o for você consegue criar iterações mais complexas
//for (int i = 0; i<3; i++)
//{
//    Console.WriteLine(i);
//}