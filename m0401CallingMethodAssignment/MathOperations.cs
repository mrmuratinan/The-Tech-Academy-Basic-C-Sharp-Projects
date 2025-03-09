using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m0401Module4Assignments
{
    class MathOperations
    {
      // Method 1: Square the input number
      public int Square(int number)
      {
         return number * number;
      }

      // Method 2: Double the input number
      public int Double(int number)
      {
         return number * 2;
      }

      // Method 3: Add 10 to the input number
      public int AddTen(int number)
      {
         return number + 10;
      }



      // Method 4: Takes an integer, performs addition, and returns the result
      public int Calculate(int number)
      {
         return number + 10; // Example: Add 10 to the input
      }

      // Method 4: Takes a decimal, performs multiplication, and returns the result as an integer
      public int Calculate(decimal number)
      {
         return (int)(number * 2); // Example: Multiply by 2 and cast to integer
      }

      // Method 4: Takes a string, converts it to an integer, performs subtraction, and returns the result
      public int Calculate(string numberText)
      {
         if (int.TryParse(numberText, out int number))
         {
            return number - 5; // Example: Subtract 5 from the parsed integer
         }
         else
         {
            throw new ArgumentException("Invalid input. The string could not be converted to an integer.");
         }
      }

      // Method that takes two integers, with the second one being optional
      public int AddNumbers(int num1, int num2 = 0)
      {
         // Perform addition and return the result
         return num1 + num2;
      }
      //**************************************************
      // Methods for Class method assignment
      //**************************************************
      public void DivideByTwo(int number)
      {
         int result = number / 2;
         Console.WriteLine($"The result of dividing {number} by 2 is: {result}");
      }

      // Method with output parameters
      public void CalculateSumAndProduct(int num1, int num2, out int sum, out int product)
      {
         sum = num1 + num2;
         product = num1 * num2;
      }

      // Overloaded method
      public void DivideByTwo(double number)
      {
         double result = number / 2.0;
         Console.WriteLine($"The result of dividing {number} by 2 is: {result}");
      }

      // Static method
      public static void MultiplyByTwo(int number)
      {
         int result = number * 2;
         Console.WriteLine($"The result of multiplying {number} by 2 is: {result}");
      }

      //**************************************************
      // END: Methods for Class method assignment
      //**************************************************
   }
}
