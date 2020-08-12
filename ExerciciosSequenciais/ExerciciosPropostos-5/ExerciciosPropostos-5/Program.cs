using System;
using System.Globalization;

namespace ExerciciosPropostos_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira, respectivamente, o código, a quantidade, e o preço da peça: ");
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(peca1[0]);
            int qntd1 = int.Parse(peca1[1]);
            double preco1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Insira as mesmas informações de outra peça: ");
            string[] peca2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(peca2[0]);
            int qntd2 = int.Parse(peca2[1]);
            double preco2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double res = (qntd1 * preco1) + (qntd2 * preco2);

            Console.WriteLine();
            Console.WriteLine($"VALOR A PAGAR: {res:F2}");

        }
    }
}
