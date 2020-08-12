using System;

namespace ExerciciosPropostos_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O programa calculará a diferença entre A.B e C.D");
            Console.Write("Insira o valor de A: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor de B: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor de C: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor de D: ");
            int n4 = int.Parse(Console.ReadLine());

            int res = (n1 * n2) - (n3 * n4);

            Console.WriteLine($"A diferença é: {res}");
        }
    }
}
