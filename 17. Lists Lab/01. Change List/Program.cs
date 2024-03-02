namespace _01._Change_List
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
                int element = int.Parse(command[1]);

                if (command[0] == "Delete")
                {
                    integers.RemoveAll(e => e.Equals(element));
                }
                else if (command[0] == "Insert")
                {
                    int position = int.Parse(command[2]);
                    integers.Insert(position, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}