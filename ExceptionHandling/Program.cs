using System;
using System.Linq.Expressions;

class Program
{
   static void Main()
   {
      try
      {
         Console.Write("Enter number one: ");
         int num1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Enter a number  two: ");
         int num2 = Convert.ToInt32(Console.ReadLine());
         int num3 = num1 / num2;
         Console.WriteLine("The division of {0} to {1} is {2}", num1, num2, num3);

      }
      catch (Exception xp)
      {
         //Console.WriteLine("An error occurred: " + fxp.Message);
         string strType = xp.GetType().ToString();
         switch (strType)
         {
            case "System.FormatException":
               Console.Write("Please type a whole number!");
               break;
            case "System.DivideByZeroException":
               Console.Write("Please do not divide by zero!");
               break;
            default:
               Console.Write(xp.Message);
               break;
         }
      }
      finally
      {
         Console.WriteLine("\nThank you for using this program!");
      }
   }
}


