namespace _09._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double area;
            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
                Console.WriteLine($"{area:F2}");
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double length = double.Parse(Console.ReadLine());
                area = width * length;
                Console.WriteLine($"{area:F2}");
            }
            else if (figureType == "circle")
            { 
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
                Console.WriteLine($"{area:F2}");
            }
        }
    }
}