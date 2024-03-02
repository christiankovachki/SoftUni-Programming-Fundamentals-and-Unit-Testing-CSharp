namespace _09._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int seatsCountPerRow = int.Parse(Console.ReadLine());

            int totalCountOfSeats = rowsCount * seatsCountPerRow;
            double totalPrice = 0;

            switch (typeOfMovie)
            {
                case "Premiere":
                    totalPrice = totalCountOfSeats * 12;
                    break;
                case "Normal":
                    totalPrice = totalCountOfSeats * 7.5;
                    break;
                case "Discount":
                    totalPrice = totalCountOfSeats * 5;
                    break;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}