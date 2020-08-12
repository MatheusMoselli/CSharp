using System;

namespace ExerciciosPropostos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Insira outro número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"A soma dos valores é: {n1 + n2}");
        }
    }
}
