namespace _05._Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aquariumLength = int.Parse(Console.ReadLine());
            int aquariumWidth = int.Parse(Console.ReadLine());
            int aquariumHeight = int.Parse(Console.ReadLine());
            double percentageOfOccupiedCapacity = double.Parse(Console.ReadLine()) / 100;

            double aquariumVolumeInLiters = (aquariumLength * aquariumWidth * aquariumHeight) / 1000.0;
            double requiredLiters = aquariumVolumeInLiters * (1 - percentageOfOccupiedCapacity);

            Console.WriteLine($"{requiredLiters:F2}");
        }
    }
}