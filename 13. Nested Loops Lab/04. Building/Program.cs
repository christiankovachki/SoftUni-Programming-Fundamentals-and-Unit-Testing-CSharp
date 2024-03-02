namespace _04._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int estatesCountPerFloor = int.Parse(Console.ReadLine());

            for (int floor = floorsCount; floor >= 1; floor--)
            {
                for (int estate = 1; estate <= estatesCountPerFloor; estate++)
                {
                    if (floor == floorsCount) 
                    {
                        Console.Write($"L{floor}{estate - 1} ");
                    }
                    else if (floor % 2 == 1)
                    {
                        Console.Write($"A{floor}{estate - 1} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{estate - 1} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}