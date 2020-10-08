using System;
using System.Collections.Generic;
using System.Globalization;
using MetodosAbsExe.Entities;

namespace MetodosAbsExe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int manyPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= manyPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char typeTaxPayer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeTaxPayer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    payers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    payers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();

            Console.WriteLine("TAXES PAID: ");
            double resultOfTaxes = 0;
            foreach(var payer in payers)
            {
                double tax = payer.Tax();
                Console.WriteLine($"{payer.Name}: $ {payer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                resultOfTaxes += tax;
            }

            Console.WriteLine($"TOTAL TAXES: $ {resultOfTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
