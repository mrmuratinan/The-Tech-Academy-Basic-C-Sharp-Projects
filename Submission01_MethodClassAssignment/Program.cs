using System;

namespace Submission01_MethodClassAssignment
{
   class Program
   {
      static void Main(string[] args)
      {
         // Instantiate the MathOperations class
         MathOperation mathOps = new MathOperation();

         // Call the method with positional arguments
         Console.WriteLine("Calling method with positional arguments:");
         mathOps.PerformMathOperation(5, 10);

         // Call the method with named arguments
         Console.WriteLine("\nCalling method with named arguments:");
         mathOps.PerformMathOperation(firstNumber: 8, secondNumber: 15);

         Console.ReadLine();
      }
   }
}
