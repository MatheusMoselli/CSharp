using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos testes você fará: ");
            int test = int.Parse(Console.ReadLine());

            for (int i = 1; i <= test; i++)
            {
                Console.Write($"Caso #{i}: ");
                string[] caso = Console.ReadLine().Split(' ');

                double value1 = double.Parse(caso[0], CultureInfo.InvariantCulture);
                double value2 = double.Parse(caso[1], CultureInfo.InvariantCulture);
                double value3 = double.Parse(caso[2], CultureInfo.InvariantCulture);

                double media = ((value1 * 2) + (value2 * 3) + (value3 * 5)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("-----------X-----------");
            }

        }
    }
}
