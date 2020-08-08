using System;
using System.Globalization;

namespace Entrada_Dados2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char genero = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] pessoa = Console.ReadLine().Split(' ');
            string nome = pessoa[0];
            char sexo = char.Parse(pessoa[1]);
            int idade = int.Parse(pessoa[2]);
            double altura = double.Parse(pessoa[3], CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(genero);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
