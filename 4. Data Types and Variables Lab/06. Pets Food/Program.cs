namespace _06._Pets_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPackagesDogFood = int.Parse(Console.ReadLine());
            int countOfPackagesCatFood = int.Parse(Console.ReadLine());

            double expenses = (countOfPackagesDogFood * 2.5) + (countOfPackagesCatFood * 4);

            Console.WriteLine($"{expenses:F2} lv.");
        }
    }
}