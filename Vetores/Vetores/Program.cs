using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente[] quartos = new Cliente[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quantosQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= quantosQuartos; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quartoSelecionado = int.Parse(Console.ReadLine());

                quartos[quartoSelecionado] = new Cliente { Nome = nome, Email = email };

                Console.WriteLine();
            }

            Console.WriteLine("Quartos selecionados: ");

            for(int p = 0; p < 10; p++)
            {
                if(quartos[p] != null)
                {
                    Console.WriteLine($"{p}: {quartos[p].Nome}, {quartos[p].Email}");
                }
            }
        }
    }
}
