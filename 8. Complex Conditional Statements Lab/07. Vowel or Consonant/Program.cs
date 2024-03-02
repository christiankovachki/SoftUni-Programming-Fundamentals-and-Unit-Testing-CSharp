namespace _07._Vowel_or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string character = Console.ReadLine().ToLower();

            switch (character)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
        }
    }
}