using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores você ira inserir: ");
            int values = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 1; i <= values; i++ )
            {
                Console.Write($"Insira o valor #{i}: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 10 && number <= 20)
                {
                    dentro++;
                } else
                {
                    fora++;
                }
            }

            Console.WriteLine($"in: {dentro}");
            Console.WriteLine($"out: {fora}");

        }
    }
}
