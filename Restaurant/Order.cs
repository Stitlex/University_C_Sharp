using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Order
    {
        static int nextId = 1;

        public int Id { get; }
        public int Table { get ; }
        public string Name { get; set; }
        public OrderStatus Status { get; set; }


        private List<DishItem> Items = new List<DishItem>();

        public Order(string name, int table)
        {
            Id = nextId++;
            Name = name;
            Table = table;
            Status = OrderStatus.New;
        }

        public void AddItem(DishItem item)
        {
            Items.Add(item);
            Console.WriteLine($"--- Додано \"{item.Name}\" до замовлення ID: {Id} ---");
        }

        public void RemoveItem(DishItem item)
        {
            Items.Remove(item);
            Console.WriteLine($"--- Видалено \"{item.Name}\" із замовлення ID: {Id} ---");
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (var item in Items)
            {
                total += item.Price;
            }

            return total;
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"--- Статус замовлення ID: {Id} оновлено на {Status} ---");
        }

        public void PrintOrderInfo()
        {
            Console.WriteLine($"\nId: {Id} | Стіл: {Table} | Статус \"{Status}\" | Ім'я клієнта: \"{Name}\"");
            if ( Items.Count > 0 )
            {
                Console.WriteLine("Деталі замовлення:");
                foreach (var item in Items)
                {
                    Console.Write(" -");
                    item.PrintInfo();
                }
                Console.WriteLine($"Загальна вартість: {CalculateTotal()}грн");
            }
            else
            {
                Console.WriteLine(" -Замовлення порожнє.");
            }
        }
    }
}
