namespace _09._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int biggestSequenceCounter = 1;
            int counter = 1;
            int number = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i - 1] == numbers[i])
                {
                    counter++;

                    if (counter > biggestSequenceCounter)
                    {
                        number = numbers[i - 1];
                    }
                }
                else 
                {
                    if (counter > biggestSequenceCounter)
                    {
                        biggestSequenceCounter = counter;
                    }

                    counter = 1;
                }
            }

            if (counter > biggestSequenceCounter)
            {
                biggestSequenceCounter = counter;
            }

            for (int i = 0; i < biggestSequenceCounter; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}