using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("");
            book.AddGrade(37.1);
            book.AddGrade(43.9);
            book.AddGrade(97.3);
            book.GetStatistics();
        }
    }
}
