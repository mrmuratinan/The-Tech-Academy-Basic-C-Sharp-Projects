using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission01_MethodClassAssignment
{
   public class MathOperations
   {
      // Void method that takes two integers as parameters
      public void PerformMathOperation(int firstNumber, int secondNumber)
      {
         // Perform a math operation on the first integer (e.g., multiply by 2)
         int result = firstNumber * 2;

         // Display the second integer to the screen
         Console.WriteLine($"The result of the math operation on {firstNumber} is: {result}");
         Console.WriteLine($"The second number displayed is: {secondNumber}");
      }
   }
}
