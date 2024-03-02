namespace _04._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distanceInMeters = double.Parse(Console.ReadLine());

            double metersToKilometers = distanceInMeters / 1000;

            Console.WriteLine($"{metersToKilometers:F2}");
        }
    }
}