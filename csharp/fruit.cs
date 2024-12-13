class Fruit
{
    List<Fruit> fruits = new List<Fruit>();
    public string Name { get; set; }
    public Fruit(string name)
    {
        fruits.Add(new Fruit("Banana"));
        fruits.Add(new Fruit("Pineapple"));
        fruits.Add(new Fruit("Mango"));

        Name = name;
        foreach (Fruit in fruits)
        {
            Console.WriteLine(fruit.Name);
        }

    }
}
