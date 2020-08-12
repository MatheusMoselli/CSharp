using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coords = Console.ReadLine().Split(' ');

            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);

            while (x != 0 && y != 0)
            {
                // Primeiro quadrante
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro quadrante!");
                // Segundo quadrante
                } else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo quadrante!");
                // Terceiro quadrante
                } else if (x < 0 && y < 0 )
                {
                    Console.WriteLine("Terceiro quadrante!");
                // Quarto quadrante
                } else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto quadrante!");
                }

                coords = Console.ReadLine().Split(' ');

                x = int.Parse(coords[0]);
                y = int.Parse(coords[1]);
            }
        }
    }
}
