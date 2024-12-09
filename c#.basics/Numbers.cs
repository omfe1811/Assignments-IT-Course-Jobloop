class ArrayContent
{
    public static void PrintArray(int[] ints)
    {
        Console.Write("Array values: ");
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write($"{ints[i]}");
            if (i < ints.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}