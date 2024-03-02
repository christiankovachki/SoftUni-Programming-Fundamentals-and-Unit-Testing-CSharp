namespace _01._Calculate_Average_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            double sumOfAllGrades = 0;
            for (int i = 1; i <= countOfStudents; i++)
            {
                sumOfAllGrades += double.Parse(Console.ReadLine());
            }

            double averageGrade = sumOfAllGrades / countOfStudents;

            Console.WriteLine($"{averageGrade:F2}");
        }
    }
}