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
   }
}
