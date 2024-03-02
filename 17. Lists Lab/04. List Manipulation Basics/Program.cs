namespace _04._List_Manipulation_Basics
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

                int number = int.Parse(command[1]);

                if (command[0] == "Add")
                {
                    integers.Add(number);
                }
                else if (command[0] == "Remove")
                {
                     integers.Remove(number);
                }
                else if (command[0] == "RemoveAt")
                {
                    int index = number;
                    integers.RemoveAt(index);
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    integers.Insert(index, number);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}