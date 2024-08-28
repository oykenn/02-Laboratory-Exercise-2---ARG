using System; 

namespace StudentGradeApplication{
    class frmStudentGradeProgram{
        static void Main(String []args){

            Console.WriteLine("hello Welcome, please enter your name and grades to see your average. ");
            Console.WriteLine("--------------------------------------------------------------------- ");

            Console.Write("name: ");
            String name = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------------- ");
            Console.WriteLine("Subject \t\tGrade ");

            Console.Write("English:\t\t");
            double engGrade = double.Parse(Console.ReadLine());

            Console.Write("Math:\t\t\t");
            double mathGrade = double.Parse(Console.ReadLine());
            
            Console.Write("Science:\t\t");
            double sciGrade = double.Parse(Console.ReadLine());

            Console.Write("Filipino:\t\t");
            double filGrade = double.Parse(Console.ReadLine());

            Console.Write("History:\t\t");
            double histoGrade = double.Parse(Console.ReadLine());

            double partialAve = engGrade + mathGrade + sciGrade +  filGrade + histoGrade;
            double totalAve = partialAve / 5 ;

            if(totalAve >= 75){
                Console.WriteLine("the student passed");
                Console.WriteLine($"the general average of {name} is {totalAve}");
            }
            else{
                 Console.WriteLine($"{name} has failed with average of {totalAve}");
            }
        }
    }
}