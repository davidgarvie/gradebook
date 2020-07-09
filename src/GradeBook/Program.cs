using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("David's book");
            book.AddGrade(81.5);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();

            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The average is {stats.Average}");
        }
    }
}
