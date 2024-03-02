


namespace _07._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            string result = "";
            if (type == "int")
            {
                result = CompareIntegers(firstValue, secondValue);
            }
            else if (type == "char")
            {
                result = CompareChars(firstValue, secondValue);
            }
            else if (type == "string")
            {
                result = CompareStrings(firstValue, secondValue);
            }

            Console.WriteLine(result);
        }

        private static string CompareStrings(string firstValue, string secondValue)
        {
            
            int result = firstValue.CompareTo(secondValue);

            if (result == 1)
            {
                return firstValue;
            }
            else { 
                return secondValue; 
            }

        }

        private static string CompareChars(string firstValue, string secondValue)
        {
            char firstChar = char.Parse(firstValue);
            char secondChar = char.Parse(secondValue);

            if (firstChar > secondChar) 
            {
                return firstValue;
            }

            return secondValue;
        }

        private static string CompareIntegers(string firstValue, string secondValue)
        {
            int firstInteger = int.Parse(firstValue);
            int secondInteger = int.Parse(secondValue);

            if (firstInteger > secondInteger)
            {
                return firstValue;
            }

            return secondValue;
        }
    }
}