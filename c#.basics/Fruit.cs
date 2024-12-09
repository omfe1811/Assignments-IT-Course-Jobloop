class FruitContent
{
    public string Name { get; set; } = "";
    public string Color { get; set; } = "";
    public int Calories { get; set; } = 0;

    //constructor
    public Fruit()
    { }
    public void PrintFruit()
    {
        string FruitText = $@"
            Fruit's name is: {this.Name}
            it's {this.Color}
            and it has: {this.Calories} kcal.";
        System.Console.WriteLine(FruitText);
    }
    Fruit.Add("Apple")
}