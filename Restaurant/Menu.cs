using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        private List<DishItem> Items = new List<DishItem>();

        public void Add(DishItem item)
        {
            if (!Items.Contains(item))
            {
                Items.Add(item);
            }
        }

        public DishItem FindItem(string name)
        {
            return Items.Find(item => item.Name.ToLower().Contains(name.ToLower()));
        }

        public void PrintMenu()
        {
            Console.WriteLine("-------------- МЕНЮ РЕСТОРАНУ --------------");
            foreach (var item in Items)
            {
                item.PrintInfo();
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
