using System;

namespace Submission01_MethodClassAssignment
{
   public class MathOperation
   {
      // Void method that takes two integers as parameters
      public void PerformMathOperation(int firstNumber, int secondNumber)
      {
         // Perform a math operation on the first integer (e.g., multiply by 2)
         int result = firstNumber * 2;

         // Display the second integer to the screen
         Console.WriteLine($"The operation is firstNumber * 2");
         Console.WriteLine($"The result for {0} is: {1}", firstNumber, result);
         Console.WriteLine($"The second number displayed : {secondNumber}");
      }
   }
}
