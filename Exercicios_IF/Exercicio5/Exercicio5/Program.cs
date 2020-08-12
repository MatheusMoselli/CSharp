using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A loja possui os seguintes produtos:");
            Console.WriteLine("CÓDIGO           PRODUTO             PREÇO");
            Console.WriteLine("1                CACHORRO QUENTE     R$ 4,00");
            Console.WriteLine("2                X-SALADA            R$ 4,50");
            Console.WriteLine("3                X-BACON             R$ 5,00");
            Console.WriteLine("4                TORRADA SIMPLES     R$ 2,00");
            Console.WriteLine("5                REFRIGERANTE        R$ 1,50");


            Console.Write("Digite o código do produto desejado: ");
            int code = int.Parse(Console.ReadLine());

            Console.Write("Digite qual a quantidade: ");
            int qntd = int.Parse(Console.ReadLine());

            if(code == 1 )
            {
                Console.WriteLine($"Total a pagar: R$ {4.00 * qntd}");
            } else if (code == 2)
            {
                Console.WriteLine($"Total a pagar: R$ {4.50 * qntd}");
            } else if (code == 3)
            {
                Console.WriteLine($"Total a pagar: R$ {5.00 * qntd}");
            } else if (code == 4)
            {
                Console.WriteLine($"Total a pagar: R$ {2.00 * qntd}");
            } else if (code == 5)
            {
                Console.WriteLine($"Total a pagar: R$ {1.50 * qntd}");
            }
        }
    }
}
