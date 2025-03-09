using System;

namespace Submission02_Polymorphism
{
   class Program
   {
      static void Main(string[] args)
      {
         // Create an Employee object
         Employee employee = new Employee();

         // Use polymorphism to create an object of type IQuittable
         //IQuittable IEmployee = new Employee();
         IQuittable IEmployee = employee;

         employee.Name = "Jesse";

         // Call the Quit() method on the IQuittable object
         IEmployee.Quit();

         Console.ReadLine();
      }
   }
}