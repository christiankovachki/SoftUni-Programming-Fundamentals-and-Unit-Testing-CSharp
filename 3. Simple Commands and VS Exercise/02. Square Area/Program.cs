namespace _02._Square_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideLength = int.Parse(Console.ReadLine());

            int area = sideLength * sideLength;

            Console.WriteLine(area);
        }
    }
}