namespace _06._Mandatory_Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesReadPerHour = int.Parse(Console.ReadLine());
            int numberOfDaysNeeded = int.Parse(Console.ReadLine());

            int totalReadingTimeInHoours = numberOfPages / pagesReadPerHour;
            int requiredHoursPerDay = totalReadingTimeInHoours / numberOfDaysNeeded;

            Console.WriteLine($"{requiredHoursPerDay}");
        }
    }
}