namespace _04._Food_or_Drink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            string output;

            if (product == "curry" || product == "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
            {
                output = "food";
            }
            else if (product == "tea" || product == "water" || product == "coffee" || product == "juice")
            {
                output = "drink";
            }
            else 
            {
                output = "unknown";
            }

            Console.WriteLine(output);
        }
    }
}