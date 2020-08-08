using System;
using System.Globalization;

namespace ExerciciosPropostos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine();
            Console.WriteLine($"A= {area:F4}");
        }
    }
}
