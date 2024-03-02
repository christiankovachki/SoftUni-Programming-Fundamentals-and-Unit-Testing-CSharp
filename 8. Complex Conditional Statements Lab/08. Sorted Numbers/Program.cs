namespace _08._Sorted_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());
            int thirdN = int.Parse(Console.ReadLine());

            if (firstN < secondN && secondN < thirdN)
            {
                Console.WriteLine("Ascending");
            }
            else if (firstN > secondN && secondN > thirdN)
            {
                Console.WriteLine("Descending");
            }
            else 
            {
                Console.WriteLine("Not sorted");

            }
        }
    }
}