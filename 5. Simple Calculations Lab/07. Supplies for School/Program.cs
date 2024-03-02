namespace _07._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPensPackages = int.Parse(Console.ReadLine());
            int numberOfMarkersPackages = int.Parse(Console.ReadLine());
            int litersOfBoardCleaner = int.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine()) / 100;

            double totalPensPrice = numberOfPensPackages * 5.8;
            double totalMarkersPrice = numberOfMarkersPackages * 7.2;
            double totalCleanerPrice = litersOfBoardCleaner * 1.2;

            double totalPrice = totalPensPrice + totalMarkersPrice + totalCleanerPrice;

            double totalAfterDiscount = totalPrice - (totalPrice * discountPercentage);

            Console.WriteLine($"{totalAfterDiscount}");
        }
    }
}