namespace _01._Days_in_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());

            int daysInMinutes = (numberOfDays * 24) * 60;

            Console.WriteLine($"Minutes = {daysInMinutes}");
        }
    }
}