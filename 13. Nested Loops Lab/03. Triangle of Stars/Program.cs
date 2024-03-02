namespace _03._Triangle_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int star = 1; star <= row; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}