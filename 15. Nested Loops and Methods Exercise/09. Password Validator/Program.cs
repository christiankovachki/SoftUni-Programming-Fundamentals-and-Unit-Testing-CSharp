

namespace _09._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isPasswordLengthInRange = CheckPasswordLength(password);
            bool isPasswordWithValidSymbols = CheckPasswordForValidSymbols(password);
            bool isPasswordWithTwoDigits = CheckPasswordForTwoDigits(password);

            if (isPasswordLengthInRange && isPasswordWithValidSymbols && isPasswordWithTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }

            if (!isPasswordLengthInRange)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPasswordWithValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isPasswordWithTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static bool CheckPasswordForTwoDigits(string password)
        {
            int counter = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol)) 
                {
                    counter++;
                    if (counter == 2) 
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool CheckPasswordForValidSymbols(string password)
        {
            if (!password.All(Char.IsLetterOrDigit))
            {
                return false;
            }

            return true;
        }

        private static bool CheckPasswordLength(string password)
        {
            int length = password.Length;

            if (length >= 6 && length <= 10)
            {
                return true;
            }

            return false;
        }


    }
}