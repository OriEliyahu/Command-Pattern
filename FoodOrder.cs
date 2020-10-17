abstract class FoodOrder
{
    protected Chef chef; // Reciver
    protected string dish;

    public FoodOrder(string dish, Chef chef)
    {
        this.dish = dish;
        this.chef = chef;
    }
}

class FirstMeal : FoodOrder, Order
{
    public FirstMeal(string dish, Chef chef)
    : base(dish, chef)
    {
    }

    public void Execute()
    {
        chef.Start(dish);
    }
}

class MainMeal : FoodOrder, Order
{
    public MainMeal(string dish, Chef chef)
    : base(dish, chef)
    {
    }

    public void Execute()
    {
        chef.Start(dish);
    }
}

class LastMeal : FoodOrder, Order
{
    public LastMeal(string dish, Chef chef)
    : base(dish, chef)
    {
    }

    public void Execute()
    {
        chef.Start(dish);
    }
}