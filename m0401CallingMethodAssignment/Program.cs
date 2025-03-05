using System;

namespace m0401CallingMethodAssignment
{
   class Program
   {
      static void Main(string[] args)
      {
         // Create an instance of the MathOperations class
         MathOperations mathOps = new MathOperations();

         // Ask the user for input
         Console.Write("Enter a number to perform math operations on: ");
         if (int.TryParse(Console.ReadLine(), out int userInput))
         {
            // Call each method and display the results
            int squaredResult = mathOps.Square(userInput);
            int doubledResult = mathOps.Double(userInput);
            int addTenResult = mathOps.AddTen(userInput);

            Console.WriteLine($"Square of {userInput} is: {squaredResult}");
            Console.WriteLine($"Double of {userInput} is: {doubledResult}");
            Console.WriteLine($"{userInput} plus 10 is: {addTenResult}");
         }
         else
         {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
         }

         // Keep the console window open until the user presses a key
         Console.WriteLine("\nPress any key to exit...");
         Console.ReadKey();

         //**************************************************
         // NEW ASSIGNMENT **********************************
         //**************************************************

         // Call the first method (integer input)
         int intInput = 15;
         int intResult = mathOps.Calculate(intInput);
         Console.WriteLine($"Result of integer calculation ({intInput} + 10): {intResult}");

         // Call the second method (decimal input)
         decimal decimalInput = 7.5m;
         int decimalResult = mathOps.Calculate(decimalInput);
         Console.WriteLine($"Result of decimal calculation ({decimalInput} * 2): {decimalResult}");

         // Call the third method (string input)
         string stringInput = "25";
         try
         {
            int stringResult = mathOps.Calculate(stringInput);
            Console.WriteLine($"Result of string calculation (\"{stringInput}\" - 5): {stringResult}");
         }
         catch (ArgumentException ex)
         {
            Console.WriteLine(ex.Message);
         }

         // Keep the console window open until the user presses a key
         Console.WriteLine("\nPress any key to exit...");
         Console.ReadKey();
      }
   }
}
