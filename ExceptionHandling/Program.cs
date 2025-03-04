using System;
using System.Linq.Expressions;

class Program
{
   static void Main()
   {
      goto Start;
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

   Start:

      //Create a list of integers
      List<int> intList = new List<int>() { 5, 99, 23, 10, 185, 22, 12, 2994, 101, 77000 };
      //Ask the user for input and loop through the list dividing each number by the input 
      bool numValid = false;
      while (!numValid)
      {
         //Using a try/catch block to give error message
         try
         {
            Console.WriteLine("\nEnter a number to divide the above list by: ");
            float numDivide = float.Parse(Console.ReadLine());
            //If statement to check if the user entered 0
            if (numDivide == 0)
            {
               Console.WriteLine("Please enter a number other than 0.");
            }
            //Dividing each number in the list by the input 
            else
            {
               foreach (int num in intList)
               {
                  float Divide = num / numDivide;
                  Console.WriteLine(num + "/" + numDivide + " = " + Divide);
               }
               numValid = true;
            }
         }
         //Catch block to display error message for string input 
         catch (FormatException)
         {
            Console.WriteLine("Invalid input. Please enter a number.");
         }
      }
      //Message to let the user know the program has exited the try/catch block 
      Console.WriteLine("The program has exited the try/catch block.");

   }


}


