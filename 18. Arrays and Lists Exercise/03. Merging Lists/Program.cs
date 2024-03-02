namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstListOfInts = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondListOfInts = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> resultList = new List<int>(firstListOfInts.Count + secondListOfInts.Count);

            for (int i = 0; i < Math.Min(firstListOfInts.Count, secondListOfInts.Count); i++)
            {
                resultList.Add(firstListOfInts[i]);
                resultList.Add(secondListOfInts[i]);
            }

            if (firstListOfInts.Count != secondListOfInts.Count)
            {
                for (int i = Math.Min(firstListOfInts.Count, secondListOfInts.Count); i < Math.Max(firstListOfInts.Count, secondListOfInts.Count); i++)
                {
                    if (firstListOfInts.Count > secondListOfInts.Count)
                    {
                        resultList.Add(firstListOfInts[i]);
                    }
                    else
                    {
                        resultList.Add(secondListOfInts[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}