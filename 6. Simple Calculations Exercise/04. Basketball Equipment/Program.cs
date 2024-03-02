namespace _04._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualBasketballTrainingFee = int.Parse(Console.ReadLine());

            double sneakerPrice = annualBasketballTrainingFee - (annualBasketballTrainingFee * 0.4);
            double teamPrice = sneakerPrice - (sneakerPrice * 0.2);
            double basketballPrice = teamPrice / 4;
            double accessories = basketballPrice / 5;

            double totalPrice = annualBasketballTrainingFee + sneakerPrice + teamPrice + basketballPrice + accessories;

            Console.WriteLine(totalPrice);
        }
    }
}