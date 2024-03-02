


namespace _03._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfColums = int.Parse(Console.ReadLine());

            PrintTriangle(numberOfColums);
        }

        private static void PrintTriangle(int numberOfColums)
        {
            PrintUpperHalfOfTriangle(numberOfColums);
            PrintBottomHalfOfTriangle(numberOfColums);
        }

        private static void PrintUpperHalfOfTriangle(int numberOfColums)
        {
            for (int i = 1; i <= numberOfColums; i++)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintBottomHalfOfTriangle(int numberOfColums)
        {
            for (int i = numberOfColums - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}