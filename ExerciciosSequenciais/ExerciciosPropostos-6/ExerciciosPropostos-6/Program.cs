using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Transactions;

namespace ExerciciosPropostos_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INSIRA O VALOR A: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("INSIRA O VALOR B: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("INSIRA O VALOR C: ");
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            double pi = 3.14159;

            double areaTriangulo = (n1 * n3) / 2;
            double areaCirculo = pi * Math.Pow(n3, 2);
            double areaTrapezio = (n1 + n2) * n3 / 2;
            double areaQuadrado = Math.Pow(n2, 2);
            double areaRetangulo = n1 * n2;

            Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
            Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
            Console.WriteLine($"TRAPÉZIO: {areaTrapezio:F3}");
            Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
            Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");
        }
    }
}
