using System;
using System.Collections.Generic;
using System.Linq;

namespace MyGradebookList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();

            Console.WriteLine("Enter student name (or press \"ENTER\" to advance to grades): ");

            string newStudent;
            do
            {
                newStudent = Console.ReadLine();
                if ((newStudent != ""))
                {
                    students.Add(newStudent);

                }
            } while (newStudent != "");

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Grade for {students[i]}: ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            Console.WriteLine("\nClass Roster:");
            for (int i = 0; i < students.Count; i++)
            {

                Console.WriteLine($"{students[i]} ({grades[i]})");
                //Console.ReadLine();

            }

            double sum = grades.Sum();
            double average = sum / grades.Count;
            Console.WriteLine($"Average grade: {average}");

            Console.ReadLine();
        }
    }
}
