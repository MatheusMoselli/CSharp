using Enums_ExeProposto.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Enums_ExeProposto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(var item in Items)
            {
                sum += item.Subtotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder txt = new StringBuilder();
            txt.AppendLine("Order Summary: ");
            txt.Append("Order Moment: ").AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            txt.Append("Order Status: ").AppendLine(Status.ToString());
            txt.Append("Client: ").AppendLine(Client.ToString());

            foreach(var item in Items)
            {
                txt.AppendLine(item.ToString());
            }

            txt.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return txt.ToString();
        }
    }
}
