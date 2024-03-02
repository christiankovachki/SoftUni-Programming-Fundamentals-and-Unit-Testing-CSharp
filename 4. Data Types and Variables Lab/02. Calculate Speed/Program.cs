namespace _02._Calculate_Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double neededSpeed = distance / time;

            Console.WriteLine($"{neededSpeed:F2}");
        }
    }
}