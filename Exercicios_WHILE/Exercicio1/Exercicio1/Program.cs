
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a senha: ");
            long password = long.Parse(Console.ReadLine());

            long right = 2002L;

            while (password != right)
            {
                Console.WriteLine("Senha inválida!");
                Console.Write("Insira a senha novamente: ");
                password = long.Parse(Console.ReadLine());
            }

            Console.WriteLine("Senha correta!");
        }
    }
}
