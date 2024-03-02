namespace _05._Vacation_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accomodationType = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
            double discount = 0;

            switch (season) 
            {
                case "Spring":
                    if (accomodationType == "Hotel")
                    {
                        pricePerNight = 30;
                    }
                    else if (accomodationType == "Camping")
                    {
                        pricePerNight = 10;
                    }

                    discount = 20;
                    break;
                case "Summer":
                    if (accomodationType == "Hotel")
                    {
                        pricePerNight = 50;
                    }
                    else if (accomodationType == "Camping")
                    {
                        pricePerNight = 30;
                    }
                    break;
                case "Autumn":
                    if (accomodationType == "Hotel")
                    {
                        pricePerNight = 20;
                    }
                    else if (accomodationType == "Camping")
                    {
                        pricePerNight = 15;
                    }

                    discount = 30;
                    break;
                case "Winter":
                    if (accomodationType == "Hotel")
                    {
                        pricePerNight = 40;
                    }
                    else if (accomodationType == "Camping")
                    {
                        pricePerNight = 10;
                    }

                    discount = 10;
                    break;
            }

            double total = days * pricePerNight;
            double totalAfterDiscount = total - (total * (discount / 100));

            Console.WriteLine($"{totalAfterDiscount:F2}");
        }
    }
}