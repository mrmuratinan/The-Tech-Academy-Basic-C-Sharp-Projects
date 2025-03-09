using System;
using System.Collections.Generic;

namespace Iterations
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("\n\nExercise 1\n\n");
         int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

         for (int i = 0; i < testScores.Length; i++)
         {
            if (testScores[i] > 85)
            {
               Console.WriteLine( "Passing test score: " + i + " - " + testScores[i]);
            }
         }
         Console.WriteLine("\n\nExercise 2\n\n");

         string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

         for (int j = 0; j < names.Length; j++)
         {
            Console.WriteLine(names[j]);
         }
         Console.WriteLine("\n\nExercise 3\n\n");

         List<int> testScores1 = new List<int>()
         {
            98,
            99,
            85,
            70,
            82,
            34,
            34,
            90,
            94
         };

         testScores1.RemoveAll(item=> item==34);

         foreach (int score in testScores1)
         {
            if (score < 85)
            {
               Console.WriteLine("Passing test score: " + score);
            }
         }
         Console.WriteLine("\n\nExercise 4\n\n");

         List<string> names1 = new List<string>()
         {
            "Jesse",
            "Erik",
            "Daniel",
            "Adam"
         };
         foreach (string name in names1)
         {
            Console.WriteLine(name);
         }

      }
   }
}
