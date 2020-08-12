using System;
using System.Globalization;

namespace ExerciciosPropostos_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira, em cada linha, seu código, quantas horas trabalhadas e quanto recebe por hora: ");
            int codigo = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double recebePorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * recebePorHora;
            Console.WriteLine($"CÓDIGO: {codigo}");
            Console.WriteLine($"SALARIO: {salario:F2}");
        }
    }
}
