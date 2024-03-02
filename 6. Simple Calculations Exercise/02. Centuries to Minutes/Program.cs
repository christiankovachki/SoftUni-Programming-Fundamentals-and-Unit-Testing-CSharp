namespace _02._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int centuriesToYears = centuries * 100;
            double yearsToDays = centuriesToYears * 365.2422;
            double daysToHours = Math.Floor(yearsToDays) * 24;
            double hoursToMinutes = Math.Floor(daysToHours) * 60;

            Console.WriteLine($"{centuries} centuries = {centuriesToYears} years = {yearsToDays:F0} days = {daysToHours} hours = {hoursToMinutes} minutes");
        }
    }
}