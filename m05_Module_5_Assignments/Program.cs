using System;
using System.Security.Cryptography.X509Certificates;

namespace m05_Assignments
{
   class Program
   {
      static void Main(string[] args)
      {
         //********** Assignment 1 **********
         // Methods and Objects Assignment
         // *********************************

         Employee sam = new Employee() { FirstName = "Sample", LastName = "Employee" };
         sam.SayName();
         Console.ReadLine();

      }
   }
}
