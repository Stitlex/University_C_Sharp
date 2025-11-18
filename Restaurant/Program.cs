namespace Restaurant
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Drink Caffee = new Drink("Кава", 60, 250, false);
            Drink Juice = new Drink("Сік", 70, 350, false);
            Drink Tea = new Drink("Чай", 55, 250, false);
            Drink Wine = new Drink("Вино", 450, 950, true);

            Food Beaf = new Food("Яловичина", 350, 550, false);
            Food Beaf_Vegan = new Food("Яловичина", 450, 550, true);
            Food Chicken = new Food("Курятина", 230, 350, false);
            Food Salad = new Food("Салат", 130, 250, true);
            Food Rice = new Food("Рис", 120, 270, true);
            
            Menu menu1 = new Menu();

            menu1.Add(Caffee);
            menu1.Add(Juice);
            menu1.Add(Tea);
            menu1.Add(Wine);

            menu1.Add(Beaf);
            menu1.Add(Beaf_Vegan);
            menu1.Add(Chicken);
            menu1.Add(Salad);
            menu1.Add(Rice);

            menu1.PrintMenu();
            

            Console.WriteLine("\n\n======== Приклад знаходження позиції меню за назвою ========");
            DishItem foundItem = menu1.FindItem("кава");
            foundItem.Print_Info();


            Console.WriteLine("\n\n======== Приклад створення меню та демострація дій над ними ========");
            OrderManagement manager = new OrderManagement();

            Order order1 = new Order("Дмитро", 6);
            manager.AddOrder(order1);
            order1.Print_Order_Info();

            Order order2 = new Order("Олексій", 1);
            manager.AddOrder(order2);
            order2.AddItem(Beaf);
            order2.AddItem(Rice);
            order2.AddItem(Wine);
            order2.Print_Order_Info();

            order2.RemoveItem(Wine);
            order2.ChangeStatus(OrderStatus.InProgress);
            order2.Print_Order_Info();

            Order order3 = new Order("Олександр", 15);
            manager.AddOrder(order3);
            order3.AddItem(Beaf_Vegan);
            order3.AddItem(Juice);
            order3.ChangeStatus(OrderStatus.Ready);
            order3.Print_Order_Info();

            Order order4 = new Order("Наталія", 7);
            manager.AddOrder(order4);
            order4.AddItem(Rice);
            order4.AddItem(Tea);
            order3.ChangeStatus(OrderStatus.Paid);
            order4.Print_Order_Info();


            Console.WriteLine("\n\n======== Приклад знаходження замовлення за Id ========");
            Order foundOrder = manager.FindOrderById(4);
            foundOrder.Print_Order_Info();

            Console.Write("\n\n");
            manager.PrintAllOrder();
        }
    }
}