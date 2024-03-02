namespace _04._Vowel_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int vowelSum = 0;
            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());

                int value = 0;

                if (character == 'a')
                { 
                    value = 1;
                }
                else if (character == 'e')
                {
                    value = 2;
                }
                else if (character == 'i')
                {
                    value = 3;
                }
                else if (character == 'o')
                {
                    value = 4;
                }
                else if (character == 'u')
                {
                    value = 5;
                }

                vowelSum += value;
            }

            Console.WriteLine(vowelSum);
        }
    }
}