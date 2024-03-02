namespace _02._Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int requiredAmountOfNylon = int.Parse(Console.ReadLine());
            int requiredAmountOfPaint = int.Parse(Console.ReadLine());
            int quantityOfThinner = int.Parse(Console.ReadLine());
            int hoursNeededForWork = int.Parse(Console.ReadLine());

            double nylonAmount = (requiredAmountOfNylon + 2) * 1.5;
            double paintAmount = (requiredAmountOfPaint * 1.1) * 14.5;
            double thinnerAmount = quantityOfThinner * 5;
            double bagsPrice = 0.4;

            double totalAmountForMaterials = nylonAmount + paintAmount + thinnerAmount + bagsPrice;
            double totalAmountForCraftsmen = (totalAmountForMaterials * 0.3) * hoursNeededForWork;
            double totalAmount = totalAmountForMaterials + totalAmountForCraftsmen;

            Console.WriteLine(totalAmount);
        }
    }
}