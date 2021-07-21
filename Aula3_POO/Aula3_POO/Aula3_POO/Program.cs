using System; //0 'using' chama um conjunto de funções externas para serem aplicadas em determinado programa


namespace Aula3_POO
{
    public class Program //conjunto de métodos 
    {
       static void Main(string[] args) //método - funções que caracterizam funções
        {
            BlueShop blueShop = new BlueShop(); // instanciando um objeto
            blueShop.Iniciar();
        }
        // o termo public prmite que seja utilizado em outro programa
        //public int subtracao(int numero1, int numero2) //método - funções que caracterizam funções
        //{
        //    return numero1 - numero2;
        //}

    }
}

//class Teste //conjunto de métodos 
//{
//    int soma(int numero1, int numero2)
//    {
//        return numero1 + numero2;
//    }

//}
//int soma(int numero1, int numero2)
//{
//    return numero1 + numero2;
//}

//Console.WriteLine(soma(2, 1));

//void imprimir()
//{
//    Console.WriteLine("Imprimindo um texto");
//}

//namespace - conjunto de classes para termos escopos diferentes no codigo

//Para fazer um executável (.exe) sem interface com o usuário, podemos usar o comando args como parâmetro de função

//## Instanciar um objeto de uma classe

//Calculadora c = new Calculadora() -> o objeto c da classe calculadora