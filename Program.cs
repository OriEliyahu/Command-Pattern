using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef OriChef = new Chef("Ori Eliyahu");
            Order order1 = new FirstMeal("poteto's" , OriChef);
            Order order2 = new MainMeal("chiken & stake", OriChef);
            Order order3 = new LastMeal("chocklate cake", OriChef);

            SenderOrder Meltzar = new SenderOrder();

            Meltzar.AddOrder(order1);
            Meltzar.AddOrder(order2);
            Meltzar.AddOrder(order3);

            Meltzar.PlaceOrder();
        }
    }
}
