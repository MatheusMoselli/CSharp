using System;
using System.Runtime.CompilerServices;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O programa perceberá se o número inserido é par ou ímpar! ");
            Console.Write("Insira o número desejado: ");

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"O número {number} é par!");
            } else if (number % 2 == 1 || number % 2 == -1)
            {
                Console.WriteLine($"O número {number} é ímpar");
            }
        }
    }
}
