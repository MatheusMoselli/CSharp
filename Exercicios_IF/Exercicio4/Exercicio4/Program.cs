using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a hora inicial do jogo: ");
            int inicialHour = int.Parse(Console.ReadLine());

            Console.Write("Insira a hora final do jogo: ");
            int finalHour = int.Parse(Console.ReadLine());

            if (inicialHour > finalHour)
            {
                Console.WriteLine($"O JOGO DUROU {(24 - inicialHour) + finalHour} HORAS");
            } else if (inicialHour < finalHour)
            {
                Console.WriteLine($"O JOGO DUROU {finalHour - inicialHour} HORAS");
            } else if (inicialHour == finalHour)
            {
                Console.WriteLine($"O JOGO DUROU {finalHour - inicialHour} HORAS, FOI RAPIDINHO");
            }
        }
    }
}
