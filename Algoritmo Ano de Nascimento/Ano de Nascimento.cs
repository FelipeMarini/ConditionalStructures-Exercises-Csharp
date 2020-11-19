using System;

namespace Ex_2_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor digite o seu ano de nascimento: ");
            int ano_nascimento = int.Parse(Console.ReadLine());
            int ano_atual = 2020;

            int idade = ano_atual - ano_nascimento;
            Console.WriteLine("Sua idade atual é " + idade + " anos");

            
            int idade_semanas =  idade * 48;
            Console.WriteLine("Sua idade atual é de " + idade_semanas + " semanas");
        }
    }
}
