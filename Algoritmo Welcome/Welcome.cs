using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            string resultado = "Bem Vindo " + nome;

            Console.WriteLine(resultado);
        }
    }
}
