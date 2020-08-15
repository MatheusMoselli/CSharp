using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um valor inteiro: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
