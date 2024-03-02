namespace _11._Coffee_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDrink = Console.ReadLine();
            string extra = Console.ReadLine();

            double coffeePrice = 1.0;
            double teaPrice = 0.6;
            double sugarPrice = 0.4;
            double finalPrice = 0;
            if (typeOfDrink == "coffee")
            {
                if (extra == "sugar")
                {
                    finalPrice = coffeePrice + sugarPrice;
                }
                else if (extra == "no")
                {
                    finalPrice = coffeePrice;
                }
            }
            else if (typeOfDrink == "tea")
            {
                if (extra == "sugar")
                {
                    finalPrice = teaPrice + sugarPrice;
                }
                else if (extra == "no")
                {
                    finalPrice = teaPrice;
                }
            }

            Console.WriteLine($"Final price: ${finalPrice:F2}");
        }
    }
}