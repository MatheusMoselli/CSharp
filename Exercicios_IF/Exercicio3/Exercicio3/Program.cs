using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro valor: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 % number2 == 0 || number2 % number1 == 0)
            {
                Console.WriteLine("SÃO MÚLTIPLOS!");
            } else
            {
                Console.WriteLine("NÃO SÃO MÚLTIPLOS");
            }
        }
    }
}
