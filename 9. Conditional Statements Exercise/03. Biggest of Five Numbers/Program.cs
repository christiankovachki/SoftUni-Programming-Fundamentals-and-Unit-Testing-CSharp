namespace _03._Biggest_of_Five_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());
            int thirdN = int.Parse(Console.ReadLine());
            int fourthN = int.Parse(Console.ReadLine());
            int fifthN = int.Parse(Console.ReadLine());

            if (firstN > secondN && firstN > thirdN && firstN > fourthN && firstN > fifthN)
            {
                Console.WriteLine(firstN);
            }
            else if (secondN > firstN && secondN > thirdN && secondN > fourthN && secondN > fifthN)
            {
                Console.WriteLine(secondN);
            }
            else if (thirdN > firstN && thirdN > secondN && thirdN > fourthN && thirdN > fifthN)
            {
                Console.WriteLine(thirdN);
            }
            else if (fourthN > firstN && fourthN > secondN && fourthN > thirdN && fourthN > fifthN) 
            {
                Console.WriteLine(fourthN);
            }
            else if (fifthN > firstN && fifthN > secondN && fifthN > thirdN && fifthN > fourthN)
            {
                Console.WriteLine(fifthN);
            }
        }
    }
}