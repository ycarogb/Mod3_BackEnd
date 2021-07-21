using System;
using System.Collections.Generic;
using System.Linq;

//###Exercicios CODELAB

//1

//Console.WriteLine("### CALCULADORA DE FATORIAIS");
//Console.WriteLine(" ");
//Console.WriteLine("Digite um número:");
//int numero = (int)Convert.ToInt64(Console.ReadLine());

//long fatorial = 1;

//for (int i = 1; i <= numero ; i++)
//{
//    fatorial = fatorial * i;
//}

//Console.WriteLine($"O fatorial deste número é: {fatorial}!");

//2

//Console.WriteLine("Digite o tamanho da lista que deseja: ");
//int tamanho = Convert.ToInt32(Console.ReadLine());
//List <int> numeros = new List <int>{ };


//for (int n = 1; n <= tamanho; n++)
//{
//    Console.WriteLine($"Digite o {n}º item da lista.");
//    int item = Convert.ToInt32(Console.ReadLine());
//    numeros.Add(item);
//}

//int maximo = numeros.Max();

//Console.WriteLine($"O maior valor nessa lista é: {maximo}.");

//3 Algoritmo para definir um array de números com tamanho e valoresdefinidos pelo usuário e apresentá lo em tela ordenado de forma crescente

//Console.WriteLine("Qual tamanho da sua lista?");
//int tam = Convert.ToInt32(Console.ReadLine()); //sempre lembrar de converter o input do usuário em um número inteiro ou double, quando for o caso

//int[] array = new int [tam]; //criando uma aray vazia

//for (int i = 1; i<=tam; i++)
//{
//    Console.WriteLine($"Digite o {i}º valor da sua lista:");
//    int item = Convert.ToInt32(Console.ReadLine());
//    array[i-1] = item;
//}

//Console.WriteLine(array);
//Array.Sort(array); //organiza em ordem ascendente a array
//Console.WriteLine("os números digitados foram: ");

//foreach (int i in array)
//{
//    Console.WriteLine(i);
//}

//4 Altere o algoritmo anterior para que os números sejam inseridos no array aleatoriamente utilizar o objeto Random A aplicação também deve apresentar o número que tem a maior frequência
//Console.WriteLine("Qual tamanho da sua lista?");
//int tam = Convert.ToInt32(Console.ReadLine()); //sempre lembrar de converter o input do usuário em um número inteiro ou double, quando for o caso

//int[] array = new int [tam]; //criando uma aray vazia

//for (int i = 1; i<=tam; i++)
//{
//    Random aleatorio = new Random(); //instanciando o numero aleatorio a ser gerado e inserido na array 
//    int item = aleatorio.Next(1, tam); //A função next traz um número aleatório entre dois parâmetros - o número inicial e outro final
//    array[i-1] = item;
//}

//int moda = 0;

//int ocorrencias = 0;


//for (int i = 0; i < array.Length; i++)
//{
//    int contador = 1;

//    foreach (int x in array)
//    {
//        if (array[x + 1] == array[i])
//        {
//            contador++;
//        }
//    }

//    if (contador > ocorrencias)
//    {
//        moda = array [i];
//        ocorrencias = contador;
//    }
   
//}

//Console.WriteLine("Os elementos da lista são");
//foreach (int x in array)
//{
//    Console.WriteLine(array[x]);
//}

//Console.WriteLine(" ");
//Console.WriteLine($"O número que aparece com mais frequência é {moda}, aparecendo {ocorrencias} vezes!");

