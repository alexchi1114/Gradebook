using System;
using System.Collections.Generic;

namespace GradeBook {
    public class Book 
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics() {

            var result = new Statistics();
        
            var sum = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            foreach (var grade in grades)
            {
                result.High = Math.Max(result.High, grade);
                result.Low = Math.Min(result.Low, grade);
                sum += grade;
            }

            result.Average = sum/grades.Count;
            
            System.Console.WriteLine("Average is "+result.Average);
            System.Console.WriteLine("Low score is "+result.Low);
            System.Console.WriteLine("High score is "+result.High);

            return result;
        }

        List<double> grades;
        public string Name;
    }
}