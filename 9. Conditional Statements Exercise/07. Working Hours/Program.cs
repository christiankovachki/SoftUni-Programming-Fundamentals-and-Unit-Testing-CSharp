namespace _07._Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfTheDay = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            if (hourOfTheDay >= 10 && hourOfTheDay <= 18)
            {
                if (dayOfTheWeek == "Monday" ||
                    dayOfTheWeek == "Tuesday" ||
                    dayOfTheWeek == "Wednesday" ||
                    dayOfTheWeek == "Thursday" ||
                    dayOfTheWeek == "Friday" ||
                    dayOfTheWeek == "Saturday")
                {
                    Console.WriteLine("open");
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}