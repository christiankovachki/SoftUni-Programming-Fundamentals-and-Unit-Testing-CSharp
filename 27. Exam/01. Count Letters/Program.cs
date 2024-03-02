namespace _01._Count_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int upperCaseCounter = 0;
            int lowerCaseCounter = 0;
            int singleSpaceCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsUpper(c))
                {
                    upperCaseCounter++;
                }
                else if (char.IsLower(c))
                {
                    lowerCaseCounter++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    singleSpaceCounter++;
                }
            }

            Console.WriteLine(upperCaseCounter);
            Console.WriteLine(lowerCaseCounter);
            Console.WriteLine(singleSpaceCounter);
        }
    }
}
