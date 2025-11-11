using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {
        public int PowerConsumption 
        { 
            get {return 1000;}
        }
        public string DeviceName 
        { 
            get {return Name;}
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} почала готувати каву.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} завершила роботу.");
        }

        public double GetEnergyUsage(int hours)
        {
            if (!IsOn)
            {
                return 0;
            }
            else
            {
                return (PowerConsumption * hours) / 1000;
            }
        }
    }
}
