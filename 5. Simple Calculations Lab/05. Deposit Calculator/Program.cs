using System;

namespace _05._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double accumulatedInterest = depositedAmount * (annualInterestRate / 100);
            double monthlyInterest = accumulatedInterest / 12;

            double totalAmount = depositedAmount + termOfDeposit * monthlyInterest;

            Console.WriteLine($"{totalAmount:F2}");
        }
    }
}