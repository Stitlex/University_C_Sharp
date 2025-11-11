using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        private List<ISwitchable> devices = new List<ISwitchable>();
        private List<IEnergyConsumer> energyDevice = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device)
        {
            devices.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDevice.Add(device);
        }

        public void TurnAllOn()
        {
            foreach (var device in devices)
            {
                device.TurnOn();
            }
        }

        public void TurnAllOff()
        {
            foreach (var device in devices)
            {
                device.TurnOff();
            }
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"\nЗвіт про споживання енергії за {hours} год:");

            double totalEnergy = 0;
            foreach (var device in energyDevice)
            {
                double energyUsed = device.GetEnergyUsage(hours);
                Console.WriteLine($"{device.DeviceName}: {energyUsed:F2} кВт·год (потужність: {device.PowerConsumption} Вт)");
                totalEnergy += energyUsed;
            }

            Console.WriteLine($"Загальне споживання: {totalEnergy:F2} кВт·год\r\n");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {totalEnergy * 4.0:F2} грн");
        }
    }
}
