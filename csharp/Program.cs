using System;
namespace Oppgave;

class Program
{/*
Create an Array of the data type string and print the values ​​with a foreach loop
Create a List of the data type string and assign values ​​using the method myExampleList.Add("my string");
Add more strings to your list
Print the values ​​in the list using a foreach loop*/
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next();
        /*string randomText = GenerateRandomLoremIpsum(wordCount);*/
        double decimalNumber = 42.58;
        int[] ints = [1, 16, 88, 25];
        string[] names = ["Maria", "Adam", "Leosia", "Maggie"];


        Console.WriteLine($"Random number generated: {RandomInt}");

        char randomChar;
        /*Console.WriteLine($"Random text: {loremWords}");*/
        Console.WriteLine($"Random Character: {randomChar}");
        NameContent.PrintNames(names);
        List<Fruit> fruits = new List<Fruit>();
        Console.WriteLine("List of fruits:");
        fruits.Add(new Fruit("Banana"));
        fruits.Add(new Fruit("Pineapple"));
        fruits.Add(new Fruit("Mango"));

        /*foreach (var item in fruits)
        {
            Console.WriteLine(fruits.Name);
        }*/

    }

}

