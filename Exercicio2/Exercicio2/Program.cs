using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("---------x---------");

            Console.Write("Quantos quartos tem na sua casa: ");
            int bedroom = int.Parse(Console.ReadLine());

            Console.WriteLine("---------x---------");

            Console.Write("Entre com o preço de um produto: ");
            double cost = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("---------x---------");

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] pessoa = Console.ReadLine().Split(' ');
            string lastName = pessoa[0];
            int age = int.Parse(pessoa[1]);
            double height = double.Parse(pessoa[2]);

            Console.WriteLine("---------x---------");

            Console.WriteLine("Seus dados são: ");
            Console.WriteLine(name);
            Console.WriteLine(bedroom);
            Console.WriteLine(cost);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height);

        }
    }
}
