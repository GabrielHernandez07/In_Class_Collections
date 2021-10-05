using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> studentRecords = new Dictionary<int, double>();
            studentRecords.Add(1, 2.5);
            studentRecords.Add(2, 3.5);
            studentRecords.Add(3, 4.0);

            Console.WriteLine("Which student do you wnat to see the GPA off? >>");
            int studentID = Convert.ToInt32(Console.ReadLine());

            if (studentRecords.ContainsKey(studentID)==true)
            {
                Console.WriteLine($"{studentRecords[studentID].ToString("N1")}");
            }
            else
            {
                Console.WriteLine($"THe student with {studentID} was not found");
            }

        }
    }
}
