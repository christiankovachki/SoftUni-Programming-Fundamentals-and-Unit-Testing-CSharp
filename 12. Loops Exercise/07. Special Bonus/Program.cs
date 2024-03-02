namespace _07._Special_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int latestNumber = number;
            while (number != stopNumber) 
            {
                latestNumber = number;
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(latestNumber * 1.2);
        }
    }
}