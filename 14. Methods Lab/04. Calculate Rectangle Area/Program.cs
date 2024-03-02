
namespace _04._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int rectangleArea = CalculateRectangleArea(width, length);
            Console.WriteLine(rectangleArea);
        }

        private static int CalculateRectangleArea(int width, int length)
        {
            return width * length;
        }
    }
}