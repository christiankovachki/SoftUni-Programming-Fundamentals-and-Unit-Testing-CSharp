
namespace _09._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double total = CalculateOrderTotalPrice(product, quantity);
            Console.WriteLine($"{total:F2}");
        }

        private static double CalculateOrderTotalPrice(string product, int quantity)
        {

            double price = 0;
            if (product == "coffee")
            {
                price = 1.5;
            }
            else if (product == "water")
            {
                price = 1;
            }
            else if (product == "coke")
            {
                price = 1.4;
            }
            else if (product == "snacks")
            {
                price = 2;
            }

            return quantity * price;
        }
    }
}