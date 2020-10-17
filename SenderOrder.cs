using System;
using System.Collections.Generic;

class SenderOrder
{
    Queue<Order> orders;
    public SenderOrder()
    {
        this.orders = new Queue<Order>();
    }

    public void AddOrder(Order order)
    {
        orders.Enqueue(order);
    }

    public void PlaceOrder()
    {
        while(orders.Count > 0)
        {
            Order order = orders.Dequeue();
            order.Execute();
        }
    }
}