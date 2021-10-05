using System;

namespace Collections_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentIDs = {1, 2, 3};
            double[] GPAs = new double[3];
            GPAs[0] = 2.5;
            GPAs[1] = 3.5;
            GPAs[2] = 4;
            //GPAs[3] = 4.6; results in an Index out of bounds exception

            Console.WriteLine("Which student do you wnat to see the GPA off? >>");
            int studentID = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIDs.Length; i++)
            {
                int id = studentIDs[i];
                double gpa = GPAs[i];
                
                if (studentID == id )
                {
                    Console.WriteLine($"{gpa.ToString("N1")}");
                }
            }


        }
    }
}
