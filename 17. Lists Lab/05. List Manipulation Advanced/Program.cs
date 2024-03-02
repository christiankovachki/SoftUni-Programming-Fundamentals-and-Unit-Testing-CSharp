namespace _05._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (!input.Equals("end"))
            {
                string[] command = input.Split();

                if (command[0] == "Contains")
                {
                    int number = int.Parse(command[1]);

                    if (integers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", integers.FindAll(num => num % 2 == 0)));
                }
                else if (command[0] == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", integers.FindAll(num => num % 2 == 1)));
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(integers.Sum());
                }
                else if (command[0] == "Filter")
                {
                    string condition = command[1];
                    int number = int.Parse(command[2]);

                    if (condition == ">")
                    {
                        integers = integers.FindAll(num => num > number);
                    }
                    else if (condition == ">=")
                    {
                        integers = integers.FindAll(num => num >= number);
                    }
                    else if (condition == "<")
                    {
                        integers = integers.FindAll(num => num < number);
                    }
                    else if (condition == "<=")
                    {
                        integers = integers.FindAll(num => num <= number);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}