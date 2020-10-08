using Heranca_ExeProp.Entities;
using System;
using System.Collections.Generic;

namespace Heranca_ExeProp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");

                Console.Write("Common used or imported (c/u/i)? ");
                char typeOfProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (typeOfProduct == 'c')
                {
                    list.Add(new Product(name, price));
                } else if (typeOfProduct == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufactureDate));
                } else if (typeOfProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();

            Console.WriteLine("Price Tags: ");
            foreach (var item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
