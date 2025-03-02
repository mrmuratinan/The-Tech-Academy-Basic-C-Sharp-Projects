using System;
using System.Collections.Generic;
using System.ComponentModel;

class ArrayAssignment
{
   static void Main()
   {
      // 1. Create a one-dimensional Array of strings
      string[] animalArray = { "Lion", "Tiger", "Elephant", "Dog", "Cat", "Horse", "Cow", "Sheep", "Bird", "Rabbit" };
      //Ask the user for a index
      Console.WriteLine("\nSelect a number between 0 and 9:");
      int intIndex = Convert.ToInt32(Console.ReadLine());
      bool boolFlag = false;
      while (!boolFlag)
      {
         try
         {
            Console.WriteLine("\nYour favorite animal is " + animalArray[intIndex]);
            boolFlag = true;
         }
         //Error handling for invalid index
         catch
         {
            Console.WriteLine("\nSorry, that number selection is invalid. Please select a number between 0 and 9. ");
            intIndex = Convert.ToInt32(Console.ReadLine());
         }
      }

      // 2. Create a one-dimensional Array of integers.
      int[] intArray = { 17, 22, 3, 67, 5, 91, 11, 42, 23, 6 };
      //Ask the user for a index
      Console.WriteLine("\nSelect a number between 0 and 9:");
      intIndex = Convert.ToInt32(Console.ReadLine());
      boolFlag = false;

      while (!boolFlag)
      {
         try
         {
            Console.WriteLine("\nYour favorite number is " + intArray[intIndex]);
            boolFlag = true;
         }
         //Error handling for invalid index
         catch
         {
            Console.WriteLine("\nSorry, that number selection is invalid. Select a number between 0 and 9. ");
            intIndex = Convert.ToInt32(Console.ReadLine());
         }
      }

      // 4. Create a list of strings
      List<string> animalList = new List<string>()
      {
         "Lion",
         "Tiger",
         "Elephant",
         "Dog",
         "Cat",
         "Horse",
         "Cow",
         "Sheep",
         "Bird",
         "Rabbit"
      };
      //Ask the user for a number to display the string at that index
      Console.WriteLine("\nSelect another number between 0 and 9:");
      intIndex = Convert.ToInt32(Console.ReadLine());
      boolFlag = false;

      while (!boolFlag)
      {
         try
         {
            Console.WriteLine("\nYour favorite animal is " + animalList[intIndex]);
            boolFlag = true;
         }
         // Error handling for invalid index
         catch
         {
            Console.WriteLine("\nSorry, that number selection is invalid. Select a number between 0 and 9. ");
            intIndex = Convert.ToInt32(Console.ReadLine());
         }
      }

   }
}
