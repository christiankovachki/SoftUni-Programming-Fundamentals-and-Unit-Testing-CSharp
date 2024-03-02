namespace _03._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfChickenMenus = int.Parse(Console.ReadLine());
            int numberOfFishMenus = int.Parse(Console.ReadLine());
            int numberOfVegeterianMenus = int.Parse(Console.ReadLine());

            double totalCostOfMenus = (numberOfChickenMenus * 10.35) + (numberOfFishMenus * 12.40) + (numberOfVegeterianMenus * 8.15);
            double desertPrice = totalCostOfMenus * 0.2;
            double totalCostOfOrder = totalCostOfMenus + desertPrice + 2.5;

            Console.WriteLine(totalCostOfOrder);
        }
    }
}