using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int code = int.Parse(Console.ReadLine());

           

            while (code != 4)
            {
                if (code > 4 || code < 0)
                {
                    Console.WriteLine("Ensira valores de 1 a 4");
                }

                if (code == 1)
                {
                    alcool++;
                    Console.WriteLine("Um alcool adicionado.");
                } else if (code == 2)
                {
                    gasolina++;
                    Console.WriteLine("Uma gasolina adicionada.");
                } else if (code == 3)
                {
                    diesel++;
                    Console.WriteLine("Um diesel adicionado.");
                }

                code = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("------------x------------");
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
