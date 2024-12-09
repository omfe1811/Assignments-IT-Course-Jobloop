using System;
namespace Oppgave;

class Program
{
    static void Main(string[] args)
    {
        /*
        Create a List of the data type string and assign values ​​using the method myExampleList.Add("my string");
        Add more strings to your list
        Print the values ​​in the list using a foreach loop*/
        Random random = new Random();
        int randomNumber = random.Next();
        string name = "Alexander";
        char randomLetter = (char)random.Next('a', 'z' + 1);
        double doubleNumber = 42.58;
        int[] ints = [1, 16, 88, 25];
        string[] names = ["Maria", "Adam", "Leosia", "Maggie"];
        string[] fruit = [];

        Console.WriteLine($"Random Number: {randomNumber}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Letter: {randomLetter}");
        Console.WriteLine($"Double number: {doubleNumber}");
        ArrayContent.PrintArray(ints);
        NameContent.PrintNames(names);
        FruitContent.PrintFruit(fruit);
    }

}

