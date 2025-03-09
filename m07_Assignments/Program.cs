using System;

namespace m07_Assignments
{
   class Program
   {
      static void Main(string[] args)
      {
         // ***************************
         // Datetime Assignment 
         // ***************************

         // Print the current date and time
         DateTime currentTime = DateTime.Now;
         Console.WriteLine("Current date and time: " + currentTime);

         // Ask the user for a number
         Console.Write("Enter a number of hours: ");
         float userInput = float.Parse(Console.ReadLine());
         DateTime futureTime = currentTime.AddHours(userInput);
         Console.WriteLine($"In {userInput} hours, the time will be: {futureTime}");
  
         Console.ReadKey();
         Console.ReadKey();
      }
   }
}