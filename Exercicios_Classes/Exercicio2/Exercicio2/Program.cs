using System;
using System.Runtime.ExceptionServices;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employes first = new Employes();
            Employes second = new Employes();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            first.name = Console.ReadLine();
            Console.Write("Salário: ");
            first.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            second.name = Console.ReadLine();
            Console.Write("Salário: ");
            second.salary = double.Parse(Console.ReadLine());

            double media = (first.salary + second.salary) / 2.00;

            Console.WriteLine($"Salário Médio: {media}");

        }
    }
}
