namespace _09._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstAthleteTimeInSeconds = int.Parse(Console.ReadLine());
            int secondAthleteTimeInSeconds = int.Parse(Console.ReadLine());
            int thirdAthleteTimeInSeconds = int.Parse(Console.ReadLine());

            int totalTime = firstAthleteTimeInSeconds + secondAthleteTimeInSeconds + thirdAthleteTimeInSeconds;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}