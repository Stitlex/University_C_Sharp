using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Food : DishItem
    {
        public float Weight { get; set; }
        public bool IsVegan { get; set; }


        public Food(string name, decimal price, float weight, bool isVegan)
            : base(name, price)
        {
            Weight = weight;
            IsVegan = isVegan;
        }

        public override void Print_Info()
        {
            Console.WriteLine($"Старава \"{Name}\" ({Weight:f2} г, {(IsVegan ? "веганська" : "звичайна")}) - {Price}грн");
        }

    }
}
