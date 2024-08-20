using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Enter 5 grades separated by new line");

            // inputing 5 grades
            Console.Write("grade 1: ");
            int grade1 = int.Parse(Console.ReadLine());

            Console.Write("grade 2: ");
            int grade2 = int.Parse(Console.ReadLine());

            Console.Write("grade 3: ");
            int grade3 = int.Parse(Console.ReadLine());

            Console.Write("grade 4: ");
            int grade4 = int.Parse(Console.ReadLine());

            Console.Write("grade 5: ");
            int grade5 = int.Parse(Console.ReadLine());

            // Computes the average
            double totalAve = (grade1 + grade2 + grade3 + grade4 + grade5) / 5.0;

             // Rounding off the average
            int finalAve = (int)Math.Round(totalAve);
             // Prints the results
            Console.WriteLine($"The average is {totalAve} and rounded off to {finalAve}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
