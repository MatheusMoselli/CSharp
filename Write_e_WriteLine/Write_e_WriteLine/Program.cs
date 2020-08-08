using System;
using System.Globalization;

namespace Write_e_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Matheus Moselli";
            int idade = 16;
            double saldo = 10.35784;

            Console.Write("Aqui não haverá quebra de linha");
            Console.Write("Console 2");
            Console.WriteLine("Aqui haverá");
            Console.WriteLine("Console 4");
            Console.WriteLine("-----------X--------------");

            // Como diminuir a quantidade de casas decimais: 
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));

            // Mudar a vírgula para ponto -> Precisa do namespace System.Globalization
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("----------------------X----------------------");
            //Concatenação / Placeholders / Interpolação

            //Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // Concatenação -> Única opção para mudar o "," por "."
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
