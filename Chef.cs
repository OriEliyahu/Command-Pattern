class Chef
{
    private string name;
    public Chef(string name)
    {
        this.name = name;
    }

    public void Start(string dish)
    {
        System.Console.WriteLine("the chef " + this.name + " cooking " + dish);
    }   
}