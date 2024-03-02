namespace _04._Tiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bathroomWidth = double.Parse(Console.ReadLine());
            double bathroomHeight = double.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());

            double bathroomArea = bathroomWidth * bathroomHeight;
            double bathroomAreaWithSurplus = bathroomArea * 1.10;

            double tileArea = tileWidth * tileHeight;

            double neededTiles = bathroomAreaWithSurplus / tileArea;

            Console.WriteLine($"{neededTiles:F0}");
        }
    }
}