using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m0401CallingMethodAssignment
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
   }
}
