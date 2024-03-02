namespace _01._Convertor_USD_to_EUR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());

            double euros = dollars * 0.88;

            Console.WriteLine($"{euros:F2}");
        }
    }
}