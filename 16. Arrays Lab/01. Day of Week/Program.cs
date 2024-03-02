namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] daysOfTheWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(daysOfTheWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}