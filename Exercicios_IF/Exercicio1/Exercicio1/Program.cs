using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine($"O número {number} é negativo!");
            } else if (number > 0)
            {
                Console.WriteLine($"O número {number} é positivo");
            } else
            {
                Console.WriteLine("O número inserido é nulo!");
            }
        }
    }
}
