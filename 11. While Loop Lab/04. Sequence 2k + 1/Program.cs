namespace _04._Sequence_2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            int number = 1;
            while (number <= maxNumber) 
            {
                Console.WriteLine(number);
                number = number * 2 + 1;
            }
        }
    }
}