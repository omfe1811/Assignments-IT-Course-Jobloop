class Character
{
    char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '5', '6', '7', '8', '9' };
    char randomChar;
    public Character()
    {
        Random random = new Random();  // Initialize random object
        randomChar = chars[random.Next(chars.Length)];  // Generate random character
    }
    public char GetRandomCharacter()
    {
        return randomChar;
    }
    class Program
    {
        static void Char()
        {
            Character character = new Character();
            char randomCharacter = character.GetRandomCharacter();
        }
    }

}
