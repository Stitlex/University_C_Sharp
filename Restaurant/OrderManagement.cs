using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class OrderManagement
    {
        List<Order> Orders = new List<Order>();

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }

        public Order FindOrderById(int id)
        {
            return Orders.Find(order => order.Id == id);
        }

        public void PrintAllOrder()
        {
            Console.WriteLine("----------- ВСІ АКТИВНІ ЗАМОВЛЕННЯ РЕСТОРАНУ -----------");
            foreach (var order in Orders)
            {
                order.Print_Order_Info();
            }
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
