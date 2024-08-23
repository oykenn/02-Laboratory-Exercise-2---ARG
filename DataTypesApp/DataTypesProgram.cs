using System;

namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {   
            // greetings
            Console.WriteLine("hello Welcome");

            // inputing apple quantitites 
            Console.Write("Enter the pieces of apple: ");
            int inputPiecesOfApple = int.Parse(Console.ReadLine());

            // inputing apple prices, and concatinating quantities of the apples bought
            Console.Write($"Enter the total price of {inputPiecesOfApple} apple(s): ");
            double inputApplePrice = double.Parse(Console.ReadLine());

            //converting the "double" price of the apple to int
            int convertedPrice = (int)inputApplePrice;

            //printing
            Console.WriteLine($"the total price of {inputPiecesOfApple} apple(s) is {inputApplePrice}");
            Console.WriteLine($"the value of original price is {inputApplePrice}");
            Console.WriteLine($"The value of converted price is: {convertedPrice}");
           
            
        }
    }
}
