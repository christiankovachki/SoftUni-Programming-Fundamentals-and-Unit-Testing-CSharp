namespace _06._Product_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstN = double.Parse(Console.ReadLine());
            double secondN = double.Parse(Console.ReadLine());
            double thirdN = double.Parse(Console.ReadLine());

            if (firstN == 0 || secondN == 0 || thirdN == 0)
            {
                Console.WriteLine("zero");
            }
            else if ((firstN < 0 && secondN < 0) || 
                (firstN < 0 && thirdN < 0) || 
                (secondN < 0 && thirdN < 0) || 
                (firstN > 0 && secondN > 0 && thirdN > 0))
            {
                Console.WriteLine("positive");
            }
            else if ((firstN < 0 && secondN > 0 && thirdN > 0) ||
                (secondN < 0 && firstN > 0 && thirdN > 0) ||
                (thirdN < 0 && secondN > 0 && firstN > 0))
            {
                Console.WriteLine("negative");
            }
        }
    }
}