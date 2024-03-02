namespace _05._Convert_Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperatureInCelsius = double.Parse(Console.ReadLine());

            double temperatureInFahrenheit = (temperatureInCelsius * 1.8) + 32;

            Console.WriteLine($"{temperatureInFahrenheit:F2}");
        }
    }
}