using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class DishItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public DishItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract void PrintInfo();
    }
}
