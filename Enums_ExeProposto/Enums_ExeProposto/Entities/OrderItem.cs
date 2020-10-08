using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Enums_ExeProposto.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double Subtotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder txt = new StringBuilder();

            txt.Append(Product.Name).Append(", ").Append(Price.ToString("F2", CultureInfo.InvariantCulture)).Append(", Quantity: ").Append(Quantity).Append(", Subtotal: ").Append(Subtotal().ToString("F2", CultureInfo.InvariantCulture));
            return txt.ToString();
        }
    }
}
