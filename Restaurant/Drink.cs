using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Drink : DishItem
    {
        public float Volume { get; set; }
        public bool IsAlkohol { get; set; }
        
        public Drink(string name, decimal price, float volume, bool isAlkohol)
            : base(name, price)
        {
            Volume = volume;
            IsAlkohol = isAlkohol;
        }


        public override void Print_Info()
        {
            Console.WriteLine($"Напій \"{Name}\" ({Volume:f2} мл, {(IsAlkohol ? "алкогольний" : "безалкогольний")}) - {Price}грн");
        }

    }
}
