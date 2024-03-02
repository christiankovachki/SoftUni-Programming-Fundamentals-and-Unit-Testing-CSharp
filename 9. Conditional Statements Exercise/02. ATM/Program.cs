namespace _02._ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            string output = "";

            if (withdraw <= balance)
            {
                output = "The withdraw was successful.";
            }
            else if (withdraw > limit)
            {
                output = "The limit was exceeded.";
            }
            else if (balance < withdraw)
            {
                output = "Insufficient availability.";
            }

            Console.WriteLine(output);
        }
    }
}