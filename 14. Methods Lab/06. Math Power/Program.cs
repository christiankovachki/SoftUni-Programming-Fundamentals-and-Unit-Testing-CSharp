
namespace _06._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int result = RaiseNumberToGivenPower(baseNumber, power);
            Console.WriteLine(result);
        }

        private static int RaiseNumberToGivenPower(int baseNumber, int power)
        {
            return (int)Math.Pow(baseNumber, power);
        }
    }
}