namespace _03._Customer_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string email = Console.ReadLine();

            Console.WriteLine("Customer: " + firstName + " " + secondName + " (" + email + ")");
        }
    }
}