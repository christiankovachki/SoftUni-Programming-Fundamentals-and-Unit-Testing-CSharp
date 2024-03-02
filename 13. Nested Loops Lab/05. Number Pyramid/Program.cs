namespace _05._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool flag = false;

            int numberToPrint = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{numberToPrint} ");
                    numberToPrint++;
                    if (numberToPrint > n) 
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag) 
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}