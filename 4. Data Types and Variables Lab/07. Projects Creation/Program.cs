﻿namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitecture = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            int neededHours = projectsCount * 3;

            Console.WriteLine($"The architect {nameOfArchitecture} will need {neededHours} hours to complete {projectsCount} project/s.");
        }
    }
}