
namespace _05._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text  = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            string repeatedString = RepeatStringCountTimes(text, repeatCount);
            Console.WriteLine(repeatedString);
        }

        private static string RepeatStringCountTimes(string text, int repeatCount)
        {
            string result = "";
            for (int i = 0; i < repeatCount; i++)
            {
                result += text;
            }

            return result;
        }
    }
}