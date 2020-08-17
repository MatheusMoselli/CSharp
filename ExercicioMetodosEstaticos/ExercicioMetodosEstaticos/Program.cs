using System;
using System.Globalization;

namespace ExercicioMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a coração do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.DolarParaReal(cotacao, dolares).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
