namespace _07._Number_Processor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "End") 
            {
                if (input == "Inc")
                {
                    n++;
                }
                else if (input == "Dec")
                {
                    n--;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(n);
        }
    }
}