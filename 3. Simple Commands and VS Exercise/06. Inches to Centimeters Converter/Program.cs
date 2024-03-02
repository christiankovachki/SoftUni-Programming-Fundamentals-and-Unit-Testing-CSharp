namespace _06._Inches_to_Centimeters_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthInInches = int.Parse(Console.ReadLine());

            double lengthInCentimeters = lengthInInches * 2.54;

            Console.WriteLine(lengthInCentimeters);
        }
    }
}