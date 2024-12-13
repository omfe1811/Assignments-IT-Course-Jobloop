

/*int wordCount = 3;
string randomText = GenerateRandomLoremIpsum(wordCount);
Console.WriteLine(randomText);


static string GenerateRandomLoremIpsum(int wordCount)
{
    // Base Lorem Ipsum words
    string[] loremWords = new string[]
    {
            "lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipiscing", "elit",
            "sed", "do", "eiusmod", "tempor", "incididunt", "ut", "labore", "et", "dolore",
            "magna", "aliqua", "ut", "enim", "ad", "minim", "veniam", "quis", "nostrud",
            "exercitation", "ullamco", "laboris", "nisi", "ut", "aliquip", "ex", "ea",
            "commodo", "consequat", "duis", "aute", "irure", "dolor", "in", "reprehenderit",
            "in", "voluptate", "velit", "esse", "cillum", "dolore", "eu", "fugiat", "nulla",
            "pariatur", "excepteur", "sint", "occaecat", "cupidatat", "non", "proident",
            "sunt", "in", "culpa", "qui", "officia", "deserunt", "mollit", "anim", "id", "est", "laborum"
    };

    Random random = new Random();

    for (int i = 0; i < wordCount; i++)
    {
        string word = loremWords[random.Next(loremWords.Length)];
        result.Append(word);
        if (i < wordCount - 1)
        {
            result.Append(" ");
        }
    }

    return result.ToString();
}
*/