
namespace _06._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            
            int count = GetVowelsCount(text);
            Console.WriteLine(count);
        }

        private static int GetVowelsCount(string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'y')
                {
                    count++;
                }
            }

            return count;
        }
    }
}