namespace _04._Number_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstN = double.Parse(Console.ReadLine());
            double secondN = double.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();

            double result = 0;
            switch (mathOperator)
            {
                case "+":
                    result = firstN + secondN;
                    break;
                case "-":
                    result = firstN - secondN;
                    break;
                case "*":
                    result = firstN * secondN;
                    break;
                case "/":
                    result = firstN / secondN;
                    break;
            }

            Console.WriteLine($"{firstN} {mathOperator} {secondN} = {result:F2}");
        }
    }
}