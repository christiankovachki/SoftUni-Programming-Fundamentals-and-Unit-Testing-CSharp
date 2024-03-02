namespace _07._Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());

            for (char ch = startChar; ch <= endChar; ch++)
            {
                Console.Write($"{ch} ");
            }
        }
    }
}