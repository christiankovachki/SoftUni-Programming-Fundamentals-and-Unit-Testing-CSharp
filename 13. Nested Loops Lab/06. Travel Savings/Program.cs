namespace _06._Travel_Savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double neededBudget = double.Parse(Console.ReadLine());

                double collectedMoney = 0;
                while (collectedMoney < neededBudget)
                {
                    collectedMoney += double.Parse(Console.ReadLine());

                    Console.WriteLine($"Collected: {collectedMoney:F2}");
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}