namespace _04._Letter_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char excludedLetter = char.Parse(Console.ReadLine());

            int count = 0;

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        if (i != excludedLetter && j != excludedLetter && k != excludedLetter)
                        {
                            Console.Write($"{i}{j}{k} ");
                            count++;
                        }
                     }
                }
            }

            Console.WriteLine();
            Console.WriteLine(count);
        }
    }
}