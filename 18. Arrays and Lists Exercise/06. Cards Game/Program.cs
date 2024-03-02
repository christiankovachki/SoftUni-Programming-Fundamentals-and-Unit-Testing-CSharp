namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList(); 
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayerCards.Count != 0 && secondPlayerCards.Count != 0) 
            {
                int firstPlayerCard = firstPlayerCards[0];
                int secondPlayerCard = secondPlayerCards[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                    firstPlayerCards.Add(firstPlayerCard);
                    firstPlayerCards.Add(secondPlayerCard);
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    secondPlayerCards.RemoveAt(0);
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.Add(secondPlayerCard);
                    secondPlayerCards.Add(firstPlayerCard);
                }
                else
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
            }

            if (firstPlayerCards.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }
            else if (secondPlayerCards.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
            }
        }
    }
}