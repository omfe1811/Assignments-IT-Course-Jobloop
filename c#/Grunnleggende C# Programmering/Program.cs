using System;
namespace Csharpproject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a variable of data type integer and assign it an arbitrary integer
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine($"Random number generated: {randomInt}");
            //Create a variable of the data type string and then an arbitrary text
            System.Console.WriteLine($"Random cat text: {RandomText(10)}");
            //Create a variable of data type double and until any number, both decimal and integer are valid with this type
            double randomDouble = random.NextDouble();
            Console.WriteLine($"Random double number generated: {randomDouble}");
            //Create a variable of data type char and assign it an arbitrary character(letter or number)
            System.Console.WriteLine($"Random character: {RandomChar()}");
            // Create an Array of data type integer and print the values ​​with a normal for loop
            IntArray();
            //Create an Array of data type string and print the values ​​with a foreach loop
            StringArray();
            /*Create a List of the data type string and assign values ​​using the method myExampleList.Add("my string");
            Add more strings to your list
            Print the values ​​in the list using a foreach loop*/
            FrogList();
        }
        static string RandomText(int textLength)
        {
            string[] CatLorem = {"meow", "purr", "kitten", "feline", "whiskers",
            "fur", "claws", "tail", "paw", "scratch",
            "nap", "catnip", "hiss", "mew", "litter",
            "mouse", "yarn", "cuddle", "jump", "stretch",
            "lick", "groom", "sleep", "hunt", "play"};
            string text = "";
            Random random = new Random();
            for (int i = 0; i < textLength; i++)
            {
                int randomIndex = random.Next(CatLorem.Length);
                text += CatLorem[randomIndex] + " ";
            }
            return text;
        }
        static char RandomChar()
        {
            char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '5', '6', '7', '8', '9' };
            Random random = new Random();
            int index = random.Next(chars.Length);
            return chars[index];
        }
        static void IntArray()
        {
            int[] ints = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Array of integers: ");
            for (int i = 0; i < ints.Length; i++)
            {
                System.Console.Write(ints[i] + ", ");
            }
            Console.WriteLine();
        }
        static void StringArray()
        {
            string[] names = { "Alice", "Bob", "Charlie", "Diana", "Ethan", "Fiona", "George", "Hannah", "Isaac", "Julia" };
            System.Console.Write("Array of names: ");
            foreach (string i in names)
            {
                System.Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
        static void FrogList()
        {
            List<string> frogs = new List<string>();
            frogs.Add("Rain Frog");
            frogs.Add("American Bullfrog");
            frogs.Add("Poison Dart Frog");
            frogs.Add("African Clawed Frog");
            frogs.Add("Glass Frog");
            System.Console.Write("List of frogs: ");
            foreach (string i in frogs)
            {
                System.Console.Write(i + ", ");
            }
        }
    }
}
