namespace _02._Largest_Number_Out_Of_Three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());
            int thirdN = int.Parse(Console.ReadLine());

            if (firstN > secondN)
            {
                if (firstN > thirdN)
                {
                    Console.WriteLine(firstN);
                }
                else
                {
                    Console.WriteLine(thirdN);
                }
            }
            else if (secondN > thirdN)
            {
                Console.WriteLine(secondN);
            }
            else
            {
                Console.WriteLine(thirdN);
            }
        }
    }
}