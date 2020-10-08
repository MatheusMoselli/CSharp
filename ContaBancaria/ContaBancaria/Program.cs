using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount firstClient;
            double balance;
            double money;

            Console.Write("Entre o número da conta (4 Dígitos): ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Entre o títular da conta: ");
            string name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char answer = char.Parse(Console.ReadLine());

            if (answer == 's')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                firstClient = new BankAccount(accountNumber, name, balance);
            } else
            {
                firstClient = new BankAccount(accountNumber, name);
            }

            

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(firstClient);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            firstClient.Deposits(money);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(firstClient);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            firstClient.Withdraw(money);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(firstClient);
        }
    }
}
