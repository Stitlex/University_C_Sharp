namespace SmartHomeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var controller = new SmartHomeController();

            var Lamp = new Light { Name = "Лампа у вітальні" };
            var Ac = new AirConditioner { Name = "Кондиціонер у спальні" };
            var Coffee = new CoffeeMachine { Name = "Кавомашина на кухні" };
            var Sensor = new MotionSensor { Name = "Датчик руху у коридорі" };

            controller.AddDevice(Lamp);
            controller.AddDevice(Ac);
            controller.AddDevice(Coffee);
            controller.AddDevice(Sensor);

            controller.AddEnergyDevice(Lamp);
            controller.AddEnergyDevice(Ac);
            controller.AddEnergyDevice(Coffee);

            controller.TurnAllOn();

            Lamp.PrintStatus();
            Ac.PrintStatus();
            Coffee.PrintStatus();
            Sensor.PrintStatus();

            controller.ShowEnergyReport(5);

            controller.TurnAllOff();
        }
    }
}
