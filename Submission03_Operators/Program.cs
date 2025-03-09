using System;
using System.Runtime.CompilerServices;

namespace Submission03_Operators
{
   class Program
   {
      static void Main(string[] args)
      {
         // Create two Employee objects
         Employee employee1 = new Employee(1, "Jesse", "Brown");
         Employee employee2 = new Employee(2, "Jane", "Black");

         // Compare the objects using the overloaded == operator
         Console.WriteLine("Comparing the equality");
         bool areEqual = employee1 == employee2;
         Display(areEqual);

         Console.WriteLine("\n\nComparing the inequality");
         areEqual = !(employee1 != employee2);
         Display(areEqual);

         Console.ReadLine();
      }
      static void Display(bool comparison)
      {
         if (comparison)
         {
            Console.WriteLine("The employees are the same.");
         }
         else
         {
            Console.WriteLine("The employees are different.");
         }
      }
   }
}
