using System;

namespace m0401Module4Assignments
{
   class Program
   {
      static void Main(string[] args)
      {
         MathOperations mathOps = new MathOperations();

         goto StartSection;

         //**************************************************
         // Calling Method Assignment
         //**************************************************

         // Create an instance of the MathOperations class


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
         // Main Method Assignment (Method Overloading)
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

         //**************************************************
         // Method Assignment (Optional Parameter)
         //**************************************************

         Console.Write("Enter the first number: ");
         int firstNumber = int.Parse(Console.ReadLine());

         // Ask the user for the second number (optional)
         Console.Write("Enter the second number (optional, press Enter to skip): ");
         string secondNumberInput = Console.ReadLine();

         int result;

         // Check if the user provided a second number
         if (string.IsNullOrEmpty(secondNumberInput))
         {
            // Call the method with only the first number
            result = mathOps.AddNumbers(firstNumber);
         }
         else
         {
            // Parse the second number and call the method with both numbers
            int secondNumber = int.Parse(secondNumberInput);
            result = mathOps.AddNumbers(firstNumber, secondNumber);
         }

         // Display the result
         Console.WriteLine($"The result is: {result}");

         // Pause the console to view the output
         Console.WriteLine("Press any key to exit...");
         Console.ReadKey();

      StartSection:

         //**************************************************
         // Class Method Assignment
         //**************************************************

         // Instantiate the MathOperations class
         //MathOperations mathOps = new MathOperations();

         // Ask the user to enter a number
         Console.Write("Enter a number to divide by 2: ");
         int userNumber = int.Parse(Console.ReadLine());

         // Call the DivideByTwo method
         mathOps.DivideByTwo(userNumber);

         // Demonstrate the method with output parameters
         int sum, product;
         mathOps.CalculateSumAndProduct(5, 10, out sum, out product);
         Console.WriteLine($"Sum: {sum}, Product: {product}");

         // Demonstrate the overloaded method
         mathOps.DivideByTwo(15.75);

         // Demonstrate the static class method
         MathOperations.MultiplyByTwo(8);

         // Pause the console to view the output
         Console.WriteLine("Press any key to exit...");
         Console.ReadKey();
      }
   }
}
