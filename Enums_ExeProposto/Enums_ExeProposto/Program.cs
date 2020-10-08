﻿using Enums_ExeProposto.Entities;
using Enums_ExeProposto.Entities.Enums;
using System;

namespace Enums_ExeProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());


            Console.WriteLine();


            Client client = new Client(name, email, birth);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product Name: ");
                string prodName = Console.ReadLine();

                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(prodName, price);

                Console.Write("Quantity: ");
                int qnt = int.Parse(Console.ReadLine());
                
                OrderItem item = new OrderItem(qnt, price, product);

                order.AddItem(item);
            }


            Console.WriteLine();


            Console.WriteLine(order);
        }
    }
}
