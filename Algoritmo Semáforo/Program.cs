using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cor do semáforo (Vermelho,Amarelo ou Verde): ");
            string cor = (Console.ReadLine());

            if(cor == "Vermelho"){
                Console.WriteLine("Pare o Carro");
            }
            else if(cor == "Amarelo"){
                Console.WriteLine("Desacelere até parar o Carro");
            }
            else{
                Console.WriteLine("Prossiga");
            }
        }
    }
}
